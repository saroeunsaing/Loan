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
    public partial class Frm_Employee : Form
    {
        SQLControl SQL = new SQLControl();
        public Frm_Employee()
        {
            InitializeComponent();
        }

        //CueBannerTextCode c = new CueBannerTextCode();
        void headdvg()
        {
            DGV_DATAEMP.Columns[0].HeaderText = "លេខ​";
            DGV_DATAEMP.Columns[1].HeaderText = "ឈ្មោះ";
            DGV_DATAEMP.Columns[2].HeaderText = "អក្សរឡាតាំង";
            DGV_DATAEMP.Columns[3].HeaderText = "ភេទ";
            DGV_DATAEMP.Columns[4].HeaderText = "ថ្ងៃកំណើត";
            DGV_DATAEMP.Columns[5].HeaderText = "លេខទំនាក់ទំនង";
            DGV_DATAEMP.Columns[6].HeaderText = "អ៊ីមែល";
            DGV_DATAEMP.Columns[7].HeaderText = "អាស័យដ្ឋាន";
        }

        void placeholder()
        {
            CueBannerTextCode.SetCueText(TXT_NO, "លេខសម្គាល់");
            CueBannerTextCode.SetCueText(TXT_NAMEKH, "ឈ្មោះ");
            CueBannerTextCode.SetCueText(TXT_NAMEEN, "អក្សរឡាតាំង");
            CueBannerTextCode.SetCueText(TXT_PHONE, "លេខទំនាក់ទំនង");
            CueBannerTextCode.SetCueText(TXT_EMAIL, "អ៊ីមែល");
            CueBannerTextCode.SetCueText(TXT_ADDRESS, "អាស័យដ្ឋាន");
        }

       


        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SAVE_Click(object sender, EventArgs e)
        {
            SQL.AddParam("@no", TXT_NO.Text);
            SQL.AddParam("@namekh", TXT_NAMEKH.Text);
            SQL.AddParam("@nameen", TXT_NAMEEN.Text);
            //SQL.AddParam("@gender", TXT_GENDER.Text);
            ///DateTime dob = new DateTime(yyyy-MM-dd);
            if (RadioMale.Checked)
                SQL.AddParam("@gender", "Male");
            else
                SQL.AddParam("@gender", "Female");
            SQL.AddParam("@dob", dob.Value);
            SQL.AddParam("@phone", TXT_PHONE.Text);
            SQL.AddParam("@email", TXT_EMAIL.Text);
            SQL.AddParam("@address", TXT_ADDRESS.Text);
            SQL.ExecQuery("INSERT INTO Employees VALUES (@no,@namekh,@nameen,@gender,@dob,@phone,@email,@address);", true);

            //REPORT & ABORT ON ERRORS
            if (SQL.HasException(true)) { }

            MessageBox.Show("បង្កើតថ្មីបានជោគជ័យ");
            SQL.Retrive("select * from Employees", DGV_DATAEMP);
        }

       

        private void TXT_NO_TextChanged(object sender, EventArgs e)
        {

        }

        private void EDIT_Click(object sender, EventArgs e)
        {
            SQL.AddParam("@no", TXT_NO.Text);
            SQL.AddParam("@namekh", TXT_NAMEKH.Text);
            SQL.AddParam("@nameen", TXT_NAMEEN.Text);
            if (RadioMale.Checked)
                SQL.AddParam("@gender", "Male");
            else
                SQL.AddParam("@gender", "Female");
            SQL.AddParam("@dob", dob.Value);
            SQL.AddParam("@phone", TXT_PHONE.Text);
            SQL.AddParam("@email", TXT_EMAIL.Text);
            SQL.AddParam("@address", TXT_ADDRESS.Text);
            SQL.ExecQuery("UPDATE Employees SET​​ Namekh=@namekh,Nameen=@nameen,Gender=@gender,Dob=@dob,phone=@phone,email=@email,address=@address WHERE No=@no);", true);
           //SQL.ExecQuery("UPDATE type SET namekh=@namekh,nameen=@nameen WHERE id = @id;", true);

            //REPORT & ABORT ON ERRORS
            if (SQL.HasException(true)) { }

            MessageBox.Show("កែប្រែបានជោគជ័យ");
            SQL.Retrive("select * from Employees", DGV_DATAEMP);
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SQL.AddParam("@no", TXT_NO.Text);
            SQL.ExecQuery("DELETE FROM Employees WHERE no = @no;", true);
            if (SQL.HasException(true)) { }

            MessageBox.Show("លុបបានជោគជ័យ");
            SQL.Retrive("select * from Employees", DGV_DATAEMP);

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            TXT_NO.Text = "";
            TXT_NAMEKH.Text = "";
            TXT_NAMEEN.Text = "";
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            dob.Text = "";
            TXT_PHONE.Text = "";
            TXT_EMAIL.Text = "";
            TXT_ADDRESS.Text = "";

        }

        private void DGV_DATAEMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row;

                row = DGV_DATAEMP.Rows[e.RowIndex];
                TXT_NO.Text = row.Cells["no"].Value.ToString();
                TXT_NAMEKH.Text = row.Cells["namekh"].Value.ToString();
                TXT_NAMEEN.Text = row.Cells["nameen"].Value.ToString();
                if (row.Cells["gender"].Value.ToString() == "Female")
                {
                    RadioFemale.Checked = true;
                }
                else
                {
                    RadioMale.Checked = true;
                }
                //TXT_GENDER.Text = row.Cells["gender"].Value.ToString();
                dob.Text = row.Cells["dob"].Value.ToString();
                TXT_PHONE.Text = row.Cells["phone"].Value.ToString();
                TXT_EMAIL.Text = row.Cells["email"].Value.ToString();
                TXT_ADDRESS.Text = row.Cells["address"].Value.ToString();

            }
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            SQL.Retrive("select * from Employees", DGV_DATAEMP);
            headdvg();
            placeholder();
        }
    }
}
