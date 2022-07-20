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
    public partial class frm_Hoadon : Form
    {
        public frm_Hoadon()
        {
            InitializeComponent();
        }
        public void Load_HD() {
            this.dgv_hoadon.DataSource = Cls_HD.select_HD();
        }
        public void soHD() {
            txt_soHD.Text = "HD" + Convert.ToInt32(Cls_HD.select_HD().Rows.Count + 1);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void cbo_KHO()
        {
            this.cbkho.DataSource = Cls_HD.select_HD();
            this.cbkho.DisplayMember = "MaKho";
            this.cbkho.ValueMember = "MaKho";


        }
        public void cbo_NV()
        {
            this.cbnv.DataSource = Cls_HD.select_HD();
            this.cbnv.DisplayMember = "MaNV";
            this.cbnv.ValueMember = "MaNV";


        }
        public void cbomahang()
        {
            this.cbo_nahang.DataSource = Cls_HD.select_HD();
            this.cbo_nahang.DisplayMember = "MaHang";
            this.cbo_nahang.ValueMember = "MaHang";


        }
        public void cbo_CHang()
        {
            this.cbo_CH.DataSource = Cls_HD.select_HD();
            this.cbo_CH.DisplayMember = "MaCH";
            this.cbo_CH.ValueMember = "MaCH";


        }
        public void cbokh()
        {
            this.cbo_mkh.DataSource = Cls_khachhang.select();
            this.cbo_mkh.DisplayMember = "MaKH";
            this.cbo_mkh.ValueMember = "MaKH";


        }
        public void cbotenkh()
        {
            this.cbo_tenkh.DataSource = Cls_khachhang.select();
            this.cbo_tenkh.DisplayMember = "TenKH";
            this.cbo_tenkh.ValueMember = "TenKH";


        }
        public void cbodckh()
        {
            this.cbo_dc.DataSource = Cls_khachhang.select();
            this.cbo_dc.DisplayMember = "DiaChi";
            this.cbo_dc.ValueMember = "DiaChi";


        }
        public void buoc_dongia() {
            this.cbo_donggia.DataSource = Cls_hang.select();
            this.cbo_donggia.DisplayMember = "DonGia";
            this.cbo_donggia.ValueMember = "DonGia";
        }
       
         public void thanh_tien() {
             txt_thanhtien.Text = Convert.ToString(Convert.ToInt32(nRU_slx.Value) *Convert.ToInt32(cbo_donggia.SelectedValue) );
        }

        private void frm_Hoadon_Load(object sender, EventArgs e)
        {
            Load_HD();
            soHD();
            cbo_CHang();
            cbomahang();
            cbo_NV();
            cbo_KHO();
            cbokh();
            cbotenkh();
            cbodckh();
            buoc_dongia();
            cbo_donggia.SelectedIndex = -1;
           
        }
        public void them_HD() {
            //kt();
            if (nRU_slx.Value == 0)
            {
                MessageBox.Show("Hãy nhập số lượng xuất");
            }
            else {
                if (cbo_donggia.SelectedIndex ==-1)
                {

                    MessageBox.Show("Hãy nhập đơn giá");
                 
                }
                else {   thanh_tien();
                    Cls_HD.insert(txt_soHD.Text, cbo_nahang.SelectedValue.ToString(), cbo_CH.SelectedValue.ToString(), cbkho.SelectedValue.ToString(), cbnv.SelectedValue.ToString(), dtnx.Text.ToString(), Convert.ToInt32(nRU_slx.Value), Convert.ToInt32(txt_thanhtien.Text), cbo_mkh.SelectedValue.ToString(), cbo_tenkh.SelectedValue.ToString(), cbo_dc.SelectedValue.ToString());
                    MessageBox.Show("Đã thêm hóa đơn");
                    Load_HD();
                }
             
            }
              
        }
        

        private void btntaomoi_Click(object sender, EventArgs e)
        {
            them_HD();
            
        }

        private void btn_taomoi_Click(object sender, EventArgs e)
        {
            soHD();
            cbo_donggia.SelectedIndex = -1;
            txt_thanhtien.Text = " ";
            nRU_slx.Value = 0;
        }
        //public void kt() {
           
        //    int i;
        //    for ( i = 0; i < dgv_hoadon.RowCount; i++) {
        //     int sl= Convert.ToInt32(dgv_hoadon.Rows[i].Cells[6].Value);
               
                    
        //    }
        //    if (nRU_slx.Value > sl)
        //    {
        //        MessageBox.Show("Không đủ hàng để cung cấp");

        //    }          
            
        //}

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            frm_themkh f_themkh = new frm_themkh();
            f_themkh.Show();
        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
