namespace WebClientSuhu
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
            this.tbCelcius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReamur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFahrenheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbCelcius
            // 
            this.tbCelcius.Location = new System.Drawing.Point(145, 24);
            this.tbCelcius.Name = "tbCelcius";
            this.tbCelcius.Size = new System.Drawing.Size(100, 22);
            this.tbCelcius.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suhu Celcius";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(34, 65);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(211, 31);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Konversi";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suhu Reamur";
            // 
            // tbReamur
            // 
            this.tbReamur.Location = new System.Drawing.Point(145, 116);
            this.tbReamur.Name = "tbReamur";
            this.tbReamur.ReadOnly = true;
            this.tbReamur.Size = new System.Drawing.Size(100, 22);
            this.tbReamur.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Suhu Fahrenheit";
            // 
            // tbFahrenheit
            // 
            this.tbFahrenheit.Location = new System.Drawing.Point(145, 155);
            this.tbFahrenheit.Name = "tbFahrenheit";
            this.tbFahrenheit.ReadOnly = true;
            this.tbFahrenheit.Size = new System.Drawing.Size(100, 22);
            this.tbFahrenheit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Suhu Kelvin";
            // 
            // tbKelvin
            // 
            this.tbKelvin.Location = new System.Drawing.Point(145, 194);
            this.tbKelvin.Name = "tbKelvin";
            this.tbKelvin.ReadOnly = true;
            this.tbKelvin.Size = new System.Drawing.Size(100, 22);
            this.tbKelvin.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKelvin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbFahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbReamur);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCelcius);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCelcius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReamur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFahrenheit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKelvin;
    }
}

