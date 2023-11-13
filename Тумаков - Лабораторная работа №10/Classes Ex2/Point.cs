using System;

namespace Тумаков___Лабораторная_работа__10
{
    /// <summary>
    /// Класс, описывающий геометрическую фигуру точку.
    /// </summary>
    class Point : Figure
    {
        #region Методы
        public override void FigureStatusSurvey()
        {
            if (figureVisible)
            {
                Console.WriteLine("Точка видима");
            }
            else
            {
                Console.WriteLine("Точка невидима");
            }
        }

        public override void DisplayingFigureData()
        {
            Console.WriteLine($"Точка {figureColor} цвета. Координаты по вертикали: {verticalCoordinate}. Координаты по горизонтали {horizontalCoordinate}. Видимость: {figureVisible}");
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Point.
        /// </summary>
        /// <param name="figureColor"> Цвет точки. </param>
        /// <param name="figureVisible"> Видимость точки. </param>
        public Point(string figureColor, bool figureVisible)
        {
            this.figureColor = figureColor;
            this.figureVisible = figureVisible;
            horizontalCoordinate = 0;
            verticalCoordinate = 0;
        }
        #endregion
    }
}
