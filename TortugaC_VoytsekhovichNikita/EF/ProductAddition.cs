using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TortugaC_VoytsekhovichNikita.ClassHepler;

namespace TortugaC_VoytsekhovichNikita.EF
{
    public partial class Product
    {

        public int OrderProdCount
        {
            get
            {
                int res = Information.ListOfOrder.Count(i => i.Title == Title);
                return res;
            }

        }
        public decimal OrderTotalCostOfProduct
        {
            get
            {
                decimal res = OrderProdCount * Price;
                return res;
            }
        }
    }
}
