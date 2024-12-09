using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_1
{
    class Circle : Figure
    {
        public int Radius { get; set; }

        public override int GetWidth()
        {
            return Radius * 2;
        }


        public Circle(int centerX, int centerY, int radius)
        {
            CenterX = centerX;
            CenterY = centerY;
            Radius = radius;
        }

        public override void DrawBlack(Graphics g)
        {
            using (Pen redPen = new Pen(Color.Red, 2))
            {
                g.DrawEllipse(redPen, CenterX - Radius, CenterY - Radius, Radius * 2, Radius * 2);
            }
        }

        public override void HideDrawingBackground(Graphics g)
        {
            using (Pen whitePen = new Pen(Color.White, 2)) 
            {
                g.DrawEllipse(whitePen, CenterX - Radius, CenterY - Radius, Radius * 2, Radius * 2);
            }
        }

    }
}
