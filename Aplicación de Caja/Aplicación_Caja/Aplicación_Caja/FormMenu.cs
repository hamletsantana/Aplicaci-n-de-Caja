using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación_Caja
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLoginClientes loginClientes = new FormLoginClientes();
            loginClientes.MdiParent = this.MdiParent;
            loginClientes.StartPosition = FormStartPosition.Manual;
            this.Close();
            loginClientes.Show();
        }

        private void buttonCierre_Click(object sender, EventArgs e)
        {

        }
    }
}
