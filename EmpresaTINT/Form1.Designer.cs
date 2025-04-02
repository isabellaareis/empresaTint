namespace EmpresaTINT
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
            this.TINT01 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TINT01
            // 
            this.TINT01.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TINT01.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TINT01.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TINT01.Location = new System.Drawing.Point(-5, -2);
            this.TINT01.Name = "TINT01";
            this.TINT01.Size = new System.Drawing.Size(361, 80);
            this.TINT01.TabIndex = 0;
            this.TINT01.Text = "TINT01";
            this.TINT01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TINT01.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.Location = new System.Drawing.Point(81, 176);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(175, 59);
            this.Cadastrar.TabIndex = 1;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // atualizar
            // 
            this.atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.Location = new System.Drawing.Point(81, 344);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(175, 59);
            this.atualizar.TabIndex = 2;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // consultar
            // 
            this.consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultar.Location = new System.Drawing.Point(81, 257);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(175, 59);
            this.consultar.TabIndex = 3;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // excluir
            // 
            this.excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluir.Location = new System.Drawing.Point(81, 425);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(175, 60);
            this.excluir.TabIndex = 4;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 595);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.TINT01);
            this.Name = "Form1";
            this.Text = "Título da Página";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TINT01;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button excluir;
    }
}

