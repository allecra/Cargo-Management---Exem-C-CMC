using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace _4
{
    internal class Hanghoa
    {
        public string ID { get; set; }
        public string MaVach { get; set; }
        public string Ten { get; set; }
        public float GiaBan { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, Mã Vạch: {MaVach}, Tên: {Ten}, Giá Bán: {GiaBan}";
        }
    }
}

