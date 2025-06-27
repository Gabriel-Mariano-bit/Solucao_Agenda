namespace Projeto_Agenda.Formularios
{
    partial class frmConsultaPessoa
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
            this.cmbColuna = new System.Windows.Forms.ComboBox();
            this.cmbProcurar = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereçoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Agenda = new Projeto_Agenda.Dados.DataSet_Agenda();
            this.pessoaTableAdapter = new Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.PessoaTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbColuna
            // 
            this.cmbColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColuna.FormattingEnabled = true;
            this.cmbColuna.Items.AddRange(new object[] {
            "Nome",
            "Endereço",
            "Cidade"});
            this.cmbColuna.Location = new System.Drawing.Point(35, 53);
            this.cmbColuna.Name = "cmbColuna";
            this.cmbColuna.Size = new System.Drawing.Size(121, 21);
            this.cmbColuna.TabIndex = 0;
            // 
            // cmbProcurar
            // 
            this.cmbProcurar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProcurar.FormattingEnabled = true;
            this.cmbProcurar.Items.AddRange(new object[] {
            "Todos",
            "Que começa com",
            "Que termina com",
            "Que contém"});
            this.cmbProcurar.Location = new System.Drawing.Point(162, 53);
            this.cmbProcurar.Name = "cmbProcurar";
            this.cmbProcurar.Size = new System.Drawing.Size(121, 21);
            this.cmbProcurar.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(299, 54);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(327, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(701, 51);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.endereçoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pessoaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(753, 330);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // endereçoDataGridViewTextBoxColumn
            // 
            this.endereçoDataGridViewTextBoxColumn.DataPropertyName = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.endereçoDataGridViewTextBoxColumn.Name = "endereçoDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "DataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataMember = "Pessoa";
            this.pessoaBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoaTableAdapter
            // 
            this.pessoaTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coluna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Procurar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "por:";
            // 
            // frmConsultaPessoa
            // 
            this.AcceptButton = this.btnFiltrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.cmbProcurar);
            this.Controls.Add(this.cmbColuna);
            this.Name = "frmConsultaPessoa";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmConsultaPessoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColuna;
        private System.Windows.Forms.ComboBox cmbProcurar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private Dados.DataSet_AgendaTableAdapters.PessoaTableAdapter pessoaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereçoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}