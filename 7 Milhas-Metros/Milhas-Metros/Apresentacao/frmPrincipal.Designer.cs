namespace Milhas_Metros
{
    partial class frmPrincipal
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPriscillaRizzardo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(25, 39);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(152, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Informe um número (em milhas)";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(47, 55);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(113, 20);
            this.txbNumero.TabIndex = 1;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(25, 124);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.Text = "Resposta";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(69, 81);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPriscillaRizzardo
            // 
            this.lblPriscillaRizzardo.AutoSize = true;
            this.lblPriscillaRizzardo.Location = new System.Drawing.Point(83, 207);
            this.lblPriscillaRizzardo.Name = "lblPriscillaRizzardo";
            this.lblPriscillaRizzardo.Size = new System.Drawing.Size(130, 13);
            this.lblPriscillaRizzardo.TabIndex = 4;
            this.lblPriscillaRizzardo.Text = "Made by Priscilla Rizzardo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(225, 247);
            this.Controls.Add(this.lblPriscillaRizzardo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "frmPrincipal";
            this.Text = "Milhas  x Metros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPriscillaRizzardo;
    }
}

