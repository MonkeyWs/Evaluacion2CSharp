
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RadioTaxisForm
{
    public partial class FormLogin : MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            txtRut.Text = "";
            txtPass.Text = "";
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
