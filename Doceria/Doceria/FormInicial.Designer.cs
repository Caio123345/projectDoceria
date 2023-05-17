namespace Doceria
{
    partial class FormInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicial));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelCarrinho = new System.Windows.Forms.Panel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFaleConosco = new RJCodeAdvance.RJControls.RJButton();
            this.btnServiços = new RJCodeAdvance.RJControls.RJButton();
            this.btnProdutos = new RJCodeAdvance.RJControls.RJButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Controls.Add(this.panelCarrinho);
            this.panelMenu.Controls.Add(this.lblNumero);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnFaleConosco);
            this.panelMenu.Controls.Add(this.btnServiços);
            this.panelMenu.Controls.Add(this.btnProdutos);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1090, 68);
            this.panelMenu.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(896, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 50);
            this.panel3.TabIndex = 6;
            // 
            // panelCarrinho
            // 
            this.panelCarrinho.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCarrinho.BackgroundImage")));
            this.panelCarrinho.Location = new System.Drawing.Point(981, 12);
            this.panelCarrinho.Name = "panelCarrinho";
            this.panelCarrinho.Size = new System.Drawing.Size(47, 46);
            this.panelCarrinho.TabIndex = 5;
            this.panelCarrinho.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Location = new System.Drawing.Point(728, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(117, 14);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "+55 4002-8922";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.panel1.BackgroundImage = global::Doceria.Properties.Resources.icons8_telefone_50__4_;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(681, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 53);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFaleConosco
            // 
            this.btnFaleConosco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnFaleConosco.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnFaleConosco.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFaleConosco.BorderRadius = 11;
            this.btnFaleConosco.BorderSize = 0;
            this.btnFaleConosco.FlatAppearance.BorderSize = 0;
            this.btnFaleConosco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFaleConosco.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaleConosco.ForeColor = System.Drawing.Color.White;
            this.btnFaleConosco.Location = new System.Drawing.Point(273, 28);
            this.btnFaleConosco.Name = "btnFaleConosco";
            this.btnFaleConosco.Size = new System.Drawing.Size(114, 24);
            this.btnFaleConosco.TabIndex = 2;
            this.btnFaleConosco.Text = "Fale Conosco";
            this.btnFaleConosco.TextColor = System.Drawing.Color.White;
            this.btnFaleConosco.UseVisualStyleBackColor = false;
            this.btnFaleConosco.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // btnServiços
            // 
            this.btnServiços.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnServiços.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnServiços.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnServiços.BorderRadius = 11;
            this.btnServiços.BorderSize = 0;
            this.btnServiços.FlatAppearance.BorderSize = 0;
            this.btnServiços.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiços.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiços.ForeColor = System.Drawing.Color.White;
            this.btnServiços.Location = new System.Drawing.Point(189, 29);
            this.btnServiços.Name = "btnServiços";
            this.btnServiços.Size = new System.Drawing.Size(78, 23);
            this.btnServiços.TabIndex = 3;
            this.btnServiços.Text = "Serviços";
            this.btnServiços.TextColor = System.Drawing.Color.White;
            this.btnServiços.UseVisualStyleBackColor = false;
            this.btnServiços.Click += new System.EventHandler(this.btnServiços_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnProdutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(54)))), ((int)(((byte)(0)))));
            this.btnProdutos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProdutos.BorderRadius = 11;
            this.btnProdutos.BorderSize = 0;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.White;
            this.btnProdutos.Location = new System.Drawing.Point(96, 28);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(87, 24);
            this.btnProdutos.TabIndex = 1;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.TextColor = System.Drawing.Color.White;
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Location = new System.Drawing.Point(21, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(47, 46);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(58)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(45, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Semana de Páscoa !!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(45, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 90);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produtos com até \r\n50%OFF\r\n";
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(58)))), ((int)(((byte)(0)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1090, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMenu);
            this.DoubleBuffered = true;
            this.Name = "FormInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private RJCodeAdvance.RJControls.RJButton btnProdutos;
        private RJCodeAdvance.RJControls.RJButton btnServiços;
        private RJCodeAdvance.RJControls.RJButton btnFaleConosco;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Panel panelCarrinho;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

