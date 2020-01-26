using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hogge
{
    public class Desk
    {
        public enum DesktopMaterial
        {
            Oak, Laminate, Pine, Rosewood, Veneer
        }

        public int Width { get; set; }

        public int Depth { get; set; }

        public int NumberOfDrawers { get; set; }

        public DesktopMaterial MaterialType { get; set; }
    }
}
