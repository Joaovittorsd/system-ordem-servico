﻿namespace ordemServico
{
	partial class Frm_ListaSolicitante
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ListaSolicitante));
			dataGridView1 = new DataGridView();
			panel1 = new Panel();
			Txt_Pesquisa = new TextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = Color.WhiteSmoke;
			dataGridView1.BorderStyle = BorderStyle.Fixed3D;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(0, 71);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(800, 379);
			dataGridView1.TabIndex = 5;
			dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(Txt_Pesquisa);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 71);
			panel1.TabIndex = 4;
			// 
			// Txt_Pesquisa
			// 
			Txt_Pesquisa.Location = new Point(20, 27);
			Txt_Pesquisa.Name = "Txt_Pesquisa";
			Txt_Pesquisa.Size = new Size(377, 23);
			Txt_Pesquisa.TabIndex = 1;
			Txt_Pesquisa.TextChanged += Txt_Pesquisa_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(20, 9);
			label1.Name = "label1";
			label1.Size = new Size(62, 15);
			label1.TabIndex = 0;
			label1.Text = "Solicitante";
			// 
			// Frm_ListaSolicitante
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(800, 450);
			Controls.Add(dataGridView1);
			Controls.Add(panel1);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximumSize = new Size(816, 489);
			MinimumSize = new Size(816, 489);
			Name = "Frm_ListaSolicitante";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Solicitante";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private Panel panel1;
		private TextBox Txt_Pesquisa;
		private Label label1;
	}
}