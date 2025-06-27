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
    public partial class frmConsultaPessoa : Form
    {
        public frmConsultaPessoa()
        {
            InitializeComponent();
        }

        private void frmConsultaPessoa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoaTableAdapter.Fill(this.dataSet_Agenda.Pessoa);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vColuna, vProcurar, vTexto, vFiltro;

            vColuna = cmbColuna.Text;
            vProcurar = cmbProcurar.Text;
            vTexto = txtPesquisa.Text;

            vFiltro = vColuna + " ";

            if (vProcurar == "Que começa com") // %' apenas depois
            {
                vFiltro += "like '" + vTexto + "%'";
            }
            else if (vProcurar == "Que contém") // % antes e depois
            {
                vFiltro += "like '%" + vTexto + "%'";
            }
            else if (vProcurar == "Que termina com")// % apenas antes
            {
                vFiltro += "like '%" + vTexto + "'";
            }
            else if (vProcurar == "Igual a") // usa-se o igual sem % nem antes nem depois
            {
                vFiltro += "= '" + vTexto + "'";
            }
            else //Todos
            {
                vFiltro = "";
            }

            pessoaBindingSource.Filter = vFiltro;
        }


    }
}
