using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using OOP5_1;

abstract class Figure
{
    public int CenterX { get; set; }
    public int CenterY { get; set; }

    public abstract void DrawBlack(Graphics g); 
    public abstract void HideDrawingBackground(Graphics g); 

    public abstract int GetWidth(); 

    //public void MoveRight(Form form, ref bool isMoving)
    //{
    //    Graphics g = form.CreateGraphics();
    //    int formWidth = form.ClientSize.Width; 
    //    while (CenterX + GetWidth() / 2 < formWidth && isMoving) 
    //    {
    //        HideDrawingBackground(g);  
    //        CenterX += 1;          
    //        DrawBlack(g);          
    //        Thread.Sleep(8);       
    //    }

    //    HideDrawingBackground(g);
    //}

    public void MoveRightAsync(Form form)
    {
        Task.Run(() =>
        {
            Graphics g = form.CreateGraphics();
            int formWidth = form.ClientSize.Width;
            while (CenterX + GetWidth() / 2 < formWidth && ((Form1)form).IsMoving)
            {
                form.Invoke((MethodInvoker)(() => HideDrawingBackground(g)));
                CenterX += 1; 
                form.Invoke((MethodInvoker)(() => DrawBlack(g)));
                Thread.Sleep(8);
            }

            //deleting figures
            form.Invoke((MethodInvoker)(() => HideDrawingBackground(g)));
        });
    }

}
