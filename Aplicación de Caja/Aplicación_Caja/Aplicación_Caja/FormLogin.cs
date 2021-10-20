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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.MdiParent = this.MdiParent;
            menu.StartPosition = FormStartPosition.Manual;
            this.Close();
            menu.Size = menu.MdiParent.Size;
            menu.Show();

            //if (database.rows == textbox1)
            //        open next form
            //        FormMenu menu = new FormMenu();
            //        menu.Location = this.Location;
            //menu.StartPosition = FormStartPosition.Manual;
            //menu.FormClosing += delegate { this.Show(); };
            //menu.Show();
            //this.Hide();
            //  else
            //      print("valor equivocado")
        }
    }
}
