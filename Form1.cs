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
            //chua nhap gi trong 2 o lương
            if (txtLuongBatDau.Text.Trim() == "" && txtLuongKetThuc.Text.Trim() == "" && cbCongViec.GetItemText(cbCongViec.SelectedValue) == ""
                && cbGioiTinh.GetItemText(cbCongViec.SelectedValue) == "" && cbThangSinh.GetItemText(cbCongViec.SelectedValue) == "")
            {
                MessageBox.Show("Ban chua nhap gi nen se hien thi tat ca");
                dtgvNhanVien.DataSource = data.DataReader("select * from NhanVien");
            }
            //nhập rồi
            else
            {
                //chỉ nhập ô lương đầu
                if(txtLuongBatDau.Text.Trim() != "" && txtLuongKetThuc.Text.Trim() == "" )
                {
                    MessageBox.Show("chưa nhập lương kết thúc nhá con vợ");
                    string sql1 = "select * from nhanvien where luong >= " + txtLuongBatDau.Text + " and gioitinh = '"
                       + cbGioiTinh.GetItemText(cbGioiTinh.SelectedItem) +"'" +" and congviec = '"+cbCongViec.GetItemText(cbCongViec.SelectedItem)+"'"
                       +" and month(ngaysinh) = "+ cbThangSinh.GetItemText(cbThangSinh.SelectedItem);

                    //dtgvNhanVien.DataSource = data.DataReader("select * from nhanvien where congviec='"+cbCongViec.GetItemText(cbCongViec.SelectedItem)+"'");
                    dtgvNhanVien.DataSource = data.DataReader(sql1);

                }    

                //chỉ nhập ô kết thúc
                if(txtLuongBatDau.Text.Trim() == "" && txtLuongKetThuc.Text.Trim() != "")
                {
                    MessageBox.Show("chưa nhập lương bắt đầu nhá con vợ");
                    string sql1 = "select * from nhanvien where luong <= " + txtLuongKetThuc.Text + " and gioitinh = '"
                       + cbGioiTinh.GetItemText(cbGioiTinh.SelectedItem) + "'" + " and congviec = '" + cbCongViec.GetItemText(cbCongViec.SelectedItem) + "'"
                       + " and month(ngaysinh) = " + cbThangSinh.GetItemText(cbThangSinh.SelectedItem);

                    //dtgvNhanVien.DataSource = data.DataReader("select * from nhanvien where congviec='"+cbCongViec.GetItemText(cbCongViec.SelectedItem)+"'");
                    dtgvNhanVien.DataSource = data.DataReader(sql1);
                }
                //nhập cả 2 ô
                if (txtLuongBatDau.Text.Trim() != "" && txtLuongKetThuc.Text.Trim() != "")
                {
                    MessageBox.Show("ok đầy đủ thông tin");
                    string sql1 = "select * from nhanvien where luong >= " + txtLuongBatDau.Text +" and luong <="+txtLuongKetThuc.Text +" and gioitinh = '"
                       + cbGioiTinh.GetItemText(cbGioiTinh.SelectedItem) + "'" + " and congviec = '" + cbCongViec.GetItemText(cbCongViec.SelectedItem) + "'"
                       + " and month(ngaysinh) = " + cbThangSinh.GetItemText(cbThangSinh.SelectedItem);

                    //dtgvNhanVien.DataSource = data.DataReader("select * from nhanvien where congviec='"+cbCongViec.GetItemText(cbCongViec.SelectedItem)+"'");
                    dtgvNhanVien.DataSource = data.DataReader(sql1);
                }

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
        
        public void LoadComboCongViec()
        {
            DataTable dt = new DataTable();
            dt = data.DataReader("select distinct congviec from nhanvien");
            try {
                cbCongViec.DataSource = dt;
                cbCongViec.DisplayMember = "congviec";
                cbCongViec.ValueMember = "congviec";
            }
            catch { }
        }
        public void LoadNgaySinh()
        {
            DataTable dt = new DataTable();
            dt = data.DataReader("select distinct month(ngaysinh) as thangsinh from nhanvien");
            try
            {
                cbThangSinh.DataSource = dt;
                cbThangSinh.DisplayMember = "thangsinh";
                cbThangSinh.ValueMember = "thangsinh";
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
            LoadComboCongViec();
            LoadNgaySinh();
            
            
        }

        private void dtgvNhanVien_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("ok");
        }
    }
}
