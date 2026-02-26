namespace mAR5CADO
{
    partial class frmMercado
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
            this.txtProdutos = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblMercado = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProdutos
            // 
            this.txtProdutos.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutos.Location = new System.Drawing.Point(310, 131);
            this.txtProdutos.Name = "txtProdutos";
            this.txtProdutos.Size = new System.Drawing.Size(167, 33);
            this.txtProdutos.TabIndex = 0;
            this.txtProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(327, 279);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(133, 33);
            this.btnVerificar.TabIndex = 1;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantidade.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(310, 181);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(167, 33);
            this.lblQuantidade.TabIndex = 2;
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            // 
            // lblMercado
            // 
            this.lblMercado.AutoSize = true;
            this.lblMercado.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMercado.Location = new System.Drawing.Point(328, 81);
            this.lblMercado.Name = "lblMercado";
            this.lblMercado.Size = new System.Drawing.Size(130, 33);
            this.lblMercado.TabIndex = 3;
            this.lblMercado.Text = "Mercado";            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(310, 231);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(167, 31);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            // 
            // frmMercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblMercado);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtProdutos);
            this.Name = "frmMercado";
            this.Text = "Mercado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProdutos;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblMercado;
        private System.Windows.Forms.Label lblStatus;
    }
}

