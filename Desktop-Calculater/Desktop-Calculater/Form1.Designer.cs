namespace Desktop_Calculater
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
            operand1 = new TextBox();
            operand2 = new TextBox();
            label2 = new Label();
            answer = new TextBox();
            label3 = new Label();
            subract = new Button();
            dividebutton = new Button();
            Plus = new Button();
            multiplybutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 58);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Operand 1";
            // 
            // operand1
            // 
            operand1.Location = new Point(228, 55);
            operand1.Name = "operand1";
            operand1.Size = new Size(212, 23);
            operand1.TabIndex = 1;
            // 
            // operand2
            // 
            operand2.Location = new Point(228, 101);
            operand2.Name = "operand2";
            operand2.Size = new Size(212, 23);
            operand2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 104);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Operand 2";
            // 
            // answer
            // 
            answer.Location = new Point(228, 146);
            answer.Name = "answer";
            answer.ReadOnly = true;
            answer.Size = new Size(212, 23);
            answer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 149);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Result";
            // 
            // subract
            // 
            subract.CausesValidation = false;
            subract.Location = new Point(234, 226);
            subract.Name = "subract";
            subract.Size = new Size(75, 23);
            subract.TabIndex = 7;
            subract.Text = "Subtract";
            subract.UseVisualStyleBackColor = true;
            subract.Click += minus;
            // 
            // dividebutton
            // 
            dividebutton.Location = new Point(422, 226);
            dividebutton.Name = "dividebutton";
            dividebutton.Size = new Size(75, 23);
            dividebutton.TabIndex = 9;
            dividebutton.Text = "Divide";
            dividebutton.UseVisualStyleBackColor = true;
            dividebutton.Click += mydivide;
            // 
            // Plus
            // 
            Plus.CausesValidation = false;
            Plus.Location = new Point(147, 226);
            Plus.Name = "Plus";
            Plus.Size = new Size(75, 23);
            Plus.TabIndex = 10;
            Plus.Text = "Add";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += plus;
            // 
            // multiplybutton
            // 
            multiplybutton.Location = new Point(328, 226);
            multiplybutton.Name = "multiplybutton";
            multiplybutton.Size = new Size(75, 23);
            multiplybutton.TabIndex = 11;
            multiplybutton.Text = "Multiply";
            multiplybutton.UseVisualStyleBackColor = true;
            multiplybutton.Click += mymultiply;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(multiplybutton);
            Controls.Add(Plus);
            Controls.Add(dividebutton);
            Controls.Add(subract);
            Controls.Add(answer);
            Controls.Add(label3);
            Controls.Add(operand2);
            Controls.Add(label2);
            Controls.Add(operand1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculater";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox operand1;
        private TextBox operand2;
        private Label label2;
        private TextBox answer;
        private Label label3;
        private Button subract;
        private Button dividebutton;
        private Button Plus;
        private Button mymultpliy;
        private Button multiplybutton;
    }
}
