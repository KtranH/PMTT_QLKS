using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using BLL;
using DTO;

namespace QLKS
{
    public partial class Phong : Form
    {
        PHONG_BLL db = new PHONG_BLL();
        LOAIPHONG_BLL loaiPhong = new LOAIPHONG_BLL();
        public string UserCurrentPH { get; set; }
        public Phong()
        {
            InitializeComponent();
        }
        private void Phong_Load(object sender, EventArgs e)
        {
            loadPhong();
            loadCombox();
        }
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu phòng vào datagrid view
        public void loadPhong()
        {
            List<PHONG> listPhong = db.GetAllPhong();
            Data_Phong.DataSource = listPhong.Select(p => new { p.ID, p.TENPHONG, p.LOAIPHONG.TENLOAIPHONG, p.VITRI, p.TRANGTHAI }).ToList();
            Data_Phong.Columns[0].HeaderText = "Mã phòng";
            Data_Phong.Columns[1].HeaderText = "Tên phòng";
            Data_Phong.Columns[2].HeaderText = "Loại phòng";
            Data_Phong.Columns[3].HeaderText = "Vị trí";
            Data_Phong.Columns[4].HeaderText = "Trạng thái";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Chuẩn bị dữ liệu vào combobox Tình Trạng và Loại Phòng
        public void loadCombox()
        {
            List<LOAIPHONG> listLoaiPhong = new List<LOAIPHONG>();
            listLoaiPhong = loaiPhong.GetAllLoaiPhong();
            Combox_LoaiPhong.DataSource = listLoaiPhong;
            Combox_LoaiPhong.DisplayMember = "TENLOAIPHONG";
            Combox_LoaiPhong.ValueMember = "ID";
            List<string> tinhTrangList = new List<string>();
            tinhTrangList.Add("Trống");
            tinhTrangList.Add("Đã thuê");
            tinhTrangList.Add("Không khả dụng");
            Combox_TinhTrang.DataSource = tinhTrangList;
            Combox_Find_LoaiPhong.DataSource = listLoaiPhong;
            Combox_Find_LoaiPhong.DisplayMember = "TENLOAIPHONG";
            Combox_Find_LoaiPhong.ValueMember = "ID";
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Lấy dữ liệu từ datagird view sang textbox
        private void DS_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = Data_Phong.Rows[e.RowIndex];
                Textbox_TenPhong.Text = row.Cells[1].Value.ToString();
                Textbox_ViTri.Text = row.Cells[3].Value.ToString();
                Combox_TinhTrang.Text = row.Cells[4].Value.ToString();
                Combox_LoaiPhong.Text = row.Cells[2].Value.ToString();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Tìm kiếm tên phòng, loại phòng
        private void Textbox_Find_Phong_TextChanged(object sender, EventArgs e)
        {
            if(Textbox_Find_Phong.Text.Trim() != "")
            {
                string find = Textbox_Find_Phong.Text;
                List<PHONG> listPhong = new List<PHONG>();
                listPhong = db.GetFindPhong(find);
                Data_Phong.DataSource = listPhong.Select(p => new { p.ID, p.TENPHONG, p.LOAIPHONG.TENLOAIPHONG, p.VITRI, p.TRANGTHAI }).ToList();
            }
        }
        private void FindRoom_Leave(object sender, EventArgs e)
        {
            if (Textbox_Find_Phong.Text.Trim() == "")
            {
                Textbox_Find_Phong.Text = "Tìm kiếm phòng";
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //Chọn tìm kiếm loại phòng
        private void Combox_Find_LoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {
            if(Combox_Find_LoaiPhong.Text.Trim() != "Tất cả")
            {
                string find = Combox_Find_LoaiPhong.Text;
                List<PHONG> listPhong = new List<PHONG>();
                listPhong = db.GetFindPhong(find);
                Data_Phong.DataSource = listPhong.Select(p => new { p.ID, p.TENPHONG, p.LOAIPHONG.TENLOAIPHONG, p.VITRI, p.TRANGTHAI }).ToList();
            }
            else
            {
                List<PHONG> listPhong = new List<PHONG>();
                listPhong = db.GetAllPhong();
                Data_Phong.DataSource = listPhong.Select(p => new { p.ID, p.TENPHONG, p.LOAIPHONG.TENLOAIPHONG, p.VITRI, p.TRANGTHAI }).ToList();
            }    
        }
        //-----------------------------------------------------------------------------------------------------
        private void FindRoom_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FindRoom_Click(object sender, EventArgs e)
        {
            Textbox_Find_Phong.Clear();
        }
        private void FindKind_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FindKind_Click(object sender, EventArgs e)
        {
           
        }

        private void FindKind_Leave(object sender, EventArgs e)
        {
           
        }

        private void BTN_THEMPHONG_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_SAVEROOM_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có hợp lệ không
            if (Textbox_TenPhong.Text.Trim() != "" && Textbox_ViTri.Text.Trim() != "" && Combox_TinhTrang.Text.Trim() != "" && Combox_LoaiPhong.SelectedValue != null)
            {
                // Kiểm tra xem có phòng nào được chọn trong DataGridView hay không
                if (Data_Phong.SelectedRows.Count > 0)
                {
                    // Hiển thị hộp thoại xác nhận
                    DialogResult result = MessageBox.Show("Bạn có muốn cập nhật phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Nếu người dùng chọn Yes, thực hiện cập nhật
                    if (result == DialogResult.Yes)
                    {
                        // Lấy ID phòng từ dòng đã chọn trong DataGridView
                        int phongID = Convert.ToInt32(Data_Phong.SelectedRows[0].Cells[0].Value);

                        // Tạo đối tượng phòng và gán thông tin
                        PHONG phong = new PHONG
                        {
                            ID = phongID, // Lấy ID phòng từ DataGridView
                            TENPHONG = Textbox_TenPhong.Text,
                            VITRI = Textbox_ViTri.Text,
                            // Cập nhật LOAIPHONG_ID với giá trị mới từ ComboBox
                            LOAIPHONG_ID = Convert.ToInt32(Combox_LoaiPhong.SelectedValue),
                            TRANGTHAI = Combox_TinhTrang.Text
                        };

                        // Gọi phương thức cập nhật trong BLL
                        db.UpdatePhong(phong);

                        // Cập nhật lại danh sách phòng
                        loadPhong();

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Cập nhật phòng thành công.");

                        // Disable các TextBox và ComboBox sau khi lưu
                        Textbox_TenPhong.Enabled = false;
                        Textbox_ViTri.Enabled = false;
                        Combox_LoaiPhong.Enabled = false;
                        Combox_TinhTrang.Enabled = false;
                    }
                    else
                    {
                        // Nếu người dùng chọn No, không làm gì cả
                        MessageBox.Show("Cập nhật phòng đã bị hủy.");
                    }
                }
                else
                {
                    // Nếu không có phòng nào được chọn, hiển thị thông báo
                    MessageBox.Show("Vui lòng chọn phòng cần cập nhật.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }
        private void BTN_UPDATEROOM_Click(object sender, EventArgs e)
        {
            Textbox_TenPhong.Enabled = true;
            Textbox_ViTri.Enabled = true;
            Combox_LoaiPhong.Enabled = true;
            Combox_TinhTrang.Enabled = true;
        }

        private void TEXT_GIA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private void TEXT_SUCCHUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void BTN_THEMLOAI_Click(object sender, EventArgs e)
        {
           
        }
        private void DT_DS_LOAI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void BTN_SAVEKIND_Click(object sender, EventArgs e)
        {
           
        }
        private void BTN_UPDATEKIND_Click(object sender, EventArgs e)
        {
           
        }

        private void Combox_LoaiPhong_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
