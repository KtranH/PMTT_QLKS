using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LOAIPHONG_BLL
    {

        public LOAIPHONG_BLL() { }
        LOAIPHONG_DAL DB = new LOAIPHONG_DAL();

        public List<LOAIPHONG> GetAllLoaiPhong()
        {
            return DB.GetAllLoaiPhong();
        }
        public List<HINHLOAIPHONG> GetHinhPhong(int ID)
        {
            return DB.HinhLoaiPhong(ID);
        }
        public LOAIPHONG GetLoaiPhong(int ID)
        {
            return DB.GetLoaiPhong(ID);
        }
        public int GetCountLoaiPhong(int ID)
        {
            return DB.CountHinhLoaiPhong(ID);
        }
        public void AddHinhLoaiPhong(HINHLOAIPHONG x)
        {
            DB.SaveImageLoaiPhong(x);
        }
        public void RemoveHinhLoaiPhong(HINHLOAIPHONG x)
        {
            DB.RemoveImageLoaiPhong(x);
        }
        
        public bool AddloaiPhong(LOAIPHONG ploai)
        {
            return DB.AddLoaiphong(ploai);
        }

        public bool CapNhatLoaiPhong(int pCN, string t, int sc, decimal gia, string qd, string nt, string mt)
        {
           return DB.CapNhatLoaiPhong(pCN, t, sc, gia, qd, nt, mt);
        }
    }
}
