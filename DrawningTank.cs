using System.Drawing.Drawing2D;

namespace ProjectTank;

/// <summary>
/// Класс, отвечающий за прорисовку и перемещение объекта-сущности
/// </summary>
public class DrawingTank
{
    private EntityTank? _entityTank;
    private int? _startPosX;
    private int? _startPosY;

    private readonly int _drawingWidth = 130;
    private readonly int _drawingHeight = 65;

    public int? PosX => _startPosX;
    public int? PosY => _startPosY;
    public double? CarStep => _entityTank?.Step;
    public int DrawingWidth => _drawingWidth;
    public int DrawingHeight => _drawingHeight;

    public void Init(int speed, double weight, Color bodyColor)
    {
        _entityTank = new EntityTank();
        _entityTank.Init(speed, weight, bodyColor);
        _startPosX = null;
        _startPosY = null;
    }

    public void SetPosition(int x, int y)
    {
        _startPosX = x;
        _startPosY = y;
    }

    public void MoveLeft()
    {
        if (_entityTank == null || !_startPosX.HasValue) return;
        _startPosX -= (int)_entityTank.Step;
    }

    public void MoveRight()
    {
        if (_entityTank == null || !_startPosX.HasValue) return;
        _startPosX += (int)_entityTank.Step;
    }

    public void MoveUp()
    {
        if (_entityTank == null || !_startPosY.HasValue) return;
        _startPosY -= (int)_entityTank.Step;
    }

    public void MoveDown()
    {
        if (_entityTank == null || !_startPosY.HasValue) return;
        _startPosY += (int)_entityTank.Step;
    }

    public void DrawTransport(Graphics g)
    {
        if (_entityTank == null || !_startPosX.HasValue || !_startPosY.HasValue)
            return;

        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.PixelOffsetMode = PixelOffsetMode.HighQuality;

        int x = _startPosX.Value;
        int y = _startPosY.Value;

        // Основной цвет – из характеристик танка
        Color armorColor = _entityTank.BodyColor;
        Color trackColor = Color.FromArgb(55, 55, 55);    // тёмно-серый
        Color wheelColor = Color.FromArgb(30, 30, 30);
        Color wheelHubColor = Color.FromArgb(90, 90, 90);
        Color barrelColor = Color.FromArgb(70, 80, 50);   // цвет орудия (можно тоже менять, но оставим)
        Color gunColor = Color.FromArgb(45, 45, 45);
        Pen outlinePen = new Pen(Color.Black, 1.5f);

        // КОРПУС
        // === КОРПУС (высота уменьшена в 2 раза: было 22, стало 11) ===
        int bodyX = x + 12;
        int bodyY = y + 20;       // немного опустим, чтобы сохранить общую высоту
        int bodyW = _drawingWidth - 24;
        int bodyH = 11;           // новая высота

        g.FillRectangle(new SolidBrush(armorColor), bodyX, bodyY, bodyW, bodyH);
        g.DrawRectangle(outlinePen, bodyX, bodyY, bodyW, bodyH);



        // ГУСЕНИЦА с закруглёнными краями
        int trackX = bodyX;
        int trackY = bodyY + bodyH - 2;
        int trackW = bodyW;
        int trackH = 14;
        int radius = 6;

        using (GraphicsPath trackPath = new GraphicsPath())
        {
            trackPath.AddArc(trackX, trackY, radius * 2, radius * 2, 180, 90);
            trackPath.AddLine(trackX + radius, trackY, trackX + trackW - radius, trackY);
            trackPath.AddArc(trackX + trackW - radius * 2, trackY, radius * 2, radius * 2, 270, 90);
            trackPath.AddLine(trackX + trackW, trackY + radius, trackX + trackW, trackY + trackH - radius);
            trackPath.AddArc(trackX + trackW - radius * 2, trackY + trackH - radius * 2, radius * 2, radius * 2, 0, 90);
            trackPath.AddLine(trackX + trackW - radius, trackY + trackH, trackX + radius, trackY + trackH);
            trackPath.AddArc(trackX, trackY + trackH - radius * 2, radius * 2, radius * 2, 90, 90);
            trackPath.AddLine(trackX, trackY + trackH - radius, trackX, trackY + radius);
            trackPath.CloseFigure();

            g.FillPath(new SolidBrush(trackColor), trackPath);
            g.DrawPath(outlinePen, trackPath);
        }

        // 6 КАТКОВ
        int margin = 5;
        int usableWidth = trackW - 2 * margin;
        int step = usableWidth / 5;
        int wheelSize = 11;
        int wheelY = trackY + (trackH - wheelSize) / 2;

        for (int i = 0; i < 6; i++)
        {
            int wheelX = trackX + margin + i * step - wheelSize / 2;
            if (wheelX >= trackX && wheelX + wheelSize <= trackX + trackW)
            {
                g.FillEllipse(new SolidBrush(wheelColor), wheelX, wheelY, wheelSize, wheelSize);
                g.DrawEllipse(outlinePen, wheelX, wheelY, wheelSize, wheelSize);
                g.FillEllipse(new SolidBrush(wheelHubColor), wheelX + 3, wheelY + 3, 5, 5);
            }
        }



        // БАШНЯ по центру корпуса
        int turretX = bodyX + bodyW / 2 - 30;   // смещение влево от центра
        int turretY = y + 8;
        int turretW = 44;
        int turretH = 13;

        g.FillRectangle(new SolidBrush(armorColor), turretX, turretY, turretW, turretH);
        g.DrawRectangle(outlinePen, turretX, turretY, turretW, turretH);

    }
}