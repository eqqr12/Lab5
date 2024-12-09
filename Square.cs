using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5_1
{
    class Square : Figure
    {
        public int SideLength { get; set; }

        public override int GetWidth()
        {
            return SideLength;
        }


        public Square(int centerX, int centerY, int sideLength)
        {
            CenterX = centerX;
            CenterY = centerY;
            SideLength = sideLength;
        }

        public override void DrawBlack(Graphics g)
        {
            using (Pen bluePen = new Pen(Color.Blue, 2)) 
            {
                g.DrawRectangle(bluePen, CenterX - SideLength / 2, CenterY - SideLength / 2, SideLength, SideLength);
            }
        }

        public override void HideDrawingBackground(Graphics g)
        {
            using (Pen whitePen = new Pen(Color.White, 2)) 
            {
                g.DrawRectangle(whitePen, CenterX - SideLength / 2, CenterY - SideLength / 2, SideLength, SideLength);
            }
        }

    }

}
