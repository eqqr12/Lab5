using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace OOP5_1
{
    public partial class Form1 : Form
    {
        public bool IsMoving { get; private set; } = true; // Прапор руху

        public Form1()
        {
            InitializeComponent();

            this.Width = 515;

            this.Height = 500; 

            this.BackColor = Color.White;

            Button circleButton = new Button
            {
                Text = "Коло",
                Location = new System.Drawing.Point(50, 50),
                Size = new System.Drawing.Size(100, 50)
            };
            Button squareButton = new Button
            {
                Text = "Квадрат",
                Location = new System.Drawing.Point(200, 50),
                Size = new System.Drawing.Size(100, 50)
            };
            Button rhombButton = new Button
            {
                Text = "Ромб",
                Location = new System.Drawing.Point(350, 50),
                Size = new System.Drawing.Size(100, 50)
            };

            circleButton.Click += CircleButton_Click;
            squareButton.Click += SquareButton_Click;
            rhombButton.Click += RhombButton_Click;

            this.Controls.Add(circleButton);
            this.Controls.Add(squareButton);
            this.Controls.Add(rhombButton);
        }




        private void CircleButton_Click(object sender, EventArgs e)
        {
            IsMoving = true;
            Circle circle = new Circle(100, 300, 50);
            circle.DrawBlack(this.CreateGraphics());
            circle.MoveRightAsync(this);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            IsMoving = true;
            Square square = new Square(100, 300, 100);
            square.DrawBlack(this.CreateGraphics());
            square.MoveRightAsync(this);
        }

        private void RhombButton_Click(object sender, EventArgs e)
        {
            IsMoving = true;
            Rhomb rhomb = new Rhomb(100, 300, 120, 80);
            rhomb.DrawBlack(this.CreateGraphics());
            rhomb.MoveRightAsync(this);
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            IsMoving = false; //stopping figures
        }



    }
}
