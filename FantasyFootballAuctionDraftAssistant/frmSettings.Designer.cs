namespace FantasyFootballAuctionDraftAssistant
{
    partial class frmSettings
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
            btnLoadExcelData = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadExcelData
            // 
            btnLoadExcelData.Location = new Point(36, 271);
            btnLoadExcelData.Name = "btnLoadExcelData";
            btnLoadExcelData.Size = new Size(363, 40);
            btnLoadExcelData.TabIndex = 0;
            btnLoadExcelData.Text = "Load Excel Data";
            btnLoadExcelData.UseVisualStyleBackColor = true;
            btnLoadExcelData.Click += btnLoadExcelData_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 25);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(0, 25);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(36, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 66);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(checkBox2);
            panel2.Location = new Point(167, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 66);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(checkBox3);
            panel3.Location = new Point(298, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(101, 66);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(checkBox4);
            panel4.Location = new Point(97, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(101, 66);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(checkBox5);
            panel5.Controls.Add(textBox5);
            panel5.Location = new Point(228, 122);
            panel5.Name = "panel5";
            panel5.Size = new Size(101, 66);
            panel5.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(58, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Name";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(69, 19);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Position";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(3, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(54, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "Team";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(0, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(45, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Bye";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(3, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(54, 19);
            checkBox5.TabIndex = 3;
            checkBox5.Text = "Value";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 342);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnLoadExcelData);
            Name = "frmSettings";
            Text = "frmSettings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadExcelData;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Panel panel1;
        private CheckBox checkBox1;
        private Panel panel2;
        private CheckBox checkBox2;
        private Panel panel3;
        private CheckBox checkBox3;
        private Panel panel4;
        private CheckBox checkBox4;
        private Panel panel5;
        private CheckBox checkBox5;
    }
}