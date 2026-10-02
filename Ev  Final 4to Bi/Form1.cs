using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev__Final_4to_Bi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TextUsuario.Text == "Abraham" && TextContraseña.Text == "42")
            {
                this.Hide();
                Form2 app = new Form2();
                app.Show();


            }
            else
            {
                MessageBox.Show("Sus Datos son Invalidos por favor intente de nuevo");
            }
        }
    }
}
