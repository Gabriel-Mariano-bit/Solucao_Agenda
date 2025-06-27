using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formularios
{
    public partial class frmCadPessoas : Form
    {
        public frmCadPessoas()
        {
            InitializeComponent();
        }

        private void pessoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);

        }

        private void frmCadPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar Exclusão?", "Excluindo Registro...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                pessoaBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);
            }
        }
    }
}
