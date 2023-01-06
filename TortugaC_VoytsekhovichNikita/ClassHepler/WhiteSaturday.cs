using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortugaC_VoytsekhovichNikita.ClassHepler
{
    internal class WhiteSaturday
    {
        public static string totalPrice(List<EF.Product> products)
        {
            decimal totalCost = 0;
            foreach (EF.Product prod in products)
            {
                totalCost += prod.Price;
            }

            // акция "Белая суббота".
            if ((DateTime.Now.Day == 29 || DateTime.Now.Day == 30 || DateTime.Now.Day == 31) && DateTime.Now.DayOfWeek.ToString() == "Saturday")
            {
                totalCost = totalCost - (totalCost * Convert.ToDecimal(0.11));
            }
            return Convert.ToString(totalCost);
        }
    }
}
