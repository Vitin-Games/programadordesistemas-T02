namespace Alertas
{
    partial class Aletas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnalertasimples = new System.Windows.Forms.Button();
            this.btnalertarobusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(300, 34);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(308, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Teste os alertas abaixos";
            // 
            // btnalertasimples
            // 
            this.btnalertasimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(103)))), ((int)(((byte)(86)))));
            this.btnalertasimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalertasimples.Location = new System.Drawing.Point(342, 110);
            this.btnalertasimples.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnalertasimples.Name = "btnalertasimples";
            this.btnalertasimples.Size = new System.Drawing.Size(228, 52);
            this.btnalertasimples.TabIndex = 1;
            this.btnalertasimples.Text = "Alerta Simples";
            this.btnalertasimples.UseVisualStyleBackColor = false;
            this.btnalertasimples.Click += new System.EventHandler(this.btnalertasimples_Click);
            // 
            // btnalertarobusto
            // 
            this.btnalertarobusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnalertarobusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnalertarobusto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnalertarobusto.FlatAppearance.BorderSize = 0;
            this.btnalertarobusto.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalertarobusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnalertarobusto.Location = new System.Drawing.Point(329, 186);
            this.btnalertarobusto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnalertarobusto.Name = "btnalertarobusto";
            this.btnalertarobusto.Size = new System.Drawing.Size(259, 70);
            this.btnalertarobusto.TabIndex = 2;
            this.btnalertarobusto.Text = "Alerta Robusto";
            this.btnalertarobusto.UseVisualStyleBackColor = false;
            this.btnalertarobusto.Click += new System.EventHandler(this.btnalertarobusto_Click);
            // 
            // Aletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.btnalertarobusto);
            this.Controls.Add(this.btnalertasimples);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Aletas";
            this.Text = "Aletas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnalertasimples;
        private System.Windows.Forms.Button btnalertarobusto;
    }
}

