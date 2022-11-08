using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortugaC_VoytsekhovichNikita.ClassHepler
{
    public static class Information
    {
        public static EF.Table ID { get; set; }
        public static List<EF.Product> ListOfOrder = new List<EF.Product>();
    }
}
