using System;

namespace Тумаков___Лабораторная_работа__10
{
    /// <summary>
    /// Класс, описывающий геометрическую фигуру круг.
    /// </summary>
    class Circle : Point
    {
        #region Поля
        readonly double circleRadius;
        #endregion

        #region Методы
        /// <summary>
        /// Метод, считающий площадь круга.
        /// </summary>
        public void CalculationOfArea()
        {
            Console.WriteLine($"Площадь круга равна {Math.PI * Math.Pow(circleRadius, 2)}");
        }
        public override void FigureStatusSurvey()
        {
            if (figureVisible)
            {
                Console.WriteLine("Круг видим");
            }
            else
            {
                Console.WriteLine("Круг невидим");
            }
        }
        public override void DisplayingFigureData()
        {
            Console.WriteLine($"Круг {figureColor} цвета. Координаты по вертикали: {verticalCoordinate}. " +
                              $"Координаты по горизонтали {horizontalCoordinate}. Видимость: {figureVisible}. Радиус: {circleRadius}");
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Circle.
        /// </summary>
        /// <param name="circleRadius"> Радиус круга. </param>
        /// <param name="figureColor"> Цвет круга. </param>
        /// <param name="figureVisible"> Видимость круга. </param>
        public Circle(double circleRadius, string figureColor, bool figureVisible) : base(figureColor, figureVisible)
        {
            this.circleRadius = circleRadius;
        }
        #endregion
    }
}
