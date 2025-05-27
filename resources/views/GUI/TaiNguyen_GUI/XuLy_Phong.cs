using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.TaiNguyen_GUI
{
    public class XuLy_Phong
    {
        public NHANVIEN NHANVIEN { get; set; }
        //-----------------------------------------------------------------------------------------------------
        //Kiểm tra quyền truy cập vào phòng
        public bool CheckRole()
        {
            if(NHANVIEN.CHUCVU == "Lễ tân")
            {
                return false;
            }
            return true;
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
