using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLKS
{
    public partial class Dichvu : Form
    {
        public DICHVU_BLL db = new DICHVU_BLL();
        
        public string UserCurrentDV { get; set; }
        public Dichvu()
        {
            InitializeComponent();
        }
        private void Dichvu_Load(object sender, EventArgs e)
        {
            loadDV();
            loadCombox();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu dịch vụ vào datagrid view
        public void loadDV()
        {
            List<DICHVU> listDV = new List<DICHVU>();
            listDV = db.GetAllDichVu();
            Data_DichVu.DataSource = listDV.Select(p => new { p.ID, p.TENDICHVU, p.GIA, p.MOTA}).ToList();

            Data_DichVu.Columns[0].HeaderText = "Mã dịch vụ";
            Data_DichVu.Columns[1].HeaderText = "Tên dịch vụ";
            Data_DichVu.Columns[2].HeaderText = "Giá dịch vụ";
            Data_DichVu.Columns[3].HeaderText = "Mô tả";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Hiển thị dữ liệu từ data vào textbox
        private void Data_DichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_DichVu.Rows[e.RowIndex];
                Textbox_TenDichVu.Text = row.Cells[1].Value.ToString();
                Textbox_GiaDichVu.Text = row.Cells[2].Value.ToString();
                Textbox_MoTa.Text = row.Cells[3].Value.ToString();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Thêm dữ liệu vào combobox tình trạng
        public void loadCombox()
        {
            List<string> listTinhTrang = new List<string>();
            listTinhTrang.Add("Khả dụng");
            listTinhTrang.Add("Không khả dụng");
            Combox_TinhTrang.DataSource = listTinhTrang;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm dịch vụ
        private void TextBox_Find_TenDichVu_TextChanged(object sender, EventArgs e)
        {
            if(TextBox_Find_TenDichVu.Text.Trim() != "")
            {
                List<DICHVU> listDV = new List<DICHVU>();
                string find = TextBox_Find_TenDichVu.Text;
                listDV = db.GetFindDichVu(find);
                Data_DichVu.DataSource = listDV.Select(p => new { p.ID, p.TENDICHVU, p.GIA, p.MOTA }).ToList();
            }
            else
            {
                loadDV();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        public void LockControl()
        {
            Textbox_GiaDichVu.Enabled = false;
            Textbox_TenDichVu.Enabled = false;
        }
       
        public void ConnectionControl(DataTable dt)
        {
            Textbox_TenDichVu.DataBindings.Clear();
            Textbox_GiaDichVu.DataBindings.Clear();

            MADV.DataBindings.Clear();

            Textbox_TenDichVu.DataBindings.Add("Text",dt,"Tên dịch vụ");
            Textbox_GiaDichVu.DataBindings.Add("Text",dt,"Giá dịch vụ");

            MADV.DataBindings.Add("Text", dt, "Mã dịch vụ");
        }
        private void FindDV_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FindDV_Click(object sender, EventArgs e)
        {
            TextBox_Find_TenDichVu.Clear();
        }

        private void FindDV_Leave(object sender, EventArgs e)
        {
            if(TextBox_Find_TenDichVu.Text.Trim() == "")
            {
                TextBox_Find_TenDichVu.Text = "Tìm kiếm dịch vụ";
            }    
        }

        private void BTN_THEMDV_Click(object sender, EventArgs e)
        {
            
        }

        private void BTN_UPDATEDV_Click(object sender, EventArgs e)
        {
          
        }
        private void BTN_SAVEDV_Click(object sender, EventArgs e)
        {
          
        }
        private void TEXT_GIADV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
