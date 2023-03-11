namespace sistema
{
    partial class frm_tela_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tela_principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhasComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cap_cli = new System.Windows.Forms.Button();
            this.btn_cad_pro = new System.Windows.Forms.Button();
            this.novaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.minhasComprasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(510, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoClienteToolStripMenuItem,
            this.novoProdutoToolStripMenuItem,
            this.novaCategoriaToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // novoClienteToolStripMenuItem
            // 
            this.novoClienteToolStripMenuItem.Name = "novoClienteToolStripMenuItem";
            this.novoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoClienteToolStripMenuItem.Text = "Novo Cliente";
            this.novoClienteToolStripMenuItem.Click += new System.EventHandler(this.novoClienteToolStripMenuItem_Click);
            // 
            // novoProdutoToolStripMenuItem
            // 
            this.novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            this.novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoProdutoToolStripMenuItem.Text = "Novo Produto";
            this.novoProdutoToolStripMenuItem.Click += new System.EventHandler(this.novoProdutoToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaCompraToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // novaCompraToolStripMenuItem
            // 
            this.novaCompraToolStripMenuItem.Name = "novaCompraToolStripMenuItem";
            this.novaCompraToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.novaCompraToolStripMenuItem.Text = "Nova Compra";
            // 
            // minhasComprasToolStripMenuItem
            // 
            this.minhasComprasToolStripMenuItem.Name = "minhasComprasToolStripMenuItem";
            this.minhasComprasToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.minhasComprasToolStripMenuItem.Text = "Minhas Compras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(510, 306);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cap_cli
            // 
            this.btn_cap_cli.BackColor = System.Drawing.Color.Transparent;
            this.btn_cap_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cap_cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cap_cli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cap_cli.Image = ((System.Drawing.Image)(resources.GetObject("btn_cap_cli.Image")));
            this.btn_cap_cli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cap_cli.Location = new System.Drawing.Point(382, 49);
            this.btn_cap_cli.Name = "btn_cap_cli";
            this.btn_cap_cli.Size = new System.Drawing.Size(116, 93);
            this.btn_cap_cli.TabIndex = 2;
            this.btn_cap_cli.Text = "Novo Cliente";
            this.btn_cap_cli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cap_cli.UseVisualStyleBackColor = false;
            this.btn_cap_cli.Click += new System.EventHandler(this.btn_cap_cli_Click);
            // 
            // btn_cad_pro
            // 
            this.btn_cad_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_pro.Image = ((System.Drawing.Image)(resources.GetObject("btn_cad_pro.Image")));
            this.btn_cad_pro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cad_pro.Location = new System.Drawing.Point(382, 203);
            this.btn_cad_pro.Name = "btn_cad_pro";
            this.btn_cad_pro.Size = new System.Drawing.Size(116, 77);
            this.btn_cad_pro.TabIndex = 3;
            this.btn_cad_pro.Text = "Novo Produto";
            this.btn_cad_pro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cad_pro.UseVisualStyleBackColor = true;
            this.btn_cad_pro.Click += new System.EventHandler(this.btn_cad_pro_Click);
            // 
            // novaCategoriaToolStripMenuItem
            // 
            this.novaCategoriaToolStripMenuItem.Name = "novaCategoriaToolStripMenuItem";
            this.novaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaCategoriaToolStripMenuItem.Text = "Nova Categoria";
            this.novaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.novaCategoriaToolStripMenuItem_Click);
            // 
            // frm_tela_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 332);
            this.Controls.Add(this.btn_cad_pro);
            this.Controls.Add(this.btn_cap_cli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_tela_principal";
            this.Text = "Tela Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem novoClienteToolStripMenuItem;
        private ToolStripMenuItem novoProdutoToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem novaCompraToolStripMenuItem;
        private ToolStripMenuItem minhasComprasToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button btn_cap_cli;
        private Button btn_cad_pro;
        private ToolStripMenuItem novaCategoriaToolStripMenuItem;
    }
}