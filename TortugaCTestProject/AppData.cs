using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TortugaCTestProject
{
    internal class AppData
    {
        public static TortugaCEntities Context { get; } = new TortugaCEntities();
    }
}
