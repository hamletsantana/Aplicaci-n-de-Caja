using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                textBox1.Left = (this.ClientSize.Width - textBox1.Width) / 2;
                textBox1.Top = (this.ClientSize.Height - textBox1.Height) / 2;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ConfigurationManager.AppSettings["Local"];
        }
    }
}
