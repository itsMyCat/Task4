using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Classes
{
    class Curve:Path
    {
        public override void Draw(Graphics graphics) {
            var tempList = this.PointSort();
            graphics.DrawCurve(Pens.Black,tempList.ToArray());
        }

        public Curve(IList<PointF> listPoints) : base(listPoints) {
        }
    }
}
