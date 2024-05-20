using ordemServico.DAL;
using ordemServico.Database;
using ordemServico.Enums;
using ordemServico.Model;

namespace ordemServico;

public partial class Frm_OrdemServicoRegistro : Form
{
	private readonly UsuarioModel _usuario;
	private readonly GsoContext _gsoContext;
	private DAL<OrdemServicoModel> _ordemServicoDal;
	private DAL<ItemOrdemDeServicoModel> _itemOrdemServicoDal;

	public int VeiculoId { get; private set; }
	public int ChamdaId { get; private set; }
	public int IdItemOrdemServico { get; private set; } = 0;
	public int SolicitanteId { get; private set; }
	public int UsuarioId { get; private set; }

	public Frm_OrdemServicoRegistro(int id, UsuarioModel _usuario, Controle controle)
	{
		this._usuario = _usuario;
		_gsoContext = new GsoContext();
		_ordemServicoDal = new DAL<OrdemServicoModel>(_gsoContext);
		_itemOrdemServicoDal = new DAL<ItemOrdemDeServicoModel>(_gsoContext);

		InitializeComponent();
		CarregarTitulo(controle);
		BuscarDados(id);
		BuscarDadosDaOrdemServico(id);
		ConfiguraControle();
	}

	private void ConfiguraControle()
	{
		if (_usuario.Perfil != Perfil.Administrador)
		{
			Ck_Aprovado.Enabled = false;
			Ck_Recusado.Enabled = false;
		}
	}

	private void BuscarDadosDaOrdemServico(int id)
	{
		var itensOrdemServicoRecuperados = _itemOrdemServicoDal.RecuperarPor(null, o => o.OrdemServicoId == id);
		if (itensOrdemServicoRecuperados == null) return;
		PorpularDataGrid(itensOrdemServicoRecuperados);

	}

	private void PorpularDataGrid(IEnumerable<ItemOrdemDeServicoModel> itensOrdemServicoRecuperados)
	{
		dataGridView1.Columns.Clear();
		ConfigurarDataGrid();

		foreach (var item in itensOrdemServicoRecuperados)
		{
			dataGridView1.Rows.Add(item.IdItemOrdemServico, item.ProblemaEncontrado, item.AcaoTomada, item.Observacao, item.OrdemServicoId);
		}
	}

	private void ConfigurarDataGrid()
	{
		dataGridView1.Columns.Add("IdItemOrdemServico", "IdItemOrdemServico");
		dataGridView1.Columns["IdItemOrdemServico"].Visible = false;

		dataGridView1.Columns.Add("ProblemaEncontrado", "Problema Encontrado");
		dataGridView1.Columns["ProblemaEncontrado"].Width = 420;
		dataGridView1.Columns["ProblemaEncontrado"].ReadOnly = true;

		dataGridView1.Columns.Add("AcaoTomada", "Ação Tomada");
		dataGridView1.Columns["AcaoTomada"].Width = 420;
		dataGridView1.Columns["AcaoTomada"].ReadOnly = true;

		dataGridView1.Columns.Add("Observacao", "Observação");
		dataGridView1.Columns["Observacao"].Width = 250;
		dataGridView1.Columns["Observacao"].ReadOnly = true;

		dataGridView1.Columns.Add("OrdemServicoId", "OrdemServicoId");
		dataGridView1.Columns["OrdemServicoId"].Visible = false;
	}

	private void BuscarDados(int id)
	{
		var ordemServicoRecuperado = _ordemServicoDal.RecuperarPor(null, o => o.IdOrdemServico == id);
		if (ordemServicoRecuperado.Count() == 0)
		{
			Lbl_Id.Text = "0";
			Lbl_DataAbertura.Text = DateTime.Now.ToString();
			Lbl_Usuario.Text = _usuario.Nome;
			UsuarioId = _usuario.IdUsuario;
		}
		PopularFormulario(ordemServicoRecuperado);
	}

