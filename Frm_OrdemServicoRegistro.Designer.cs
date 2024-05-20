namespace ordemServico
{
	partial class Frm_OrdemServicoRegistro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrdemServicoRegistro));
			label1 = new Label();
			groupBox1 = new GroupBox();
			Btn_FecharOrdemServico = new Button();
			label6 = new Label();
			label3 = new Label();
			Lbl_DataFechamento = new Label();
			Lbl_DataAbertura = new Label();
			Lbl_Id = new Label();
			label2 = new Label();
			groupBox2 = new GroupBox();
			Txt_KmHorimetro = new TextBox();
			Btn_BuscarVeiculo = new Button();
			label12 = new Label();
			label7 = new Label();
			label8 = new Label();
			Lbl_Modelo = new Label();
			Lbl_Placa = new Label();
			label11 = new Label();
			groupBox3 = new GroupBox();
			Ck_Recusado = new CheckBox();
			Ck_Aprovado = new CheckBox();
			label13 = new Label();
			label4 = new Label();
			Lbl_Chamada = new Label();
			Btn_BuscarChamada = new Button();
			Lbl_Usuario = new Label();
			label10 = new Label();
			Lbl_Solicitante = new Label();
			Btn_BuscarSolicitante = new Button();
			label9 = new Label();
			Txt_ProblemaEncontrado = new TextBox();
			label5 = new Label();
			label14 = new Label();
			Txt_AcaoTomada = new TextBox();
			label15 = new Label();
			Txt_Observacao = new TextBox();
			dataGridView1 = new DataGridView();
			Btn_Editar = new Button();
			Btn_Adicionar = new Button();
			toolStrip1 = new ToolStrip();
			SalvarToolStripButton = new ToolStripButton();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.BackColor = Color.MidnightBlue;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(0, 8);
			label1.Name = "label1";
			label1.Size = new Size(302, 25);
			label1.TabIndex = 0;
			label1.Text = "Data";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(Btn_FecharOrdemServico);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(Lbl_DataFechamento);
			groupBox1.Controls.Add(Lbl_DataAbertura);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(28, 72);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(302, 120);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			// 
			// Btn_FecharOrdemServico
			// 
			Btn_FecharOrdemServico.Location = new Point(173, 86);
			Btn_FecharOrdemServico.Name = "Btn_FecharOrdemServico";
			Btn_FecharOrdemServico.Size = new Size(75, 23);
			Btn_FecharOrdemServico.TabIndex = 3;
			Btn_FecharOrdemServico.Text = "Fechar OS";
			Btn_FecharOrdemServico.UseVisualStyleBackColor = true;
			Btn_FecharOrdemServico.Click += Btn_FecharOrdemServico_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(151, 47);
			label6.Name = "label6";
			label6.Size = new Size(97, 13);
			label6.TabIndex = 2;
			label6.Text = "Data Fechamento";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 47);
			label3.Name = "label3";
			label3.Size = new Size(79, 13);
			label3.TabIndex = 2;
			label3.Text = "Data Abertura";
			// 
			// Lbl_DataFechamento
			// 
			Lbl_DataFechamento.BackColor = Color.LightGray;
			Lbl_DataFechamento.Location = new Point(151, 60);
			Lbl_DataFechamento.Name = "Lbl_DataFechamento";
			Lbl_DataFechamento.Size = new Size(139, 23);
			Lbl_DataFechamento.TabIndex = 1;
			Lbl_DataFechamento.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Lbl_DataAbertura
			// 
			Lbl_DataAbertura.BackColor = Color.LightGray;
			Lbl_DataAbertura.Location = new Point(6, 60);
			Lbl_DataAbertura.Name = "Lbl_DataAbertura";
			Lbl_DataAbertura.Size = new Size(139, 23);
			Lbl_DataAbertura.TabIndex = 1;
			Lbl_DataAbertura.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Lbl_Id
			// 
			Lbl_Id.BackColor = Color.LightGray;
			Lbl_Id.Location = new Point(28, 45);
			Lbl_Id.Name = "Lbl_Id";
			Lbl_Id.Size = new Size(99, 23);
			Lbl_Id.TabIndex = 1;
			Lbl_Id.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(28, 32);
			label2.Name = "label2";
			label2.Size = new Size(50, 13);
			label2.TabIndex = 2;
			label2.Text = "Registro";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(Txt_KmHorimetro);
			groupBox2.Controls.Add(Btn_BuscarVeiculo);
			groupBox2.Controls.Add(label12);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(Lbl_Modelo);
			groupBox2.Controls.Add(Lbl_Placa);
			groupBox2.Controls.Add(label11);
			groupBox2.Location = new Point(336, 72);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(612, 120);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			// 
			// Txt_KmHorimetro
			// 
			Txt_KmHorimetro.Location = new Point(479, 60);
			Txt_KmHorimetro.Name = "Txt_KmHorimetro";
			Txt_KmHorimetro.Size = new Size(119, 22);
			Txt_KmHorimetro.TabIndex = 4;
			Txt_KmHorimetro.TextAlign = HorizontalAlignment.Center;
			// 
			// Btn_BuscarVeiculo
			// 
			Btn_BuscarVeiculo.Location = new Point(443, 60);
			Btn_BuscarVeiculo.Name = "Btn_BuscarVeiculo";
			Btn_BuscarVeiculo.Size = new Size(30, 23);
			Btn_BuscarVeiculo.TabIndex = 3;
			Btn_BuscarVeiculo.Text = ". . .";
			Btn_BuscarVeiculo.UseVisualStyleBackColor = true;
			Btn_BuscarVeiculo.Click += Btn_BuscarVeiculo_Click;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(479, 47);
			label12.Name = "label12";
			label12.Size = new Size(85, 13);
			label12.TabIndex = 2;
			label12.Text = "KM / Horimetro";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(105, 47);
			label7.Name = "label7";
			label7.Size = new Size(47, 13);
			label7.TabIndex = 2;
			label7.Text = "Modelo";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 47);
			label8.Name = "label8";
			label8.Size = new Size(33, 13);
			label8.TabIndex = 2;
			label8.Text = "Placa";
			// 
			// Lbl_Modelo
			// 
			Lbl_Modelo.BackColor = Color.LightGray;
			Lbl_Modelo.Location = new Point(105, 60);
			Lbl_Modelo.Name = "Lbl_Modelo";
			Lbl_Modelo.Size = new Size(336, 23);
			Lbl_Modelo.TabIndex = 1;
			Lbl_Modelo.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// Lbl_Placa
			// 
			Lbl_Placa.BackColor = Color.LightGray;
			Lbl_Placa.Location = new Point(6, 60);
			Lbl_Placa.Name = "Lbl_Placa";
			Lbl_Placa.Size = new Size(93, 23);
			Lbl_Placa.TabIndex = 1;
			Lbl_Placa.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label11
			// 
			label11.BackColor = Color.MidnightBlue;
			label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label11.ForeColor = Color.White;
			label11.Location = new Point(0, 8);
			label11.Name = "label11";
			label11.Size = new Size(612, 25);
			label11.TabIndex = 0;
			label11.Text = "Veículo";
			label11.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(Ck_Recusado);
			groupBox3.Controls.Add(Ck_Aprovado);
			groupBox3.Controls.Add(label13);
			groupBox3.Location = new Point(954, 72);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(253, 120);
			groupBox3.TabIndex = 1;
			groupBox3.TabStop = false;
			// 
			// Ck_Recusado
			// 
			Ck_Recusado.AutoSize = true;
			Ck_Recusado.Location = new Point(141, 63);
			Ck_Recusado.Name = "Ck_Recusado";
			Ck_Recusado.Size = new Size(76, 17);
			Ck_Recusado.TabIndex = 1;
			Ck_Recusado.Text = "Recusado";
			Ck_Recusado.UseVisualStyleBackColor = true;
			Ck_Recusado.CheckedChanged += Ck_Recusado_CheckedChanged;
			// 
			// Ck_Aprovado
			// 
			Ck_Aprovado.AutoSize = true;
			Ck_Aprovado.Location = new Point(17, 63);
			Ck_Aprovado.Name = "Ck_Aprovado";
			Ck_Aprovado.Size = new Size(76, 17);
			Ck_Aprovado.TabIndex = 1;
			Ck_Aprovado.Text = "Aprovado";
			Ck_Aprovado.UseVisualStyleBackColor = true;
			Ck_Aprovado.CheckedChanged += Ck_Aprovado_CheckedChanged;
			// 
			// label13
			// 
			label13.BackColor = Color.MidnightBlue;
			label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			label13.ForeColor = Color.White;
			label13.Location = new Point(0, 8);
			label13.Name = "label13";
			label13.Size = new Size(253, 25);
			label13.TabIndex = 0;
			label13.Text = "Aprovações";
			label13.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(28, 207);
			label4.Name = "label4";
			label4.Size = new Size(55, 13);
			label4.TabIndex = 3;
			label4.Text = "Chamada";
			// 
			// Lbl_Chamada
			// 
			Lbl_Chamada.BackColor = Color.LightGray;
			Lbl_Chamada.Location = new Point(28, 220);
			Lbl_Chamada.Name = "Lbl_Chamada";
			Lbl_Chamada.Size = new Size(302, 23);
			Lbl_Chamada.TabIndex = 1;
			Lbl_Chamada.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// Btn_BuscarChamada
			// 
			Btn_BuscarChamada.Location = new Point(334, 220);
			Btn_BuscarChamada.Name = "Btn_BuscarChamada";
			Btn_BuscarChamada.Size = new Size(30, 23);
			Btn_BuscarChamada.TabIndex = 3;
			Btn_BuscarChamada.Text = ". . .";
			Btn_BuscarChamada.UseVisualStyleBackColor = true;
			Btn_BuscarChamada.Click += Btn_BuscarChamada_Click;
			// 
			// Lbl_Usuario
			// 
			Lbl_Usuario.BackColor = Color.LightGray;
			Lbl_Usuario.Location = new Point(383, 220);
			Lbl_Usuario.Name = "Lbl_Usuario";
			Lbl_Usuario.Size = new Size(302, 23);
			Lbl_Usuario.TabIndex = 1;
			Lbl_Usuario.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(383, 207);
			label10.Name = "label10";
			label10.Size = new Size(44, 13);
			label10.TabIndex = 3;
			label10.Text = "Oficina";
			// 
			// Lbl_Solicitante
			// 
			Lbl_Solicitante.BackColor = Color.LightGray;
			Lbl_Solicitante.Location = new Point(701, 220);
			Lbl_Solicitante.Name = "Lbl_Solicitante";
			Lbl_Solicitante.Size = new Size(302, 23);
			Lbl_Solicitante.TabIndex = 1;
			Lbl_Solicitante.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// Btn_BuscarSolicitante
			// 
			Btn_BuscarSolicitante.Location = new Point(1007, 220);
			Btn_BuscarSolicitante.Name = "Btn_BuscarSolicitante";
			Btn_BuscarSolicitante.Size = new Size(30, 23);
			Btn_BuscarSolicitante.TabIndex = 3;
			Btn_BuscarSolicitante.Text = ". . .";
			Btn_BuscarSolicitante.UseVisualStyleBackColor = true;
			Btn_BuscarSolicitante.Click += Btn_BuscarSolicitante_Click;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(701, 207);
			label9.Name = "label9";
			label9.Size = new Size(61, 13);
			label9.TabIndex = 3;
			label9.Text = "Solicitante";
			// 
			// Txt_ProblemaEncontrado
			// 
			Txt_ProblemaEncontrado.Location = new Point(28, 282);
			Txt_ProblemaEncontrado.Multiline = true;
			Txt_ProblemaEncontrado.Name = "Txt_ProblemaEncontrado";
			Txt_ProblemaEncontrado.Size = new Size(302, 85);
			Txt_ProblemaEncontrado.TabIndex = 4;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(28, 266);
			label5.Name = "label5";
			label5.Size = new Size(118, 13);
			label5.TabIndex = 3;
			label5.Text = "Problema encontrado";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new Point(342, 266);
			label14.Name = "label14";
			label14.Size = new Size(74, 13);
			label14.TabIndex = 3;
			label14.Text = "Ação tomada";
			// 
			// Txt_AcaoTomada
			// 
			Txt_AcaoTomada.Location = new Point(342, 282);
			Txt_AcaoTomada.Multiline = true;
			Txt_AcaoTomada.Name = "Txt_AcaoTomada";
			Txt_AcaoTomada.Size = new Size(302, 85);
			Txt_AcaoTomada.TabIndex = 4;
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new Point(650, 266);
			label15.Name = "label15";
			label15.Size = new Size(67, 13);
			label15.TabIndex = 3;
			label15.Text = "Observação";
			// 
			// Txt_Observacao
			// 
			Txt_Observacao.Location = new Point(650, 282);
			Txt_Observacao.Multiline = true;
			Txt_Observacao.Name = "Txt_Observacao";
			Txt_Observacao.Size = new Size(302, 85);
			Txt_Observacao.TabIndex = 4;
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
			dataGridView1.Location = new Point(28, 410);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(1179, 358);
			dataGridView1.TabIndex = 6;
			// 
			// Btn_Editar
			// 
			Btn_Editar.Location = new Point(109, 381);
			Btn_Editar.Name = "Btn_Editar";
			Btn_Editar.Size = new Size(75, 23);
			Btn_Editar.TabIndex = 7;
			Btn_Editar.Text = "Editar";
			Btn_Editar.UseVisualStyleBackColor = true;
			Btn_Editar.Click += Btn_Editar_Click;
			// 
			// Btn_Adicionar
			// 
			Btn_Adicionar.Location = new Point(28, 381);
			Btn_Adicionar.Name = "Btn_Adicionar";
			Btn_Adicionar.Size = new Size(75, 23);
			Btn_Adicionar.TabIndex = 7;
			Btn_Adicionar.Text = "Adicionar";
			Btn_Adicionar.UseVisualStyleBackColor = true;
			Btn_Adicionar.Click += Btn_Adicionar_Click;
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { SalvarToolStripButton });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(1232, 25);
			toolStrip1.TabIndex = 8;
			toolStrip1.Text = "toolStrip1";
			// 
			// SalvarToolStripButton
			// 
			SalvarToolStripButton.Image = (Image)resources.GetObject("SalvarToolStripButton.Image");
			SalvarToolStripButton.ImageTransparentColor = Color.Magenta;
			SalvarToolStripButton.Name = "SalvarToolStripButton";
			SalvarToolStripButton.Size = new Size(58, 22);
			SalvarToolStripButton.Text = "&Salvar";
			SalvarToolStripButton.Click += SalvarToolStripButton_Click;
			// 
			// Frm_OrdemServicoRegistro
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1232, 780);
			Controls.Add(toolStrip1);
			Controls.Add(Btn_Adicionar);
			Controls.Add(Btn_Editar);
			Controls.Add(dataGridView1);
			Controls.Add(Txt_Observacao);
			Controls.Add(Txt_AcaoTomada);
			Controls.Add(Txt_ProblemaEncontrado);
			Controls.Add(label15);
			Controls.Add(label10);
			Controls.Add(label14);
			Controls.Add(label9);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(Btn_BuscarSolicitante);
			Controls.Add(Btn_BuscarChamada);
			Controls.Add(label2);
			Controls.Add(Lbl_Usuario);
			Controls.Add(Lbl_Solicitante);
			Controls.Add(Lbl_Chamada);
			Controls.Add(Lbl_Id);
			Controls.Add(groupBox2);
			Controls.Add(groupBox3);
			Controls.Add(groupBox1);
			Font = new Font("Segoe UI", 8F);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(1248, 819);
			MinimumSize = new Size(1248, 819);
			Name = "Frm_OrdemServicoRegistro";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Ordem de Serviço";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private GroupBox groupBox1;
		private Label Lbl_Id;
		private Label label2;
		private Button Btn_FecharOrdemServico;
		private Label label6;
		private Label label3;
		private Label Lbl_DataFechamento;
		private Label Lbl_DataAbertura;
		private GroupBox groupBox2;
		private Button Btn_BuscarVeiculo;
		private Label label7;
		private Label label8;
		private Label Lbl_Modelo;
		private Label Lbl_Placa;
		private Label label11;
		private TextBox Txt_KmHorimetro;
		private Label label12;
		private GroupBox groupBox3;
		private Label label13;
		private Label label4;
		private Label Lbl_Chamada;
		private Button Btn_BuscarChamada;
		private Label Lbl_Usuario;
		private Label label10;
		private Label Lbl_Solicitante;
		private Button Btn_BuscarSolicitante;
		private Label label9;
		private TextBox Txt_ProblemaEncontrado;
		private Label label5;
		private Label label14;
		private TextBox Txt_AcaoTomada;
		private Label label15;
		private TextBox Txt_Observacao;
		private DataGridView dataGridView1;
		private Button Btn_Editar;
		private Button Btn_Adicionar;
		private ToolStrip toolStrip1;
		private ToolStripButton SalvarToolStripButton;
		private CheckBox Ck_Recusado;
		private CheckBox Ck_Aprovado;
	}
}