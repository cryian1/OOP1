namespace ProjectTank;

/// <summary>
/// Полотно
/// </summary>
public class CanvasForTank
{
    private DrawingTank? _drawingTank;
    private int? _canvasWidth;
    private int? _canvasHeight;

    /// <summary>
    /// Установка размеров поля (PictureBox)
    /// </summary>
    public void SetPictureSize(int width, int height)
    {
        _canvasWidth = width;
        _canvasHeight = height;
    }

    /// <summary>
    /// Вставка объекта на поле (проверка размеров)
    /// </summary>
    public bool InsertCar(DrawingTank tank)
    {
        if (_canvasWidth == null || _canvasHeight == null)
            return false;

        // Проверяем, помещается ли танк по размерам
        if (tank.DrawingWidth > _canvasWidth || tank.DrawingHeight > _canvasHeight)
            return false;

        _drawingTank = tank;
        return true;
    }

    /// <summary>
    /// Установка позиции с корректировкой границ
    /// </summary>
    public void SetCarPosition(int x, int y)
    {
        if (_drawingTank == null || _canvasWidth == null || _canvasHeight == null)
            return;

        int maxX = _canvasWidth.Value - _drawingTank.DrawingWidth;
        int maxY = _canvasHeight.Value - _drawingTank.DrawingHeight;

        int newX = Math.Clamp(x, 0, maxX);
        int newY = Math.Clamp(y, 0, maxY);

        _drawingTank.SetPosition(newX, newY);
    }

    /// <summary>
    /// Перемещение в заданном направлении с проверкой границ
    /// </summary>
    public bool MoveTransport(DirectionType direction)
    {
        if (_drawingTank == null || _canvasWidth == null || _canvasHeight == null)
            return false;
        if (!_drawingTank.PosX.HasValue || !_drawingTank.PosY.HasValue || !_drawingTank.CarStep.HasValue)
            return false;

        double step = _drawingTank.CarStep.Value;
        int newX = _drawingTank.PosX.Value;
        int newY = _drawingTank.PosY.Value;

        switch (direction)
        {
            case DirectionType.Left:
                newX -= (int)step;
                if (newX >= 0)
                    _drawingTank.MoveLeft();
                else return false;
                break;
            case DirectionType.Right:
                newX += (int)step;
                if (newX + _drawingTank.DrawingWidth <= _canvasWidth)
                    _drawingTank.MoveRight();
                else return false;
                break;
            case DirectionType.Up:
                newY -= (int)step;
                if (newY >= 0)
                    _drawingTank.MoveUp();
                else return false;
                break;
            case DirectionType.Down:
                newY += (int)step;
                if (newY + _drawingTank.DrawingHeight <= _canvasHeight)
                    _drawingTank.MoveDown();
                else return false;
                break;
            default:
                return false;
        }
        return true;
    }

    /// <summary>
    /// Отрисовка поля (возвращает Bitmap)
    /// </summary>
    public Bitmap? DrawCanvas()
    {
        if (_canvasWidth == null || _canvasHeight == null || _drawingTank == null)
            return null;

        Bitmap bmp = new(_canvasWidth.Value, _canvasHeight.Value);
        using (Graphics g = Graphics.FromImage(bmp))
        {
            g.Clear(Color.LightGray);
            _drawingTank.DrawTransport(g);
        }
        return bmp;
    }
}