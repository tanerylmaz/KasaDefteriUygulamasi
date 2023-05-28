using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaDefteri
{
    public class DataList
    {
        public static List<Data> Veriler { get; set; } = new List<Data>();
        public static decimal Maas { get {
                return 15000m;
            } }
    }
}
