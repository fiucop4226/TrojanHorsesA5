using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace TrojanHorses5
{
    public partial class Main : Form
    {
        private ArrayList arrayl = new ArrayList();
        private string fileName = "";
        private bool edit = false;

        public Main()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            

        }

        // File - Open File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrayl.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //changed the while to an if statement to fix the re-opening file select screen
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                FileStream fileStream = new FileStream(fileName, FileMode.Open);

                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    arrayl =(ArrayList)formatter.Deserialize(fileStream);
                }
                catch (SerializationException se)
                {
                    Console.WriteLine("Cannot Open File. Error:" + se.Message);
                    throw;
                }
                finally
                {
                   fileStream.Close();
                }

                this.TextBox.Clear();
                foreach (string s in arrayl)
                {
                    TextBox.Text += s + Environment.NewLine;
                }
            }
        }

        // File - Save 
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrayl.Clear();
            if (fileName == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                string[] content = TextBox.Text.Split('\n');
                foreach (string text in content)
                {
                    arrayl.Add(text);
                }
                Save();
            }
        }

        // File - Save As
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrayl.Clear();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "binary files|*.binary";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                string[] content = TextBox.Text.Split('\n');
                foreach (string line in content)
                {
                    arrayl.Add(line);
                }
                Save();
            }
        }

        // File - Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you would like to close the Application", "Confirmation Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Main dm = new Main();
                dm.Show();
                this.Close();
            }
            else
            {
                this.Activate();
            }
        }

        // Reference Save Class
        private void Save()
        {
            FileStream filestream = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(filestream, arrayl);
            }
            catch (SerializationException se)
            {
                Console.WriteLine("Cannot Save. Error: " + se.Message);
                throw;
            }
            finally
            {
                filestream.Close();
                edit = false;
            }
        }

        // Tool Strip - New Document
        private void Button_New_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ExecutablePath);
        }

        // Tool Strip - Open File
        private void Open_Button_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        // Tool Strip - Save File
        private void Save_Button_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        // Brings up Oath
        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Oath oath = new Oath();
            oath.ShowDialog();
        }

        // Brings up About Dialog
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_Dialog dialog = new About_Dialog();
            dialog.ShowDialog();
        }

        private void Oath_Button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Oath oath = new Oath();
            oath.ShowDialog();
        }

        private void About_Button_Click(object sender, EventArgs e)
        {
            //this.Hide();
            About_Dialog dialog = new About_Dialog();
            dialog.ShowDialog();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (txtBox.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, txtBox.SelectedText);
            txtBox.SelectedText = string.Empty;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (txtBox.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, txtBox.SelectedText);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int position = ((TextBox)this.ActiveControl).SelectionStart;
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(position, Clipboard.GetText());
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Cut_Click(object sender, EventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (txtBox.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, txtBox.SelectedText);
            txtBox.SelectedText = string.Empty;
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            TextBox txtBox = this.ActiveControl as TextBox;
            if (txtBox.SelectedText != string.Empty)
                Clipboard.SetData(DataFormats.Text, txtBox.SelectedText);
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            int position = ((TextBox)this.ActiveControl).SelectionStart;
            this.ActiveControl.Text = this.ActiveControl.Text.Insert(position, Clipboard.GetText());
        }
    }
}
