namespace ordemServico
{
	partial class Frm_Menu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
			menuStrip1 = new MenuStrip();
			ordemDeServicoToolStripMenuItem = new ToolStripMenuItem();
			cadastroToolStripMenuItem = new ToolStripMenuItem();
			veículosToolStripMenuItem = new ToolStripMenuItem();
			solicitanteToolStripMenuItem = new ToolStripMenuItem();
			chamadaToolStripMenuItem = new ToolStripMenuItem();
			panel1 = new Panel();
			Lbl_UsuarioLogado = new Label();
			pictureBox1 = new PictureBox();
			menuStrip1.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { ordemDeServicoToolStripMenuItem, cadastroToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(949, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// ordemDeServicoToolStripMenuItem
			// 
			ordemDeServicoToolStripMenuItem.Name = "ordemDeServicoToolStripMenuItem";
			ordemDeServicoToolStripMenuItem.Size = new Size(113, 20);
			ordemDeServicoToolStripMenuItem.Text = "Ordem de Servico";
			ordemDeServicoToolStripMenuItem.Click += ordemDeServicoToolStripMenuItem_Click;
			// 
			// cadastroToolStripMenuItem
			// 
			cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { veículosToolStripMenuItem, solicitanteToolStripMenuItem, chamadaToolStripMenuItem });
			cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			cadastroToolStripMenuItem.Size = new Size(66, 20);
			cadastroToolStripMenuItem.Text = "Cadastro";
			// 
			// veículosToolStripMenuItem
			// 
			veículosToolStripMenuItem.Name = "veículosToolStripMenuItem";
			veículosToolStripMenuItem.Size = new Size(129, 22);
			veículosToolStripMenuItem.Text = "Veículos";
			// 
			// solicitanteToolStripMenuItem
			// 
			solicitanteToolStripMenuItem.Name = "solicitanteToolStripMenuItem";
			solicitanteToolStripMenuItem.Size = new Size(129, 22);
			solicitanteToolStripMenuItem.Text = "Solicitante";
			// 
			// chamadaToolStripMenuItem
			// 
			chamadaToolStripMenuItem.Name = "chamadaToolStripMenuItem";
			chamadaToolStripMenuItem.Size = new Size(129, 22);
			chamadaToolStripMenuItem.Text = "Chamada";
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightGray;
			panel1.Controls.Add(Lbl_UsuarioLogado);
			panel1.Controls.Add(pictureBox1);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 573);
			panel1.Name = "panel1";
			panel1.Size = new Size(949, 34);
			panel1.TabIndex = 1;
			// 
			// Lbl_UsuarioLogado
			// 
			Lbl_UsuarioLogado.AutoSize = true;
			Lbl_UsuarioLogado.Location = new Point(42, 8);
			Lbl_UsuarioLogado.Name = "Lbl_UsuarioLogado";
			Lbl_UsuarioLogado.Size = new Size(22, 15);
			Lbl_UsuarioLogado.TabIndex = 3;
			Lbl_UsuarioLogado.Text = ". . .";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(12, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(24, 24);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// Frm_Menu
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(949, 607);
			Controls.Add(panel1);
			Controls.Add(menuStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			Name = "Frm_Menu";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Menu";
			WindowState = FormWindowState.Maximized;
			FormClosing += Frm_Menu_FormClosing;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem ordemDeServicoToolStripMenuItem;
		private ToolStripMenuItem cadastroToolStripMenuItem;
		private ToolStripMenuItem veículosToolStripMenuItem;
		private ToolStripMenuItem solicitanteToolStripMenuItem;
		private ToolStripMenuItem chamadaToolStripMenuItem;
		private Panel panel1;
		private PictureBox pictureBox1;
		private Label Lbl_UsuarioLogado;
	}
}
