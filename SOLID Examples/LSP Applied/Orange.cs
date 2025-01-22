using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples.LSP_Applied
{
    public class Orange : IFruit
    {
        public string GetColor()
        {
            return "Orange";
        }
    }
}
