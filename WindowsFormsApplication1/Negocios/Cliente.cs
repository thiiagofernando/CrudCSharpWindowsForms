namespace CadCliente.Negocios
{
    class Cliente
    {
        private string cpf;
        private string nome;
        private string telefone;

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

    }
}
