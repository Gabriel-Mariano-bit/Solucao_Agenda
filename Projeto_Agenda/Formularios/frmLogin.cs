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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int vErros = 0;

        private bool CaixasOk()
        {
            if (txtNomeUsuario.Text == "")
            {
                errorProvider1.SetError(txtNomeUsuario, "Informar o usuário");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtNomeUsuario, "");
            }

            if (txtSenha.Text == "")
            {
                errorProvider1.SetError(txtSenha, "Informar a Senha");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtSenha, "");
                return true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CaixasOk())
            {
                //Enquanto não temos o Banco de Dados
                if (txtNomeUsuario.Text !="Teste" && txtSenha.Text != "1234")
                {
                    MessageBox.Show("Usuário ou Senha inválidos");
                    vErros++; //é o mesmo que vErros = vErros + 1;
                    if (vErros == 3) 
                    {
                        MessageBox.Show("Número de Tentativas esgotado...");
                        this.Close();
                    }
                }
                else
                {
                    Properties.Settings1.Default.NivelUsuarioLogado = 1;
                    Properties.Settings1.Default.NomeUsuarioLogado = txtNomeUsuario.Text;
                    Menu Menu = new Menu();
                    Menu.Show();
                    this.Close();
                }
            
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
