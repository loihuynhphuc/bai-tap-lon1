using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THUVIEN;

namespace QL_VTXD
{
    public partial class frm_phieunhap : Form
    {
        public frm_phieunhap()
        {
            InitializeComponent();
        }
        public void load_phieunhap() {
            this.dgv_phieunhap.DataSource = Cls_phieunhap.select();
        }
        public void soPN() {
            txt_soPN.Text = "PN"+Convert.ToInt32(Cls_phieunhap.select().Rows.Count +1);
        }
        public void cbomahang() {
            this.cbo_mahang.DataSource = Cls_phieunhap.select();
            this.cbo_mahang.DisplayMember = "MaHang";
            this.cbo_mahang.ValueMember = "MaHang";
            

        }
        public void cbo_NCC()
        {
            this.cbo_mancc.DataSource = Cls_phieunhap.select();
            this.cbo_mancc.DisplayMember = "MaNCC";
            this.cbo_mancc.ValueMember = "MaNCC";


        }
        public void cbo_KHO()
        {
            this.cbo_makho.DataSource = Cls_phieunhap.select();
            this.cbo_makho.DisplayMember = "MaKho";
            this.cbo_makho.ValueMember = "MaKho";


        }
        public void cbo_NV()
        {
            this.cbo_maNV.DataSource = Cls_phieunhap.select();
            this.cbo_maNV.DisplayMember = "MaNV";
            this.cbo_maNV.ValueMember = "MaNV";


        }
       

        private void frm_phieunhap_Load(object sender, EventArgs e)
        {
            load_phieunhap();
            cbomahang();
            cbo_NCC();
            cbo_KHO();
            cbo_NV();
            //txt_gianhap.Text = cbo_mahang.SelectedValue.ToString();
            soPN();            

        }
        public void insert_dl() {
           
            if (nRUD_Soluongnhap.Value != 0 )
            {
             
                Cls_phieunhap.insert(txt_soPN.Text, cbo_mahang.SelectedValue.ToString(), cbo_mancc.SelectedValue.ToString(), cbo_makho.SelectedValue.ToString(), cbo_maNV.SelectedValue.ToString(), dtp_ngaynhap.Text.ToString(), Convert.ToInt32(txt_gianhap.Text), Convert.ToInt32(nRUD_Soluongnhap.Value), Convert.ToInt32(txt_tientra.Text));
                MessageBox.Show("Dữ liệu đã thêm");
                load_phieunhap();
                soPN();
                txt_gianhap.Text = " ";
                txt_tientra.Text = " ";
                nRUD_Soluongnhap.Value = 0;

            }
            else {
                MessageBox.Show("cần nhập số lượng");
            }
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            insert_dl();
        }

        //private void dgv_phieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
            
        //}

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (txt_tientra.Text.Length != 0)
            {
                Cls_phieunhap.update(txt_soPN.Text, cbo_mahang.SelectedValue.ToString(), cbo_mancc.SelectedValue.ToString(), cbo_makho.SelectedValue.ToString(), cbo_maNV.SelectedValue.ToString(), dtp_ngaynhap.Text.ToString(), Convert.ToInt32(txt_gianhap.Text), Convert.ToInt32(nRUD_Soluongnhap.Value), Convert.ToInt32(txt_tientra.Text));
                MessageBox.Show("Dữ liệu đã được cập nhật");
                load_phieunhap();
            }
            else {
                MessageBox.Show("Cần điền đầy đủ");
            }
          
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa phiếu phập " + txt_soPN.Text + "?", "XÁC NHẬN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Cls_phieunhap.delete(txt_soPN.Text);
                MessageBox.Show("Dữ liệu đã được xóa");
                load_phieunhap();
            }
            else {
                MessageBox.Show("Dữ liệu vẫn chưa được xóa");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_phieunhap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0)
            {
                txt_soPN.Text = dgv_phieunhap.Rows[idx].Cells["MaPN"].Value.ToString();
                txt_gianhap.Text = dgv_phieunhap.Rows[idx].Cells["GiaNhap"].Value.ToString();
                txt_tientra.Text = dgv_phieunhap.Rows[idx].Cells["SoTienDaTra"].Value.ToString();
                nRUD_Soluongnhap.Value = Convert.ToInt32(dgv_phieunhap.Rows[idx].Cells["SoLuongNhap"].Value);
                cbo_mahang.Text = dgv_phieunhap.Rows[idx].Cells["MaHang"].Value.ToString();
                cbo_mancc.Text = dgv_phieunhap.Rows[idx].Cells["MaNCC"].Value.ToString();
                cbo_makho.Text = dgv_phieunhap.Rows[idx].Cells["MaKho"].Value.ToString();
                cbo_maNV.Text = dgv_phieunhap.Rows[idx].Cells["MaNV"].Value.ToString();
                dtp_ngaynhap.Text = dgv_phieunhap.Rows[idx].Cells["NgayNhap"].Value.ToString();
            }
        }
    }
    
}
