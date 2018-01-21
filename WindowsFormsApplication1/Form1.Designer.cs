namespace CadCliente
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.GridCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lOJADataSet = new CadCliente.LOJADataSet();
            this.clienteTableAdapter = new CadCliente.ClienteTableAdapter();
            this.bntNovo = new System.Windows.Forms.Button();
            this.btnSairPrincipal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPesquisaCPF = new System.Windows.Forms.TextBox();
            this.lblPesquisaCPF = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCliente
            // 
            this.GridCliente.AllowUserToDeleteRows = false;
            this.GridCliente.AutoGenerateColumns = false;
            this.GridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.GridCliente.DataSource = this.bindingSource1;
            this.GridCliente.Location = new System.Drawing.Point(13, 84);
            this.GridCliente.Name = "GridCliente";
            this.GridCliente.ReadOnly = true;
            this.GridCliente.Size = new System.Drawing.Size(638, 141);
            this.GridCliente.TabIndex = 0;
            this.GridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridCliente_CellContentClick);
            this.GridCliente.Click += new System.EventHandler(this.GridCliente_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CPF";
            this.dataGridViewTextBoxColumn1.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Cliente";
            this.bindingSource1.DataSource = this.lOJADataSet;
            // 
            // lOJADataSet
            // 
            this.lOJADataSet.DataSetName = "LOJADataSet";
            this.lOJADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // bntNovo
            // 
            this.bntNovo.Location = new System.Drawing.Point(13, 231);
            this.bntNovo.Name = "bntNovo";
            this.bntNovo.Size = new System.Drawing.Size(75, 40);
            this.bntNovo.TabIndex = 1;
            this.bntNovo.Text = "Novo";
            this.bntNovo.UseVisualStyleBackColor = true;
            this.bntNovo.Click += new System.EventHandler(this.bntNovo_Click);
            // 
            // btnSairPrincipal
            // 
            this.btnSairPrincipal.Location = new System.Drawing.Point(576, 231);
            this.btnSairPrincipal.Name = "btnSairPrincipal";
            this.btnSairPrincipal.Size = new System.Drawing.Size(75, 40);
            this.btnSairPrincipal.TabIndex = 2;
            this.btnSairPrincipal.Text = "Sair";
            this.btnSairPrincipal.UseVisualStyleBackColor = true;
            this.btnSairPrincipal.Click += new System.EventHandler(this.btnSairPrincipal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes Cadastrados";
            // 
            // txtPesquisaCPF
            // 
            this.txtPesquisaCPF.Location = new System.Drawing.Point(146, 53);
            this.txtPesquisaCPF.Name = "txtPesquisaCPF";
            this.txtPesquisaCPF.Size = new System.Drawing.Size(250, 20);
            this.txtPesquisaCPF.TabIndex = 4;
            this.txtPesquisaCPF.TextChanged += new System.EventHandler(this.txtPesquisaCPF_TextChanged);
            // 
            // lblPesquisaCPF
            // 
            this.lblPesquisaCPF.AutoSize = true;
            this.lblPesquisaCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaCPF.Location = new System.Drawing.Point(9, 49);
            this.lblPesquisaCPF.Name = "lblPesquisaCPF";
            this.lblPesquisaCPF.Size = new System.Drawing.Size(136, 24);
            this.lblPesquisaCPF.TabIndex = 5;
            this.lblPesquisaCPF.Text = "Informe o CPF:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(663, 283);
            this.Controls.Add(this.lblPesquisaCPF);
            this.Controls.Add(this.txtPesquisaCPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSairPrincipal);
            this.Controls.Add(this.bntNovo);
            this.Controls.Add(this.GridCliente);
            this.Name = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GridCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOJADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Label label1;
   
        private System.Windows.Forms.BindingSource clienteBindingSource;
    
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView GridCliente;
        private LOJADataSet lOJADataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button bntNovo;
        private System.Windows.Forms.Button btnSairPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPesquisaCPF;
        private System.Windows.Forms.Label lblPesquisaCPF;
        private System.Windows.Forms.Timer timer1;
    }
}