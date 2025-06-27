using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Agenda.Formularios;

namespace Projeto_Agenda
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
       

        private void pessoasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCadPessoas objCadPessoas = new frmCadPessoas();
            objCadPessoas.MdiParent = this;
            objCadPessoas.Show();
        }

        private void pessoasFiltroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaPessoa objConPessoas = new frmConsultaPessoa();
            objConPessoas.MdiParent = this;
            objConPessoas.Show();
        }

        private void relatórioPessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVizualizaFormPessoas objVizFormPessoa = new frmVizualizaFormPessoas();
            objVizFormPessoa.MdiParent = this;
            objVizFormPessoa.Show();
        }
    }
}
