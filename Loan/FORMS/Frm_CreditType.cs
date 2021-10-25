using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan.FORMS
{
    public partial class Frm_CreditType : Form

    {
        SQLControl SQL = new SQLControl();

        public Frm_CreditType()
        {
            InitializeComponent();
        }
        void headdvg()
        {
            DGV_DATA.Columns[0].HeaderText = "លេខសម្គាល់";
            DGV_DATA.Columns[1].HeaderText = "ប្រភេទ";
            DGV_DATA.Columns[2].HeaderText = "ជាឡាតាំង";
        }
        void placeholder()
        {
            CueBannerTextCode.SetCueText(TXT_ID, "លេខសម្គាល់");
            CueBannerTextCode.SetCueText(TXT_NAMEKH, "ប្រភេទ");
            CueBannerTextCode.SetCueText(TXT_NAMEEN, "អក្សរឡាតាំង");
        }

        
        private void SAVE_Click(object sender, EventArgs e)
        {
            
            SQL.AddParam("@id", TXT_ID.Text);
            SQL.AddParam("@namekh", TXT_NAMEKH.Text);
            SQL.AddParam("@nameen", TXT_NAMEEN.Text);
            SQL.ExecQuery("INSERT INTO type VALUES (@id,@namekh,@nameen);", true);        
            //REPORT & ABORT ON ERRORS
            if(SQL.HasException(true)){} 

            MessageBox.Show("បង្កើតថ្មីបានជោគជ័យ");
            SQL.Retrive("select * from type", DGV_DATA);
        }

        private void Frm_CreditType_Load(object sender, EventArgs e)
        {
            SQL.Retrive("select * from type", DGV_DATA);
            headdvg();
            placeholder();
            
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            SQL.AddParam("@id", TXT_ID.Text);
            SQL.AddParam("@namekh", TXT_NAMEKH.Text);
            SQL.AddParam("@nameen", TXT_NAMEEN.Text);

            SQL.ExecQuery("UPDATE type SET namekh=@namekh,nameen=@nameen WHERE id = @id;", true);

            //REPORT & ABORT ON ERRORS
            if (SQL.HasException(true)) { }

            MessageBox.Show("កែប្រែបានជោគជ័យ");
            SQL.Retrive("select * from type", DGV_DATA);
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SQL.AddParam("@id", TXT_ID.Text);

            SQL.ExecQuery("DELETE FROM type WHERE id = @id;", true);

            //REPORT & ABORT ON ERRORS
            if (SQL.HasException(true)) { }

            MessageBox.Show("លុបបានជោគជ័យ");
            SQL.Retrive("select * from type", DGV_DATA);
        }

        private void DGV_DATA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow row;

                row = DGV_DATA.Rows[e.RowIndex];
                TXT_ID.Text = row.Cells["id"].Value.ToString();
                TXT_NAMEKH.Text = row.Cells["namekh"].Value.ToString();
                TXT_NAMEEN.Text = row.Cells["nameen"].Value.ToString();

            }
        }
    }
}
