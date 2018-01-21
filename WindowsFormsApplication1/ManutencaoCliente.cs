using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using CadCliente.Negocios;
using CadCliente.Persistencia;

namespace CadCliente
{
    public partial class ManutencaoCliente : Form
    {
        private string codigo;
        private string operacao;
        
        public ManutencaoCliente()
        {
            InitializeComponent();
            operacao = "i";
            btnExcluir.Hide();
        }

        public ManutencaoCliente(string codigo)
        {
            InitializeComponent();
            this.codigo = codigo;
            operacao = "a";
            
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManutencaoCliente_Load(object sender, EventArgs e)
        {
            try
            {
                var cod = Convert.ToString(codigo);
                if (operacao == "a")
                {
                    Cliente cliente = ClienteDados.Pesquisar(cod);
                    txtCPF.Text = codigo.ToString();
                    txtNome.Text = cliente.Nome;
                    txtTelefone.Text = cliente.Telefone.ToString();
                   

                }
                
            }

            catch (Exception exception)
            {
                MessageBox.Show("Erro"+exception.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                Cliente cliente = new Cliente();
                cliente.CPF = txtCPF.Text;
                cliente.Nome = txtNome.Text;
                cliente.Telefone = txtTelefone.Text;
                if (operacao == "i")
                {
                    ClienteDados.Incluir(cliente);
                    MessageBox.Show("Dados Inseridos com Sucesso!!");
                }
                else
                {
                    ClienteDados.Alterar(cliente, codigo);
                    MessageBox.Show("Dados Alterados com Sucesso!!");
                }
                
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Provavelmente já existe um clinte com esse CPF");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro"+ exception.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que "+
                "deseja excluir este cliente?","Atenção",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                ClienteDados.Excluir(
                    Convert.ToString(txtCPF.Text));
                this.Close();
            }
        }
    }
}
