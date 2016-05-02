using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    class Polygon:Path
    {
        public Polygon(IList<PointF> listPoints) : base(listPoints) {
        }

        public override void Draw(Graphics graphics) {
            var tempList = this.PointSort();
            graphics.FillPolygon(Brushes.BlueViolet,tempList.ToArray());
        }
    }
}
