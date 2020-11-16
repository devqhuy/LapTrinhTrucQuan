using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DeThiHocKi
{
    public partial class frmQuanLiNhanVien : Form
    {
        DataProccess.DataBase data = new DataProccess.DataBase();
        SqlCommand cmd;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-0FU86LQ;Initial Catalog=DuLieu;Integrated Security=True");


        public frmQuanLiNhanVien()
        {
            InitializeComponent();
            
        }
        //ham xu li number
        private bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!IsNumeric(txtLuongBatDau.Text) || !IsNumeric(txtLuongKetThuc.Text))
            {
                MessageBox.Show("Chi duoc nhap so nguyen vao o luong");
            }
            //truong hop khong nhap gi se hien ra tat ca nhan vien
            if (txtLuongBatDau.Text.Trim()=="" && txtLuongKetThuc.Text.Trim() ==""&& cbCongViec.Text.Trim()==""
&& cbGioiTinh.Text.Trim()=="" && cbThangSinh.Text.Trim()=="")
            {
                MessageBox.Show("Ban chua nhap gi nen se hien thi tat ca");
                dtgvNhanVien.DataSource = data.DataReader("select * from NhanVien");
            }

            //ham xu li tim kiem luong
            if (txtLuongBatDau.Text.Trim() != "" && txtLuongKetThuc.Text.Trim() != "")
            {
                dtgvNhanVien.DataSource = data.DataReader("select * from nhanvien where luong>=" + txtLuongBatDau.Text + "and luong<=" + txtLuongKetThuc.Text);
            }

            

            if(txtLuongBatDau.Text.Trim() == "" && txtLuongKetThuc.Text.Trim() !="")
            {
                dtgvNhanVien.DataSource = data.DataReader("select * from nhanvien where luong<=" + txtLuongKetThuc.Text);
            }
            if (txtLuongBatDau.Text.Trim() != "" && txtLuongKetThuc.Text.Trim() == "")
            {
                dtgvNhanVien.DataSource = data.DataReader("select * from nhanvien where luong>=" + txtLuongBatDau.Text);
            }

            
            //ham xu li tim kiem gioi tinh
            
            if(cbGioiTinh.GetItemText(cbGioiTinh.SelectedValue) == "NU")
            { 
                dtgvNhanVien.DataSource = data.DataReader("select * from nhanvien where gioitinh = N'NU'");
                
            }
            if (cbGioiTinh.GetItemText(cbGioiTinh.SelectedValue) == "NAM")
            {
                dtgvNhanVien.DataSource = data.DataReader("select * from nhanvien where gioitinh = N'NAM'");

            }






        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbGioiTinh.SelectedItem.ToString());
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        //add csdl vao muc combobox
        public void LoadComboGioiTinh()
        {
            DataTable dt = new DataTable();
            dt = data.DataReader("select distinct gioitinh from nhanvien");
            try
            {
                cbGioiTinh.DataSource = dt;
                cbGioiTinh.DisplayMember = "gioitinh";
                cbGioiTinh.ValueMember = "gioitinh";
            }
            catch
            {

            }
        }
        
            private void frmQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            
            dtgvNhanVien.DataSource = data.DataReader("select * from NhanVien");
            //xu li chua nhap gi
            LoadComboGioiTinh();
            
            
        }
    }
}
