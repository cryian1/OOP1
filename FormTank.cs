namespace ProjectTank;

public partial class FormTank : Form
{
    private CanvasForTank _canvas;
    private Random random = new Random();

    public FormTank()
    {
        InitializeComponent();
        _canvas = new CanvasForTank();
        _canvas.SetPictureSize(pictureBoxSportCar.Width, pictureBoxSportCar.Height);
        this.Resize += (s, e) =>
        {
            if (pictureBoxSportCar.Width > 0 && pictureBoxSportCar.Height > 0)
                _canvas.SetPictureSize(pictureBoxSportCar.Width, pictureBoxSportCar.Height);
            Draw();
        };
    }

    private void ButtonCreate_Click(object sender, EventArgs e)
    {
        // Скорость: от 15 до 25 (увеличена и случайна, но не сильно отличается)
        int speed = random.Next(15, 26);   // 15..25
        double weight = random.Next(50, 200);
        Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

        DrawingTank tank = new DrawingTank();
        tank.Init(speed, weight, color);

        if (_canvas.InsertCar(tank))
        {
            int startX = 50;
            int startY = 50;
            _canvas.SetCarPosition(startX, startY);
            Draw();
        }
        else
        {
            MessageBox.Show("Танк не помещается в поле!", "Ошибка");
        }
    }
    private void ButtonMove_Click(object sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            DirectionType direction = btn.Name switch
            {
                "buttonUp" => DirectionType.Up,
                "buttonDown" => DirectionType.Down,
                "buttonLeft" => DirectionType.Left,
                "buttonRight" => DirectionType.Right,
                _ => DirectionType.None
            };
            if (direction != DirectionType.None && _canvas.MoveTransport(direction))
                Draw();
        }
    }

    private int _borderTestStep = 0; // поле класса для запоминания текущего теста

    private void ButtonCheckBorders_Click(object sender, EventArgs e)
    {
        int badX = 0, badY = 0;
        switch (_borderTestStep % 4)
        {
            case 0: // Левый верхний угол: отрицательные координаты
                badX = -100;
                badY = -100;
                break;
            case 1: // Правый верхний угол: X за правую границу, Y отрицательный
                badX = pictureBoxSportCar.Width + 100;
                badY = -100;
                break;
            case 2: // Левый нижний угол: X отрицательный, Y за нижнюю границу
                badX = -100;
                badY = pictureBoxSportCar.Height + 100;
                break;
            case 3: // Правый нижний угол: X и Y за границы
                badX = pictureBoxSportCar.Width + 100;
                badY = pictureBoxSportCar.Height + 100;
                break;
        }
        _borderTestStep++;
        _canvas.SetCarPosition(badX, badY);
        Draw();
    }

    private void Draw()
    {
        Bitmap bmp = _canvas.DrawCanvas();
        if (bmp != null)
        {
            if (pictureBoxSportCar.Image != null)
                pictureBoxSportCar.Image.Dispose();
            pictureBoxSportCar.Image = bmp;
        }
    }
}