	private void PopularFormulario(IEnumerable<OrdemServicoModel> ordemServicoRecuperado)
	{
		foreach (var item in ordemServicoRecuperado)
		{
			Lbl_Id.Text = item.IdOrdemServico.ToString();
			Lbl_DataAbertura.Text = item.DataAbertura.ToString();
			Lbl_Placa.Text = item.Veiculo.Placa;
			Lbl_Modelo.Text = item.Veiculo.Modelo;
			VeiculoId = item.VeiculoId;
			Txt_KmHorimetro.Text = item.HorimetroKm;
			Lbl_Chamada.Text = item.Chamada.Chamada;
			ChamdaId = item.ChamadaId;
			Lbl_Usuario.Text = item.Usuario.Nome;
			Lbl_Solicitante.Text = item.Solicitante.Nome;
			SolicitanteId = item.SolicitanteId;
			UsuarioId = item.UsuarioId;
			

			if (item.DataFechamento.ToString() != "01/01/0001 00:00:00") Lbl_DataFechamento.Text = item.DataFechamento.ToString();

			switch (item.Status)
			{
				case Status.Aprovado:
					Ck_Aprovado.Checked = true;
					break;

				case Status.Recusado:
					Ck_Recusado.Checked = true;
					break;

			}
		}
	}

	private void CarregarTitulo(Controle controle)
	{
		switch (controle)
		{
			case Controle.Toadd:
				this.Text += " - Adicionar";
				break;

			case Controle.ToUpdate:
				this.Text += " - Atualizar";
				break;

			case Controle.ToRemove:
				this.Text += " - Deletar";
				break;

			case Controle.ToConsult:
				this.Text += " - Consulta";
				break;
		}
	}

