namespace CurrencyConverter
{
    partial class Form1
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.labelFromCurrency = new System.Windows.Forms.Label();
            this.comboBoxFromCurrency = new System.Windows.Forms.ComboBox();
            this.labelToCurrency = new System.Windows.Forms.Label();
            this.comboBoxToCurrency = new System.Windows.Forms.ComboBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelConvertAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(384, 23);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Currency Converter";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.ForeColor = System.Drawing.Color.White;
            this.labelAmount.Location = new System.Drawing.Point(58, 44);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(112, 20);
            this.labelAmount.TabIndex = 1;
            this.labelAmount.Text = "Enter Amount:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAmount.Location = new System.Drawing.Point(181, 44);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 2;
            // 
            // labelFromCurrency
            // 
            this.labelFromCurrency.AutoSize = true;
            this.labelFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromCurrency.ForeColor = System.Drawing.Color.White;
            this.labelFromCurrency.Location = new System.Drawing.Point(58, 74);
            this.labelFromCurrency.Name = "labelFromCurrency";
            this.labelFromCurrency.Size = new System.Drawing.Size(117, 20);
            this.labelFromCurrency.TabIndex = 3;
            this.labelFromCurrency.Text = "From Currency:";
            // 
            // comboBoxFromCurrency
            // 
            this.comboBoxFromCurrency.FormattingEnabled = true;
            this.comboBoxFromCurrency.Location = new System.Drawing.Point(181, 76);
            this.comboBoxFromCurrency.Name = "comboBoxFromCurrency";
            this.comboBoxFromCurrency.Size = new System.Drawing.Size(100, 21);
            this.comboBoxFromCurrency.TabIndex = 4;
            // 
            // labelToCurrency
            // 
            this.labelToCurrency.AutoSize = true;
            this.labelToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToCurrency.ForeColor = System.Drawing.Color.White;
            this.labelToCurrency.Location = new System.Drawing.Point(58, 104);
            this.labelToCurrency.Name = "labelToCurrency";
            this.labelToCurrency.Size = new System.Drawing.Size(98, 20);
            this.labelToCurrency.TabIndex = 5;
            this.labelToCurrency.Text = "To Currency:";
            // 
            // comboBoxToCurrency
            // 
            this.comboBoxToCurrency.FormattingEnabled = true;
            this.comboBoxToCurrency.Location = new System.Drawing.Point(181, 106);
            this.comboBoxToCurrency.Name = "comboBoxToCurrency";
            this.comboBoxToCurrency.Size = new System.Drawing.Size(100, 21);
            this.comboBoxToCurrency.TabIndex = 6;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(95, 147);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(75, 23);
            this.buttonConvert.TabIndex = 7;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(181, 147);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelConvertAmount
            // 
            this.labelConvertAmount.AutoSize = true;
            this.labelConvertAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertAmount.Location = new System.Drawing.Point(91, 194);
            this.labelConvertAmount.Name = "labelConvertAmount";
            this.labelConvertAmount.Size = new System.Drawing.Size(142, 20);
            this.labelConvertAmount.TabIndex = 9;
            this.labelConvertAmount.Text = "Converted Amount";
            this.labelConvertAmount.Click += new System.EventHandler(this.labelConvertAmount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.labelConvertAmount);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.comboBoxToCurrency);
            this.Controls.Add(this.labelToCurrency);
            this.Controls.Add(this.comboBoxFromCurrency);
            this.Controls.Add(this.labelFromCurrency);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label labelFromCurrency;
        private System.Windows.Forms.ComboBox comboBoxFromCurrency;
        private System.Windows.Forms.Label labelToCurrency;
        private System.Windows.Forms.ComboBox comboBoxToCurrency;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelConvertAmount;
    }
}

