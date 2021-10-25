using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan.FORMS
{
    public partial class Frm_Dashboard : Form
    {
        public Frm_Dashboard()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.Panel_Content.Controls.Count > 0)
                this.Panel_Content.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_Content.Controls.Add(fh);
            this.Panel_Content.Tag = fh;
            fh.Show();
        }
        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            if (Panel_Menu.Width == 200)
            {
                Btn_Menuhide.Enabled = true;
            }
            else if (Panel_Menu.Width == 20)
            {
                Btn_Menushow.Enabled = true;
            }
        }



        private void Panel_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Menushow_Click(object sender, EventArgs e)
        {
            if (Panel_Menu.Width >= 200)
            {
                this.Btn_Menushow.Visible = false;
                this.Btn_Menuhide.Visible = true;
            }
            else
            {
                this.Panel_Menu.Width = Panel_Menu.Width + 60;
            }
        }

        private void Btn_Menuhide_Click(object sender, EventArgs e)
        {
            if (Panel_Menu.Width <= 120)
            {
                this.Btn_Menuhide.Visible = false;
                this.Btn_Menushow.Visible = true;
            }
            else
            {
                this.Panel_Menu.Width = Panel_Menu.Width - 50;
            }
        }

        private void EMPLOYEE_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_Employee());
        }

        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_Customer());
        }

        private void LOAN_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Frm_CreditType());
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            MeExit();
        }
        private void MeExit()
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Are You Want Close Application?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Btn_Restore_Click(object sender, EventArgs e)
        {
            Btn_Restore.Visible = false;
            Btn_Maximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void BTN_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Maximize_Click(object sender, EventArgs e)
        {
            Btn_Restore.Visible = true;
            Btn_Maximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
