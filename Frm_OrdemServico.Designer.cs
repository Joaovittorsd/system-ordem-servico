namespace ordemServico
{
	partial class Frm_OrdemServico
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrdemServico));
			toolStrip1 = new ToolStrip();
			NovaOrdemServicoToolStripButton = new ToolStripButton();
			abrirToolStripButton = new ToolStripButton();
			groupBox1 = new GroupBox();
			dataGridView1 = new DataGridView();
			Lbl_Id = new Label();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { NovaOrdemServicoToolStripButton, abrirToolStripButton });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1277, 25);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// NovaOrdemServicoToolStripButton
			// 
			NovaOrdemServicoToolStripButton.Image = (Image)resources.GetObject("NovaOrdemServicoToolStripButton.Image");
			NovaOrdemServicoToolStripButton.ImageTransparentColor = Color.Magenta;
			NovaOrdemServicoToolStripButton.Name = "NovaOrdemServicoToolStripButton";
			NovaOrdemServicoToolStripButton.Size = new Size(78, 22);
			NovaOrdemServicoToolStripButton.Text = "&Adicionar";
			NovaOrdemServicoToolStripButton.Click += NovaOrdemServicoToolStripButton_Click;
			// 
			// abrirToolStripButton
			// 
			abrirToolStripButton.Image = (Image)resources.GetObject("abrirToolStripButton.Image");
			abrirToolStripButton.ImageTransparentColor = Color.Magenta;
			abrirToolStripButton.Name = "abrirToolStripButton";
			abrirToolStripButton.Size = new Size(57, 22);
			abrirToolStripButton.Text = "&Editar";
			abrirToolStripButton.Click += abrirToolStripButton_Click;
			// 
			// groupBox1
			// 
			groupBox1.Location = new Point(12, 28);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1237, 93);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Filtro";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AllowUserToOrderColumns = true;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.BackgroundColor = Color.WhiteSmoke;
			dataGridView1.BorderStyle = BorderStyle.Fixed3D;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 157);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(1237, 555);
			dataGridView1.TabIndex = 2;
			dataGridView1.CellFormatting += dataGridView1_CellFormatting;
			// 
			// Lbl_Id
			// 
			Lbl_Id.BackColor = Color.Green;
			Lbl_Id.Location = new Point(97, 133);
			Lbl_Id.Name = "Lbl_Id";
			Lbl_Id.Size = new Size(10, 10);
			Lbl_Id.TabIndex = 3;
			Lbl_Id.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(108, 130);
			label1.Name = "label1";
			label1.Size = new Size(59, 15);
			label1.TabIndex = 4;
			label1.Text = "Aprovado";
			// 
			// label2
			// 
			label2.BackColor = Color.Tomato;
			label2.Location = new Point(175, 133);
			label2.Name = "label2";
			label2.Size = new Size(10, 10);
			label2.TabIndex = 3;
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(186, 130);
			label3.Name = "label3";
			label3.Size = new Size(58, 15);
			label3.TabIndex = 4;
			label3.Text = "Recusado";
			// 
			// label4
			// 
			label4.BackColor = Color.Orange;
			label4.Location = new Point(17, 133);
			label4.Name = "label4";
			label4.Size = new Size(10, 10);
			label4.TabIndex = 3;
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(28, 130);
			label5.Name = "label5";
			label5.Size = new Size(65, 15);
			label5.TabIndex = 4;
			label5.Text = "Em Análise";
			// 
			// Frm_OrdemServico
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1277, 724);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label1);
			Controls.Add(Lbl_Id);
			Controls.Add(dataGridView1);
			Controls.Add(groupBox1);
			Controls.Add(toolStrip1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(1293, 763);
			MinimumSize = new Size(1293, 763);
			Name = "Frm_OrdemServico";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Ordem de Serviço";
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private ToolStripButton NovaOrdemServicoToolStripButton;
		private ToolStripButton abrirToolStripButton;
		private GroupBox groupBox1;
		private DataGridView dataGridView1;
		private Label Lbl_Id;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
	}
}