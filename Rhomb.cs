using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_1
{
    class Rhomb : Figure
    {
        public int HorDiagLen { get; set; }
        public int VertDiagLen { get; set; }

        public override int GetWidth()
        {
            return HorDiagLen;
        }


        public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen)
        {
            CenterX = centerX;
            CenterY = centerY;
            HorDiagLen = horDiagLen;
            VertDiagLen = vertDiagLen;
        }

        public override void DrawBlack(Graphics g)
        {
            using (Pen greenPen = new Pen(Color.Green, 2)) 
            {
                Point[] points = {
            new Point(CenterX, CenterY - VertDiagLen / 2),
            new Point(CenterX + HorDiagLen / 2, CenterY),
            new Point(CenterX, CenterY + VertDiagLen / 2),
            new Point(CenterX - HorDiagLen / 2, CenterY)
        };
                g.DrawPolygon(greenPen, points);
            }
        }

        public override void HideDrawingBackground(Graphics g)
        {
            using (Pen whitePen = new Pen(Color.White, 2))
            {
                Point[] points = {
            new Point(CenterX, CenterY - VertDiagLen / 2),
            new Point(CenterX + HorDiagLen / 2, CenterY),
            new Point(CenterX, CenterY + VertDiagLen / 2),
            new Point(CenterX - HorDiagLen / 2, CenterY)
        };
                g.DrawPolygon(whitePen, points);
            }
        }

    }

}
