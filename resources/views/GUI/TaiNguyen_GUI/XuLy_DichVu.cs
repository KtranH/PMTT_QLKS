using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace GUI.TaiNguyen_GUI
{
    public class XuLy_DichVu
    {
        public NHANVIEN NHANVIEN { get; set; }
        //-----------------------------------------------------------------------------------------------------
        //Kiểm tra quyền truy cập vào dịch vụ
        public bool CheckRole()
        {
            if (NHANVIEN.CHUCVU == "Lễ tân")
            {
                return false;
            }
            return true;
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
