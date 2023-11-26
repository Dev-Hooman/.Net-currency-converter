namespace Q5
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
            comboBox1 = new ComboBox();
            txt_ConvertToRupees = new TextBox();
            label1 = new Label();
            label2 = new Label();
            display_Rs = new Label();
            a = new Label();
            label3 = new Label();
            display_dollar = new Label();
            label5 = new Label();
            label6 = new Label();
            convertFromRupees = new TextBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(98, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txt_ConvertToRupees
            // 
            txt_ConvertToRupees.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_ConvertToRupees.Location = new Point(98, 190);
            txt_ConvertToRupees.Name = "txt_ConvertToRupees";
            txt_ConvertToRupees.Size = new Size(166, 23);
            txt_ConvertToRupees.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 193);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 2;
            label1.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(98, 286);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 3;
            label2.Text = "Rs:";
            // 
            // display_Rs
            // 
            display_Rs.AutoSize = true;
            display_Rs.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            display_Rs.Location = new Point(127, 286);
            display_Rs.Name = "display_Rs";
            display_Rs.Size = new Size(0, 15);
            display_Rs.TabIndex = 4;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            a.Location = new Point(68, 115);
            a.Name = "a";
            a.Size = new Size(243, 36);
            a.TabIndex = 5;
            a.Text = "Convert To Rupees";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(474, 115);
            label3.Name = "label3";
            label3.Size = new Size(285, 36);
            label3.TabIndex = 11;
            label3.Text = "Convert From  Rupees";
            // 
            // display_dollar
            // 
            display_dollar.AutoSize = true;
            display_dollar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            display_dollar.Location = new Point(564, 286);
            display_dollar.Name = "display_dollar";
            display_dollar.Size = new Size(0, 15);
            display_dollar.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(492, 193);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 9;
            label5.Text = "Rs:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(544, 286);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 8;
            label6.Text = "$";
            // 
            // convertFromRupees
            // 
            convertFromRupees.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            convertFromRupees.Location = new Point(521, 190);
            convertFromRupees.Name = "convertFromRupees";
            convertFromRupees.Size = new Size(166, 23);
            convertFromRupees.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(521, 230);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(166, 23);
            comboBox2.TabIndex = 6;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(274, 9);
            label4.Name = "label4";
            label4.Size = new Size(251, 36);
            label4.TabIndex = 12;
            label4.Text = "Currency Converter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(display_dollar);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(convertFromRupees);
            Controls.Add(comboBox2);
            Controls.Add(a);
            Controls.Add(display_Rs);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ConvertToRupees);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "\\";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox txt_ConvertToRupees;
        private Label label1;
        private Label label2;
        private Label display_Rs;
        private Label a;
        private Label label3;
        private Label display_dollar;
        private Label label5;
        private Label label6;
        private TextBox convertFromRupees;
        private ComboBox comboBox2;
        private Label label4;
    }
}