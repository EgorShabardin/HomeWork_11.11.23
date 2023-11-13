using System;

namespace Тумаков___Лабораторная_работа__10
{
    /// <summary>
    /// Класс, описывающий геометрическую фигуру прямоугольник.
    /// </summary>
    class Rectangle : Point
    {
        #region Поля
        readonly double rectangleWidth;
        readonly double rectangleHeight;
        #endregion

        #region Методы
        /// <summary>
        /// Метод, считающий площадь прямоугольника.
        /// </summary>
        public void CalculationOfArea()
        {
            Console.WriteLine($"Площадь прямоугольника равна {rectangleHeight * rectangleWidth}");
        }

        public override void FigureStatusSurvey()
        {
            if (figureVisible)
            {
                Console.WriteLine("Прямоугольник видим");
            }
            else
            {
                Console.WriteLine("Прямоугольник невидим");
            }
        }

        public override void DisplayingFigureData()
        {
            Console.WriteLine($"Прямоугольник {figureColor} цвета. Координаты по вертикали: {verticalCoordinate}\n" +
                              $"Координаты по горизонтали {horizontalCoordinate}. Видимость: {figureVisible}. Ширина: {rectangleWidth}. Высота: {rectangleHeight}");
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Rectangle.
        /// </summary>
        /// <param name="rectangleWidth"> Ширина прямоугольника. </param>
        /// <param name="rectangleHeight"> Высота прямоугольника. </param>
        /// <param name="figureColor"> Цвет прямоугольника. </param>
        /// <param name="figureVisible"> Видимость прямоугольника. </param>
        public Rectangle(double rectangleWidth, double rectangleHeight, string figureColor, bool figureVisible) : base(figureColor, figureVisible)
        {
            this.rectangleHeight = rectangleHeight;
            this.rectangleWidth = rectangleWidth;
        }
        #endregion
    }
}
