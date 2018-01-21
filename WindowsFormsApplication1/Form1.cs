using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CadCliente.Negocios;
using CadCliente.Persistencia;

namespace CadCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 400;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOJADataSet1.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lOJADataSet.Cliente);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridCliente_Click(object sender, EventArgs e)
        {
            int linhasSelecionadas =
                GridCliente.Rows.GetRowCount(
                    DataGridViewElementStates.Selected);
            if (linhasSelecionadas >0)
            {
                string codigo = "-1";
                for(int i = 0; i < linhasSelecionadas; i++)
                {
                    codigo = Convert.ToString(GridCliente.SelectedRows[i].Cells[0].Value.ToString());
                }
                ManutencaoCliente janela = new ManutencaoCliente(codigo);
                janela.ShowDialog(this);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lOJADataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.lOJADataSet.Cliente);

        }

        private void btnSairPrincipal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntNovo_Click(object sender, EventArgs e)
        {
            ManutencaoCliente novoCliente =new ManutencaoCliente();
            novoCliente.ShowDialog(this);
        }

        private void GridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.lOJADataSet.Cliente);
            
        }

        private void txtPesquisaCPF_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Consultar();
        }


        private void Consultar()
        {
            string sql = @"SELECT * FROM [Loja].[dbo].[Cliente]  where CPF like '%" + txtPesquisaCPF.Text + "%';";

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConexaoBDLoja"].ConnectionString);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            conn.Close();
            da.Dispose();

            GridCliente.DataSource = dt;

        }
    }
}
