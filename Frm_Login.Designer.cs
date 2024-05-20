namespace ordemServico
{
	partial class Frm_Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
			pictureBox1 = new PictureBox();
			label1 = new Label();
			Txt_Username = new TextBox();
			label2 = new Label();
			Txt_Password = new TextBox();
			Btn_Entrar = new Button();
			Btn_Cancelar = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(34, 26);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(189, 67);
			pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(37, 157);
			label1.Name = "label1";
			label1.Size = new Size(47, 15);
			label1.TabIndex = 0;
			label1.Text = "Usuário";
			// 
			// Txt_Username
			// 
			Txt_Username.Location = new Point(37, 175);
			Txt_Username.Name = "Txt_Username";
			Txt_Username.Size = new Size(179, 23);
			Txt_Username.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(37, 230);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 2;
			label2.Text = "Senha";
			// 
			// Txt_Password
			// 
			Txt_Password.Location = new Point(37, 248);
			Txt_Password.Name = "Txt_Password";
			Txt_Password.PasswordChar = '*';
			Txt_Password.Size = new Size(179, 23);
			Txt_Password.TabIndex = 3;
			// 
			// Btn_Entrar
			// 
			Btn_Entrar.Location = new Point(37, 334);
			Btn_Entrar.Name = "Btn_Entrar";
			Btn_Entrar.Size = new Size(57, 23);
			Btn_Entrar.TabIndex = 4;
			Btn_Entrar.Text = "Entrar";
			Btn_Entrar.UseVisualStyleBackColor = true;
			Btn_Entrar.Click += Btn_Entrar_Click;
			// 
			// Btn_Cancelar
			// 
			Btn_Cancelar.Location = new Point(159, 334);
			Btn_Cancelar.Name = "Btn_Cancelar";
			Btn_Cancelar.Size = new Size(57, 23);
			Btn_Cancelar.TabIndex = 5;
			Btn_Cancelar.Text = "Cancelar";
			Btn_Cancelar.UseVisualStyleBackColor = true;
			Btn_Cancelar.Click += Btn_Cancelar_Click;
			// 
			// Frm_Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(256, 423);
			Controls.Add(Btn_Cancelar);
			Controls.Add(Btn_Entrar);
			Controls.Add(Txt_Password);
			Controls.Add(label2);
			Controls.Add(Txt_Username);
			Controls.Add(label1);
			Controls.Add(pictureBox1);
			Font = new Font("Segoe UI", 9F);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Frm_Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Login";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label1;
		private TextBox Txt_Username;
		private Label label2;
		private TextBox Txt_Password;
		private Button Btn_Entrar;
		private Button Btn_Cancelar;
	}
}