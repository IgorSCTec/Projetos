
namespace Conversao_Escalas_Temperatura
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblConverter = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblConvertPara = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lbltCelsius = new System.Windows.Forms.RadioButton();
            this.lbltKelvin = new System.Windows.Forms.RadioButton();
            this.lbltFahrenheit = new System.Windows.Forms.RadioButton();
            this.lblcFahrenheit = new System.Windows.Forms.RadioButton();
            this.lblcKelvin = new System.Windows.Forms.RadioButton();
            this.lblcCelsius = new System.Windows.Forms.RadioButton();
            this.gbTemperatura = new System.Windows.Forms.GroupBox();
            this.gbConverter = new System.Windows.Forms.GroupBox();
            this.gbTemperatura.SuspendLayout();
            this.gbConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblConverter
            // 
            this.lblConverter.AutoSize = true;
            this.lblConverter.Location = new System.Drawing.Point(27, 31);
            this.lblConverter.Name = "lblConverter";
            this.lblConverter.Size = new System.Drawing.Size(189, 13);
            this.lblConverter.TabIndex = 1;
            this.lblConverter.Text = "Digite quantos graus deseja conveter: ";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(9, 22);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(70, 13);
            this.lblTemperatura.TabIndex = 2;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // lblConvertPara
            // 
            this.lblConvertPara.AutoSize = true;
            this.lblConvertPara.Location = new System.Drawing.Point(9, 25);
            this.lblConvertPara.Name = "lblConvertPara";
            this.lblConvertPara.Size = new System.Drawing.Size(83, 13);
            this.lblConvertPara.TabIndex = 3;
            this.lblConvertPara.Text = "Converter para: ";
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(108, 185);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(189, 23);
            this.btnConverter.TabIndex = 10;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // lbltCelsius
            // 
            this.lbltCelsius.AutoSize = true;
            this.lbltCelsius.Location = new System.Drawing.Point(90, 22);
            this.lbltCelsius.Name = "lbltCelsius";
            this.lbltCelsius.Size = new System.Drawing.Size(58, 17);
            this.lbltCelsius.TabIndex = 11;
            this.lbltCelsius.TabStop = true;
            this.lbltCelsius.Text = "Celsius";
            this.lbltCelsius.UseVisualStyleBackColor = true;
            // 
            // lbltKelvin
            // 
            this.lbltKelvin.AutoSize = true;
            this.lbltKelvin.Location = new System.Drawing.Point(181, 22);
            this.lbltKelvin.Name = "lbltKelvin";
            this.lbltKelvin.Size = new System.Drawing.Size(54, 17);
            this.lbltKelvin.TabIndex = 12;
            this.lbltKelvin.TabStop = true;
            this.lbltKelvin.Text = "Kelvin";
            this.lbltKelvin.UseVisualStyleBackColor = true;
            // 
            // lbltFahrenheit
            // 
            this.lbltFahrenheit.AutoSize = true;
            this.lbltFahrenheit.Location = new System.Drawing.Point(285, 20);
            this.lbltFahrenheit.Name = "lbltFahrenheit";
            this.lbltFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.lbltFahrenheit.TabIndex = 13;
            this.lbltFahrenheit.TabStop = true;
            this.lbltFahrenheit.Text = "Fahrenheit";
            this.lbltFahrenheit.UseVisualStyleBackColor = true;
            // 
            // lblcFahrenheit
            // 
            this.lblcFahrenheit.AutoSize = true;
            this.lblcFahrenheit.Location = new System.Drawing.Point(285, 23);
            this.lblcFahrenheit.Name = "lblcFahrenheit";
            this.lblcFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.lblcFahrenheit.TabIndex = 16;
            this.lblcFahrenheit.TabStop = true;
            this.lblcFahrenheit.Text = "Fahrenheit";
            this.lblcFahrenheit.UseVisualStyleBackColor = true;
            // 
            // lblcKelvin
            // 
            this.lblcKelvin.AutoSize = true;
            this.lblcKelvin.Location = new System.Drawing.Point(181, 23);
            this.lblcKelvin.Name = "lblcKelvin";
            this.lblcKelvin.Size = new System.Drawing.Size(54, 17);
            this.lblcKelvin.TabIndex = 15;
            this.lblcKelvin.TabStop = true;
            this.lblcKelvin.Text = "Kelvin";
            this.lblcKelvin.UseVisualStyleBackColor = true;
            // 
            // lblcCelsius
            // 
            this.lblcCelsius.AutoSize = true;
            this.lblcCelsius.Location = new System.Drawing.Point(90, 23);
            this.lblcCelsius.Name = "lblcCelsius";
            this.lblcCelsius.Size = new System.Drawing.Size(58, 17);
            this.lblcCelsius.TabIndex = 14;
            this.lblcCelsius.TabStop = true;
            this.lblcCelsius.Text = "Celsius";
            this.lblcCelsius.UseVisualStyleBackColor = true;
            // 
            // gbTemperatura
            // 
            this.gbTemperatura.Controls.Add(this.lbltFahrenheit);
            this.gbTemperatura.Controls.Add(this.lbltKelvin);
            this.gbTemperatura.Controls.Add(this.lbltCelsius);
            this.gbTemperatura.Controls.Add(this.lblTemperatura);
            this.gbTemperatura.Location = new System.Drawing.Point(18, 62);
            this.gbTemperatura.Name = "gbTemperatura";
            this.gbTemperatura.Size = new System.Drawing.Size(373, 54);
            this.gbTemperatura.TabIndex = 17;
            this.gbTemperatura.TabStop = false;
            // 
            // gbConverter
            // 
            this.gbConverter.Controls.Add(this.lblcFahrenheit);
            this.gbConverter.Controls.Add(this.lblcKelvin);
            this.gbConverter.Controls.Add(this.lblcCelsius);
            this.gbConverter.Controls.Add(this.lblConvertPara);
            this.gbConverter.Location = new System.Drawing.Point(18, 122);
            this.gbConverter.Name = "gbConverter";
            this.gbConverter.Size = new System.Drawing.Size(373, 54);
            this.gbConverter.TabIndex = 18;
            this.gbConverter.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 220);
            this.Controls.Add(this.gbConverter);
            this.Controls.Add(this.gbTemperatura);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblConverter);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTemperatura.ResumeLayout(false);
            this.gbTemperatura.PerformLayout();
            this.gbConverter.ResumeLayout(false);
            this.gbConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblConverter;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblConvertPara;
        private System.Windows.Forms.Button btnConverter;
        public System.Windows.Forms.RadioButton lbltCelsius;
        public System.Windows.Forms.RadioButton lbltKelvin;
        public System.Windows.Forms.RadioButton lbltFahrenheit;
        public System.Windows.Forms.RadioButton lblcFahrenheit;
        public System.Windows.Forms.RadioButton lblcKelvin;
        public System.Windows.Forms.RadioButton lblcCelsius;
        private System.Windows.Forms.GroupBox gbTemperatura;
        private System.Windows.Forms.GroupBox gbConverter;
    }
}

