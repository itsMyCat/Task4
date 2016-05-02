using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Classes.Interfaces;

namespace WindowsFormsApplication1.Classes
{
    abstract class Path:IGeometryPath {
        protected IList<PointF> ListPoints;

        public Path(IList<PointF> listPoints ) {
            this.ListPoints = new List<PointF>(listPoints);
        }
        protected IList<PointF> PointSort() {
            return this.ListPoints.OrderBy(x => x.Y).ThenBy(x=>x.X).ToList();
        }

        public abstract void Draw(Graphics graphics);
    }
}
