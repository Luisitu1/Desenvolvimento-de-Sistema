using System;
using BLL;
using Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace WindowsFormsAppPrincipal
{
    public partial class FormConsultaCliente : Form
    {
        public FormConsultaCliente()
        {
            InitializeComponent();
        }

        private void buttonAdicionarCliente_Click(object sender, EventArgs e)
        {
            using (FormCadastroCliente frm = new FormCadastroCliente())
            {
                frm.ShowDialog();
            }
        }

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBindingSource.DataSource = new ClienteBLL().BuscarPorNome(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonExcluirCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count <= 0)
                {
                    MessageBox.Show("Não existe registro para ser excluído");
                    return;
                }
                new
ClienteBLL().Excluir(((Cliente)clienteBindingSource.Current).Id);
                clienteBindingSource.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConsultaCliente_Load(object sender, EventArgs e)
        {
            comboBoxBuscarPor.SelectedIndex = 3;
        }

        private void buttonAdicionarCliente_Click_1(object sender, EventArgs e)
        {
            using (FormCadastroCliente frm = new FormCadastroCliente())
            {
                frm.ShowDialog();
            }
        }

        private void buttonAlterarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBindingSource.Count == 0)
                {
                    MessageBox.Show("Não existe cliente para ser alterado");
                    return;
                }
                int id = ((Cliente)clienteBindingSource.Current).Id;

                using (FormCadastroCliente frm = new FormCadastroCliente(id))
                {
                    frm.ShowDialog();
                }
                buttonBuscarCliente_Click(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}