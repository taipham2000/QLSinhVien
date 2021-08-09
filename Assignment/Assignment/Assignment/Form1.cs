using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        Ultity ut = new Ultity();
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
            Ultity.OpenConnection();
            dgvGirdView.DataSource=Ultity.getDataTable("select mh.MAMH, mh.TENMH, k.DIEM  from ((  Hphan h inner join Kqua k on k.MAHP=h.MAHP)"
                +"inner join Mhoc mh on mh.MAMH = h.MAMH), SVien sv where sv.MASV = k.MASV ");
        }

        public void ShowCombobox()
        {
            conn = ut.OpenDB();
            conn.Open();
            cmd = new SqlCommand("Select * from SVIEN",conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            cbbSV.DataSource = table;
            cbbSV.DisplayMember = "MASV";
            cbbSV.ValueMember = "MASV";
        }
        public void ShowData(string sql)
        {
            Ultity.OpenConnection();
            dgvGirdView.DataSource = Ultity.getDataTable(sql);
        }
        private void dgvGirdView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void cbbSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = cbbSV.Text;
            conn = ut.OpenDB();
            conn.Open();
            cmd = new SqlCommand("select * from SVien where Masv='" + a + "'", conn);
            
            string sql= "select mh.MAMH, mh.TENMH, k.DIEM  from ((  Hphan h inner join Kqua k on k.MAHP=h.MAHP)"
            +"inner join Mhoc mh on mh.MAMH = h.MAMH), SVien sv where sv.MASV = k.MASV and sv.MASV = '"+ a +"'";

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                TenSV.Text = reader.GetString(0).ToString();
                NgaySinh.Text = reader.GetString(2).ToString();
                Sex.Text = reader.GetString(3).ToString();
                MaKhoa.Text = reader.GetString(5).ToString();
            }
            this.ShowData(sql);        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowCombobox();
            Ultity.OpenConnection();
            dgvGirdView.DataSource = Ultity.getDataTable("select mh.MAMH, mh.TENMH, k.DIEM  from ((  Hphan h inner join Kqua k on k.MAHP=h.MAHP)"
                + "inner join Mhoc mh on mh.MAMH = h.MAMH), SVien sv where sv.MASV = k.MASV ");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
