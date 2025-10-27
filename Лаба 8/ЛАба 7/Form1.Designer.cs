namespace ЛАба_7
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            label1 = new Label();
            textBox1 = new TextBox();
            Izmerenie = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 171);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 4;
            label1.Text = "Напишите объём ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 168);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 5;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.MouseDown += textBox1_MouseDown;
            // 
            // Izmerenie
            // 
            Izmerenie.AutoSize = true;
            Izmerenie.ForeColor = Color.Red;
            Izmerenie.Location = new Point(123, 256);
            Izmerenie.Name = "Izmerenie";
            Izmerenie.Size = new Size(226, 15);
            Izmerenie.TabIndex = 6;
            Izmerenie.Text = "Отрицательное станет положительным";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "М³", "СМ³", "ДМ³", "КМ³" });
            comboBox1.Location = new Point(345, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(111, 23);
            comboBox1.TabIndex = 7;
            comboBox1.Tag = "";
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 171);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 9;
            label3.Text = "Что перевести";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 230);
            textBox2.MaxLength = 15;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(216, 23);
            textBox2.TabIndex = 11;
            textBox2.KeyDown += textBox2_KeyDown;
            textBox2.KeyPress += textBox2_KeyPress;
            textBox2.MouseDown += textBox2_MouseDown;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "М³", "СМ³", "ДМ³", "КМ³" });
            comboBox2.Location = new Point(345, 168);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(111, 23);
            comboBox2.TabIndex = 12;
            comboBox2.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 233);
            label4.Name = "label4";
            label4.Size = new Size(102, 15);
            label4.TabIndex = 13;
            label4.Text = "Во что перевести";
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 501);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(Izmerenie);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "form1";
            Text = "Перевод в разные единицы измерения";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label Izmerenie;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Label label4;
    }
}
