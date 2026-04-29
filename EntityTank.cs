namespace ProjectTank;

/// <summary>
/// Класс-сущность "Автомобиль"
/// </summary>
public class EntityTank
{
    /// <summary>
    /// Скорость (влияет на шаг)
    /// </summary>
    public int Speed { get; private set; }

    /// <summary>
    /// Вес (влияет на шаг)
    /// </summary>
    public double Weight { get; private set; }

    /// <summary>
    /// Основной цвет корпуса
    /// </summary>
    public Color BodyColor { get; private set; }

    /// <summary>
    /// Шаг перемещения (пикселей)
    /// </summary>
    public double Step => Speed * 100 / Weight;

    /// <summary>
    /// Инициализация характеристик
    /// </summary>
    public void Init(int speed, double weight, Color bodyColor)
    {
        Speed = speed;
        Weight = weight;
        BodyColor = bodyColor;
    }
}