using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            ShowWelcomeMessage();
        }

        private void btnFrmBook_Click(object sender, EventArgs e)
        {
            Form form = new FrmBook();
            form.Show();
            this.Hide();
        }


        //Método estático 
        public static void ShowWelcomeMessage()
        {
            MessageBox.Show("Welcome!!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFrmComputer_Click(object sender, EventArgs e)
        {
            Form form = new FrmComputer();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
