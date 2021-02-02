namespace empresa
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarExcluirEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listaDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovaEmpresaToolStripMenuItem,
            this.editarExcluirEmpresaToolStripMenuItem,
            this.listaDeEmpresasToolStripMenuItem});
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.empresasToolStripMenuItem.Text = "Menu Principal";
            // 
            // cadastrarNovaEmpresaToolStripMenuItem
            // 
            this.cadastrarNovaEmpresaToolStripMenuItem.Name = "cadastrarNovaEmpresaToolStripMenuItem";
            this.cadastrarNovaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastrarNovaEmpresaToolStripMenuItem.Text = "Cadastrar Nova Empresa";
            this.cadastrarNovaEmpresaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovaEmpresaToolStripMenuItem_Click);
            // 
            // editarExcluirEmpresaToolStripMenuItem
            // 
            this.editarExcluirEmpresaToolStripMenuItem.Name = "editarExcluirEmpresaToolStripMenuItem";
            this.editarExcluirEmpresaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.editarExcluirEmpresaToolStripMenuItem.Text = "Editar/Excluir Empresa";
            this.editarExcluirEmpresaToolStripMenuItem.Click += new System.EventHandler(this.editarExcluirEmpresaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // listaDeEmpresasToolStripMenuItem
            // 
            this.listaDeEmpresasToolStripMenuItem.Name = "listaDeEmpresasToolStripMenuItem";
            this.listaDeEmpresasToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.listaDeEmpresasToolStripMenuItem.Text = "Lista de Empresas";
            this.listaDeEmpresasToolStripMenuItem.Click += new System.EventHandler(this.listaDeEmpresasToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 364);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Empresas S/A";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarExcluirEmpresaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem listaDeEmpresasToolStripMenuItem;
    }
}

