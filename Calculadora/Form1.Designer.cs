
namespace Calculadora
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
            this.btnAdição = new System.Windows.Forms.Button();
            this.btnSubtração = new System.Windows.Forms.Button();
            this.btnMultiplicação = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.Txt1 = new System.Windows.Forms.Label();
            this.Txt2 = new System.Windows.Forms.Label();
            this.Valor1 = new System.Windows.Forms.TextBox();
            this.Valor2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdição
            // 
            this.btnAdição.Location = new System.Drawing.Point(51, 127);
            this.btnAdição.Name = "btnAdição";
            this.btnAdição.Size = new System.Drawing.Size(47, 41);
            this.btnAdição.TabIndex = 0;
            this.btnAdição.Text = "+";
            this.btnAdição.UseVisualStyleBackColor = true;
            this.btnAdição.Click += new System.EventHandler(this.btnAdição_Click);
            // 
            // btnSubtração
            // 
            this.btnSubtração.Location = new System.Drawing.Point(124, 127);
            this.btnSubtração.Name = "btnSubtração";
            this.btnSubtração.Size = new System.Drawing.Size(47, 41);
            this.btnSubtração.TabIndex = 1;
            this.btnSubtração.Text = "-";
            this.btnSubtração.UseVisualStyleBackColor = true;
            this.btnSubtração.Click += new System.EventHandler(this.btnSubtração_Click);
            // 
            // btnMultiplicação
            // 
            this.btnMultiplicação.Location = new System.Drawing.Point(199, 127);
            this.btnMultiplicação.Name = "btnMultiplicação";
            this.btnMultiplicação.Size = new System.Drawing.Size(47, 41);
            this.btnMultiplicação.TabIndex = 2;
            this.btnMultiplicação.Text = "*";
            this.btnMultiplicação.UseVisualStyleBackColor = true;
            this.btnMultiplicação.Click += new System.EventHandler(this.btnMultiplicação_Click);
            // 
            // btnDivisão
            // 
            this.btnDivisão.Location = new System.Drawing.Point(272, 128);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(47, 40);
            this.btnDivisão.TabIndex = 3;
            this.btnDivisão.Text = "/";
            this.btnDivisão.UseVisualStyleBackColor = true;
            this.btnDivisão.Click += new System.EventHandler(this.btnDivisão_Click);
            // 
            // Txt1
            // 
            this.Txt1.AutoSize = true;
            this.Txt1.Location = new System.Drawing.Point(48, 65);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(94, 13);
            this.Txt1.TabIndex = 4;
            this.Txt1.Text = "Digite um Numero ";
            // 
            // Txt2
            // 
            this.Txt2.AutoSize = true;
            this.Txt2.Location = new System.Drawing.Point(199, 64);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(91, 13);
            this.Txt2.TabIndex = 5;
            this.Txt2.Text = "Digite um Numero";
            // 
            // Valor1
            // 
            this.Valor1.Location = new System.Drawing.Point(51, 91);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(100, 20);
            this.Valor1.TabIndex = 6;
            // 
            // Valor2
            // 
            this.Valor2.Location = new System.Drawing.Point(202, 90);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(100, 20);
            this.Valor2.TabIndex = 7;
            // 
            // Resultado
            // 
            this.Resultado.Location = new System.Drawing.Point(347, 90);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(100, 20);
            this.Resultado.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.btnDivisão);
            this.Controls.Add(this.btnMultiplicação);
            this.Controls.Add(this.btnSubtração);
            this.Controls.Add(this.btnAdição);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdição;
        private System.Windows.Forms.Button btnSubtração;
        private System.Windows.Forms.Button btnMultiplicação;
        private System.Windows.Forms.Button btnDivisão;
        private System.Windows.Forms.Label Txt1;
        private System.Windows.Forms.Label Txt2;
        private System.Windows.Forms.TextBox Valor1;
        private System.Windows.Forms.TextBox Valor2;
        private System.Windows.Forms.TextBox Resultado;
        private System.Windows.Forms.Label label1;
    }
}

