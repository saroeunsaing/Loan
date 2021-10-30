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
    public partial class Frm_Customer : Form
    {
        SQLControl SQL = new SQLControl();
        public Frm_Customer()
        {
            InitializeComponent();
        }

        private void Frm_Customer_Load(object sender, EventArgs e)
        {
            SQL.Retrive("select * from Customers", DGV_DATACUS);
            headdvg();
            placeholder();
        }
        void headdvg()
        {
            DGV_DATACUS.Columns[0].HeaderText = "លេខ​";
            DGV_DATACUS.Columns[1].HeaderText = "ឈ្មោះ";
            DGV_DATACUS.Columns[2].HeaderText = "អក្សរឡាតាំង";
            DGV_DATACUS.Columns[3].HeaderText = "ភេទ";
            DGV_DATACUS.Columns[4].HeaderText = "ថ្ងៃកំណើត";
            DGV_DATACUS.Columns[5].HeaderText = "លេខអត្តសញ្ញាប័ណ្ឌ";
            DGV_DATACUS.Columns[6].HeaderText = "លេខទំនាក់ទំនង";
            DGV_DATACUS.Columns[7].HeaderText = "អ៊ីមែល";
            DGV_DATACUS.Columns[8].HeaderText = "អាស័យដ្ឋាន";
        }

        void placeholder()
        {
            CueBannerTextCode.SetCueText(TXT_NO, "លេខសម្គាល់");
            CueBannerTextCode.SetCueText(TXT_NAMEKH, "ឈ្មោះ");
            CueBannerTextCode.SetCueText(TXT_NAMEEN, "អក្សរឡាតាំង");
            CueBannerTextCode.SetCueText(TXT_NATION, "លេខអត្តសញ្ញាប័ណ្ឌ");
            CueBannerTextCode.SetCueText(TXT_PHONE, "លេខទំនាក់ទំនង");
            CueBannerTextCode.SetCueText(TXT_EMAIL, "អ៊ីមែល");
            CueBannerTextCode.SetCueText(TXT_ADDRESS, "អាស័យដ្ឋាន");
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
            SQL.AddParam("@nation", TXT_NATION.Text);
            SQL.AddParam("@phone", TXT_PHONE.Text);
            SQL.AddParam("@email", TXT_EMAIL.Text);
            SQL.AddParam("@address", TXT_ADDRESS.Text);
            SQL.ExecQuery("INSERT INTO Customers VALUES (@no,@namekh,@nameen,@gender,@dob,@nation,@phone,@email,@address);", true);

            //REPORT & ABORT ON ERRORS
            if (SQL.HasException(true)) { }

            MessageBox.Show("បង្កើតថ្មីបានជោគជ័យ");
            SQL.Retrive("select * from Customers", DGV_DATACUS);
        }

        private void EDIT_Click(object sender, EventArgs e)
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
            SQL.AddParam("@nation", TXT_NATION.Text);
            SQL.AddParam("@phone", TXT_PHONE.Text);
            SQL.AddParam("@email", TXT_EMAIL.Text);
            SQL.AddParam("@address", TXT_ADDRESS.Text);
            SQL.ExecQuery("UPDATE Customers SET Namekh=@namekh,Nameen=@nameen,Gender=@gender,dob=@dob,Nation=@nation,phone=@phone,email=@email,address=@address WHERE No = @no;", true);

            //REPORT & ABORT ON ERRORS
            if (SQL.HasException(true)) { }

            MessageBox.Show("កែប្រែបានជោគជ័យ");
            SQL.Retrive("select * from Customers", DGV_DATACUS);
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            SQL.AddParam("@no", TXT_NO.Text);
            SQL.ExecQuery("DELETE FROM Customers WHERE No = @no;", true);
            if (SQL.HasException(true)) { }

            MessageBox.Show("លុបបានជោគជ័យ");
            SQL.Retrive("select * from Customers", DGV_DATACUS);
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            TXT_NO.Text = "";
            TXT_NAMEKH.Text = "";
            TXT_NAMEEN.Text = "";
            RadioMale.Checked = false;
            RadioFemale.Checked = false;
            dob.Text = "";
            TXT_NATION.Text = "";
            TXT_PHONE.Text = "";
            TXT_EMAIL.Text = "";
            TXT_ADDRESS.Text = "";
        }

        private void DGV_DATACUS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row;

            row = DGV_DATACUS.Rows[e.RowIndex];
            TXT_NO.Text = row.Cells["no"].Value.ToString();
            TXT_NAMEKH.Text = row.Cells["namekh"].Value.ToString();
            TXT_NAMEEN.Text = row.Cells["nameen"].Value.ToString();
            if (row.Cells["gender"].Value.ToString() == "Male")
            {

                RadioMale.Checked = true;
                RadioFemale.Checked = false;
            }
            else
            {
                RadioFemale.Checked = true;
                RadioMale.Checked = false;

            }
            //TXT_GENDER.Text = row.Cells["gender"].Value.ToString();
            dob.Text = row.Cells["dob"].Value.ToString();
            TXT_NATION.Text = row.Cells["nation"].Value.ToString();
            TXT_PHONE.Text = row.Cells["phone"].Value.ToString();
            TXT_EMAIL.Text = row.Cells["email"].Value.ToString();
            TXT_ADDRESS.Text = row.Cells["address"].Value.ToString();

        }
    }

    }
}
