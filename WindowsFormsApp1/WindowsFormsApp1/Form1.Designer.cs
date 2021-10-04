
namespace WindowsFormsApp1
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
            this.valor1 = new System.Windows.Forms.TextBox();
            this.valor2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.Adição = new System.Windows.Forms.RadioButton();
            this.Subtração = new System.Windows.Forms.RadioButton();
            this.Multiplicação = new System.Windows.Forms.RadioButton();
            this.Divisão = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valor1
            // 
            this.valor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valor1.Font = new System.Drawing.Font("Perpetua Titling MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor1.ForeColor = System.Drawing.Color.OrangeRed;
            this.valor1.Location = new System.Drawing.Point(400, 157);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(109, 51);
            this.valor1.TabIndex = 0;
            this.valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valor1.TextChanged += new System.EventHandler(this.valor1_TextChanged);
            // 
            // valor2
            // 
            this.valor2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valor2.Font = new System.Drawing.Font("Perpetua Titling MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valor2.ForeColor = System.Drawing.Color.OrangeRed;
            this.valor2.Location = new System.Drawing.Point(901, 157);
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(109, 51);
            this.valor2.TabIndex = 1;
            this.valor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultado
            // 
            this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultado.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.ForeColor = System.Drawing.Color.OrangeRed;
            this.resultado.Location = new System.Drawing.Point(614, 405);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(396, 69);
            this.resultado.TabIndex = 2;
            // 
            // Adição
            // 
            this.Adição.AutoSize = true;
            this.Adição.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Adição.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adição.ForeColor = System.Drawing.Color.Sienna;
            this.Adição.Location = new System.Drawing.Point(62, 294);
            this.Adição.Name = "Adição";
            this.Adição.Size = new System.Drawing.Size(174, 45);
            this.Adição.TabIndex = 3;
            this.Adição.TabStop = true;
            this.Adição.Text = "Adição";
            this.Adição.UseVisualStyleBackColor = true;
            this.Adição.CheckedChanged += new System.EventHandler(this.Adição_CheckedChanged);
            // 
            // Subtração
            // 
            this.Subtração.AutoSize = true;
            this.Subtração.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Subtração.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtração.ForeColor = System.Drawing.Color.Sienna;
            this.Subtração.Location = new System.Drawing.Point(264, 294);
            this.Subtração.Name = "Subtração";
            this.Subtração.Size = new System.Drawing.Size(244, 45);
            this.Subtração.TabIndex = 4;
            this.Subtração.TabStop = true;
            this.Subtração.Text = "Subtração";
            this.Subtração.UseVisualStyleBackColor = true;
            this.Subtração.CheckedChanged += new System.EventHandler(this.Subtração_CheckedChanged);
            // 
            // Multiplicação
            // 
            this.Multiplicação.AutoSize = true;
            this.Multiplicação.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Multiplicação.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicação.ForeColor = System.Drawing.Color.Sienna;
            this.Multiplicação.Location = new System.Drawing.Point(537, 294);
            this.Multiplicação.Name = "Multiplicação";
            this.Multiplicação.Size = new System.Drawing.Size(312, 45);
            this.Multiplicação.TabIndex = 5;
            this.Multiplicação.TabStop = true;
            this.Multiplicação.Text = "Multiplicação";
            this.Multiplicação.UseVisualStyleBackColor = true;
            this.Multiplicação.CheckedChanged += new System.EventHandler(this.Multiplicação_CheckedChanged);
            // 
            // Divisão
            // 
            this.Divisão.AutoSize = true;
            this.Divisão.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Divisão.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisão.ForeColor = System.Drawing.Color.Sienna;
            this.Divisão.Location = new System.Drawing.Point(878, 294);
            this.Divisão.Name = "Divisão";
            this.Divisão.Size = new System.Drawing.Size(176, 45);
            this.Divisão.TabIndex = 6;
            this.Divisão.TabStop = true;
            this.Divisão.Text = "Divisão";
            this.Divisão.UseVisualStyleBackColor = true;
            this.Divisão.CheckedChanged += new System.EventHandler(this.Divisão_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(74, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(981, 69);
            this.label1.TabIndex = 7;
            this.label1.Text = "CALCULADORA DO GUSTAVO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(106, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 47);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número 01:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(606, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 47);
            this.label3.TabIndex = 9;
            this.label3.Text = "Número 02:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(102, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(449, 69);
            this.label4.TabIndex = 10;
            this.label4.Text = "RESULTADO:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(376, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(358, 104);
            this.button1.TabIndex = 11;
            this.button1.Text = "LIMPAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1121, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Divisão);
            this.Controls.Add(this.Multiplicação);
            this.Controls.Add(this.Subtração);
            this.Controls.Add(this.Adição);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valor2);
            this.Controls.Add(this.valor1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox valor1;
        private System.Windows.Forms.TextBox valor2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.RadioButton Adição;
        private System.Windows.Forms.RadioButton Subtração;
        private System.Windows.Forms.RadioButton Multiplicação;
        private System.Windows.Forms.RadioButton Divisão;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

