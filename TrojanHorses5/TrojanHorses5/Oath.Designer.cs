namespace TrojanHorses5
{
    partial class Oath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.memberNames = new System.Windows.Forms.Label();
            this.Group_Names = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberNames
            // 
            this.memberNames.BackColor = System.Drawing.SystemColors.ControlText;
            this.memberNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberNames.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNames.ForeColor = System.Drawing.Color.Orange;
            this.memberNames.Location = new System.Drawing.Point(0, 0);
            this.memberNames.Name = "memberNames";
            this.memberNames.Size = new System.Drawing.Size(955, 581);
            this.memberNames.TabIndex = 2;
            this.memberNames.Text = "Anthony Serrano\r\nAxel Soto\r\nReynaldo Silva\r\nYelise Sanchez\r\nLucas  Stumpf\r\nJose S" +
    "alah\r\n";
            this.memberNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Group_Names
            // 
            this.Group_Names.BackColor = System.Drawing.SystemColors.WindowText;
            this.Group_Names.Dock = System.Windows.Forms.DockStyle.Top;
            this.Group_Names.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group_Names.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Group_Names.HideSelection = false;
            this.Group_Names.Location = new System.Drawing.Point(0, 0);
            this.Group_Names.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Group_Names.Name = "Group_Names";
            this.Group_Names.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Group_Names.Size = new System.Drawing.Size(955, 71);
            this.Group_Names.TabIndex = 3;
            this.Group_Names.Text = "Trojan Horses";
            this.Group_Names.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(831, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 510);
            this.label1.TabIndex = 6;
            this.label1.Text = "I understand that this is a group project.\r\n\r\nIt is in my best interest to partic" +
    "ipate in writing the homework and study all the code from the homework.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // courseName
            // 
            this.courseName.BackColor = System.Drawing.Color.Black;
            this.courseName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.courseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.courseName.Location = new System.Drawing.Point(0, 510);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(831, 71);
            this.courseName.TabIndex = 7;
            this.courseName.Text = "Advanced Windows Programming";
            this.courseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semester
            // 
            this.semester.BackColor = System.Drawing.Color.Black;
            this.semester.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.semester.Location = new System.Drawing.Point(0, 482);
            this.semester.Name = "semester";
            this.semester.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.semester.Size = new System.Drawing.Size(831, 28);
            this.semester.TabIndex = 8;
            this.semester.Text = "Summer  2022";
            this.semester.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Oath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 581);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Group_Names);
            this.Controls.Add(this.memberNames);
            this.Name = "Oath";
            this.Text = "Oath";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberNames;
        private System.Windows.Forms.TextBox Group_Names;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label courseName;
        private System.Windows.Forms.Label semester;
    }
}