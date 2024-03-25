using TestTask.Common;
using TestTask.Interfaces;

namespace TestTask
{
    /// <summary>
    /// Класс позволяющий рассчитать площадь фигуры без знания типа фигуры в compile-time
    /// </summary>
    public class CalculatorFigure : ICalculatorFigure
    {
        public double CalculateFigureArea(IFigure figure) => figure.СalculationArea;

    }
}