	private void Btn_FecharOrdemServico_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(Lbl_DataFechamento.Text)) Lbl_DataFechamento.Text = DateTime.Now.ToString();
	}

	private void Btn_BuscarVeiculo_Click(object sender, EventArgs e)
	{
		var frm = new Frm_ListaVeiculo();

		if (frm.ShowDialog() == DialogResult.OK)
		{
			VeiculoId = frm.VeiculoId;
			Lbl_Placa.Text = frm.Placa;
			Lbl_Modelo.Text = frm.Modelo;
		}
	}

	private void Btn_BuscarChamada_Click(object sender, EventArgs e)
	{
		var frm = new Frm_ListaChamada();

		if (frm?.ShowDialog() == DialogResult.OK)
		{
			ChamdaId = frm.ChamadaId;
			Lbl_Chamada.Text = frm.Chamada;
		}
	}

	private void Btn_BuscarSolicitante_Click(object sender, EventArgs e)
	{
		var frm = new Frm_ListaSolicitante();

		if (frm.ShowDialog() == DialogResult.OK )
		{
			SolicitanteId = frm.SolicitanteId;
			Lbl_Solicitante.Text = frm.Nome;
		}
	}

	private void Ck_Aprovado_CheckedChanged(object sender, EventArgs e)
	{
		if (Ck_Aprovado.Checked)
		{
			switch (Lbl_DataFechamento.Text)
			{
				case "":
					MessageBox.Show("Tem que realizar o fechamento da OS para poder realizar a aprovação.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Ck_Aprovado.Checked = false;
					Ck_Recusado.Checked = false;
					break;
				default:
					Ck_Recusado.Checked = false;
					break;
			}
		}
	}

	private void Ck_Recusado_CheckedChanged(object sender, EventArgs e)
	{
		if (Ck_Recusado.Checked)
		{
			switch (Lbl_DataFechamento.Text)
			{
				case "":
					MessageBox.Show("Tem que realizar o fechamento da OS para poder Recusar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
					Ck_Aprovado.Checked = false;
					Ck_Recusado.Checked = false;
					break;
				default:
					Ck_Aprovado.Checked = false;
					break;
			}
		}
	}

	private void Btn_Adicionar_Click(object sender, EventArgs e)
	{
		if (string.IsNullOrEmpty(Txt_ProblemaEncontrado.Text))
		{
			MessageBox.Show("A caixa de problema encontrado não pode ficar vazia.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return;
		}

		int idItemOrdemServico = IdItemOrdemServico;
		string problemaEncontrado = Txt_ProblemaEncontrado.Text;
		string acaoTomada = Txt_AcaoTomada.Text;
		string observacao = Txt_Observacao.Text;
		int ordemServicoId = Convert.ToInt32(Lbl_Id.Text);

		dataGridView1.Rows.Add(idItemOrdemServico, problemaEncontrado, acaoTomada, observacao, ordemServicoId);
		LimparCampos();
	}

	private void LimparCampos()
	{
		Txt_ProblemaEncontrado.Text = string.Empty;
		Txt_AcaoTomada.Text = string.Empty;
		Txt_Observacao.Text = string.Empty;
		IdItemOrdemServico = 0;
	}

	private void Btn_Editar_Click(object sender, EventArgs e)
	{
		if (dataGridView1.Rows.Count > 0)
		{
			IdItemOrdemServico = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["IdItemOrdemServico"].Value);
			Txt_ProblemaEncontrado.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ProblemaEncontrado"].Value.ToString();
			Txt_AcaoTomada.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["AcaoTomada"].Value.ToString();
			Txt_Observacao.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["Observacao"].Value.ToString();
			dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
		}
	}

	private void SalvarToolStripButton_Click(object sender, EventArgs e)
	{
		try
		{
			var camposVerificados = VerificarCampos();
			if (camposVerificados == false) return;

			var resultado = SalvarOrdemServico();
			if (resultado == null) return;

			var resultadoItens = SalvarItemsOrdemServico(resultado);
			if (resultadoItens == false) return;

			MessageBox.Show("Processo realizado com sucesso!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Erro: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}

	private OrdemServicoModel SalvarOrdemServico()
	{
		try
		{
			var ordemServico = new OrdemServicoModel();

			ordemServico.IdOrdemServico = Convert.ToInt32(Lbl_Id.Text);
			ordemServico.DataAbertura = Convert.ToDateTime(Lbl_DataAbertura.Text);
			if (Lbl_DataFechamento.Text == string.Empty) ordemServico.DataFechamento = null;
			else ordemServico.DataFechamento = Convert.ToDateTime(Lbl_DataFechamento.Text);
			ordemServico.HorimetroKm = Txt_KmHorimetro.Text;
			ordemServico.ChamadaId = ChamdaId;
			ordemServico.VeiculoId = VeiculoId;
			ordemServico.SolicitanteId = SolicitanteId;
			ordemServico.UsuarioId = UsuarioId;
			ordemServico.Status = Status.EmAberto;

			if (ordemServico.DataFechamento != null) ordemServico.Status = Status.EmAnalise;
			if (Ck_Aprovado.Checked) ordemServico.Status = Status.Aprovado;
			if (Ck_Recusado.Checked) ordemServico.Status = Status.Recusado;

			if (ordemServico.IdOrdemServico == 0)
			{
				return _ordemServicoDal.Adicionar(ordemServico);
			}
			else
			{
				return _ordemServicoDal.Atualizar(ordemServico);
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Erro: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return null;
		}
	}

	private bool SalvarItemsOrdemServico(OrdemServicoModel ordemServico)
	{
		try
		{
			var itemOrdemServico = new ItemOrdemDeServicoModel();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (!row.IsNewRow)
				{
					int idItemOrdemServico = Convert.ToInt32(row.Cells["IdItemOrdemServico"].Value);
					string? problemaEncontrado = row.Cells["ProblemaEncontrado"].Value.ToString();
					string? acaoTomada = row.Cells["AcaoTomada"].Value.ToString();
					string? observacao = row.Cells["Observacao"].Value.ToString();
					int ordemServicoId = ordemServico.IdOrdemServico;

					itemOrdemServico.IdItemOrdemServico = idItemOrdemServico;
					itemOrdemServico.ProblemaEncontrado = problemaEncontrado;
					itemOrdemServico.AcaoTomada = acaoTomada;
					itemOrdemServico.Observacao = observacao;
					itemOrdemServico.OrdemServicoId = ordemServicoId;

					if (itemOrdemServico.IdItemOrdemServico == 0)
					{
						_itemOrdemServicoDal.Adicionar(itemOrdemServico);
					}
					else
					{
						_itemOrdemServicoDal.Atualizar(itemOrdemServico);
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Erro: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		}
	}

	private bool VerificarCampos()
	{
		if (VeiculoId == 0 || SolicitanteId == 0 || ChamdaId == 0 || dataGridView1.Rows.Count <= 0 || string.IsNullOrEmpty(Txt_KmHorimetro.Text))
		{
			MessageBox.Show("Por favor, preencha os campos de veículo, solicitante, chamada e adicione o problema encontrado antes de salvar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return false;
		}
		return true;
	}
}
