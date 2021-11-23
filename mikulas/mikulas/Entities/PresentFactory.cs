using mikulas.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mikulas.Entities
{
    class PresentFactory : IToyFactory
    {
        public Color RibbonColor { get; set; }
        public Color BoxColor { get; set; }
        public Present CreateNew()
        {
            return new Present(RibbonColor, BoxColor);
        }

        Toy IToyFactory.CreateNew()
        {
            return new Present(RibbonColor, BoxColor);
        }
    }
}
