using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class HinhChuNhat
    {

        public double chieuCao; //tính (attribute) biến 
        public double chieuRong;//tính (attribute) biến
        public double tinhdientich() // phương thức (methed) hàm
        {
            return chieuCao * chieuRong;
        }
        public double tinhchuvi()
        {
            return (chieuCao + chieuRong)*2;
        }
    }
}
