using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Top
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
             sidebarPanel.Visible = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (sidebarPanel.Visible)
            {
                sidebarPanel.Visible = false;
                btnMenu.Text = "Menu";
            }
            else
            {
                sidebarPanel.Visible = true;
                btnMenu.Text = "Fechar Menu";
            }
        }

        private void btnCalcSimples_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
