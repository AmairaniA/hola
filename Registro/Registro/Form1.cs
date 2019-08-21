using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string names = User.Text;
            string Pass = Password.Text;
            if(names=="Juancho")
            {
                if(Pass=="123tamarindo")
                {
                    MessageBox.Show("Bienvenido " + names);
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario y clave incorrectos. :0 ");
            }
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
