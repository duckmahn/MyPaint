using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class MyCircle : Shape

    {


        public MyCircle()
        {

        }

        public MyCircle(Point sPoint, Point ePoint, int borderWidth, Color borderColor) : base (sPoint, ePoint, borderWidth, borderColor)
        {

        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(_borderColor, _borderWidth);
            RectangleF recf = new RectangleF(Location.X, Location.Y, _width, _height);
            g.DrawEllipse(pen, recf);
        }
    }
}
