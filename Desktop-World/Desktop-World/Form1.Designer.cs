namespace Desktop_World
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            uname = new TextBox();
            uemail = new TextBox();
            label2 = new Label();
            Submit = new Button();
            showname = new Label();
            showemail = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 93);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // uname
            // 
            uname.Location = new Point(259, 90);
            uname.Name = "uname";
            uname.Size = new Size(220, 23);
            uname.TabIndex = 1;
            // 
            // uemail
            // 
            uemail.Location = new Point(259, 138);
            uemail.Name = "uemail";
            uemail.Size = new Size(220, 23);
            uemail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 141);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // Submit
            // 
            Submit.BackColor = SystemColors.HotTrack;
            Submit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Submit.ForeColor = SystemColors.ButtonFace;
            Submit.Location = new Point(311, 188);
            Submit.Name = "Submit";
            Submit.Size = new Size(100, 39);
            Submit.TabIndex = 4;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // showname
            // 
            showname.AutoSize = true;
            showname.Location = new Point(214, 312);
            showname.Name = "showname";
            showname.Size = new Size(39, 15);
            showname.TabIndex = 5;
            showname.Text = "Name";
            // 
            // showemail
            // 
            showemail.AutoSize = true;
            showemail.Location = new Point(214, 345);
            showemail.Name = "showemail";
            showemail.Size = new Size(36, 15);
            showemail.TabIndex = 6;
            showemail.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 447);
            Controls.Add(showemail);
            Controls.Add(showname);
            Controls.Add(Submit);
            Controls.Add(uemail);
            Controls.Add(label2);
            Controls.Add(uname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Desktop App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox uname;
        private TextBox uemail;
        private Label label2;
        private Button Submit;
        private Label showname;
        private Label showemail;
    }
}
