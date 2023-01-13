namespace Amount
{
    partial class AmountCalc
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTovar = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelShtuk = new System.Windows.Forms.Label();
            this.buttonDobavki = new System.Windows.Forms.Button();
            this.labelStoimost = new System.Windows.Forms.Label();
            this.buttonVichisleniya = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTovar
            // 
            this.labelTovar.AutoSize = true;
            this.labelTovar.Location = new System.Drawing.Point(39, 65);
            this.labelTovar.Name = "labelTovar";
            this.labelTovar.Size = new System.Drawing.Size(38, 13);
            this.labelTovar.TabIndex = 1;
            this.labelTovar.Text = "Товар";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownWidth = 120;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelShtuk
            // 
            this.labelShtuk.AutoSize = true;
            this.labelShtuk.Location = new System.Drawing.Point(83, 118);
            this.labelShtuk.Name = "labelShtuk";
            this.labelShtuk.Size = new System.Drawing.Size(20, 13);
            this.labelShtuk.TabIndex = 6;
            this.labelShtuk.Text = "шт";
            this.labelShtuk.Click += new System.EventHandler(this.labelShtuk_Click);
            // 
            // buttonDobavki
            // 
            this.buttonDobavki.Location = new System.Drawing.Point(129, 112);
            this.buttonDobavki.Name = "buttonDobavki";
            this.buttonDobavki.Size = new System.Drawing.Size(75, 23);
            this.buttonDobavki.TabIndex = 7;
            this.buttonDobavki.Text = "Добавить";
            this.buttonDobavki.UseVisualStyleBackColor = true;
            this.buttonDobavki.Click += new System.EventHandler(this.buttonDobavki_Click);
            // 
            // labelStoimost
            // 
            this.labelStoimost.AutoSize = true;
            this.labelStoimost.Location = new System.Drawing.Point(222, 65);
            this.labelStoimost.Name = "labelStoimost";
            this.labelStoimost.Size = new System.Drawing.Size(42, 13);
            this.labelStoimost.TabIndex = 8;
            this.labelStoimost.Text = "(5 руб.)";
            this.labelStoimost.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonVichisleniya
            // 
            this.buttonVichisleniya.Location = new System.Drawing.Point(42, 310);
            this.buttonVichisleniya.Name = "buttonVichisleniya";
            this.buttonVichisleniya.Size = new System.Drawing.Size(323, 45);
            this.buttonVichisleniya.TabIndex = 9;
            this.buttonVichisleniya.Text = "Вычислить";
            this.buttonVichisleniya.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(74, 184);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 95);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // AmountCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 367);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonVichisleniya);
            this.Controls.Add(this.labelStoimost);
            this.Controls.Add(this.buttonDobavki);
            this.Controls.Add(this.labelShtuk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTovar);
            this.Name = "AmountCalc";
            this.Text = "Стоимость покупки";
            this.Load += new System.EventHandler(this.AmountCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTovar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelShtuk;
        private System.Windows.Forms.Button buttonDobavki;
        private System.Windows.Forms.Label labelStoimost;
        private System.Windows.Forms.Button buttonVichisleniya;
        private System.Windows.Forms.ListBox listBox1;
    }
}

