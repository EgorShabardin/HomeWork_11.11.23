namespace Тумаков___Лабораторная_работа__10
{
    /// <summary>
    /// Абстрактный класс, описывающий геометрическую фигуру.
    /// </summary>
    abstract class Figure : IFigure
    {
        #region Поля
        protected double horizontalCoordinate;
        protected double verticalCoordinate;
        protected string figureColor;
        protected bool figureVisible;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее получить координаты фигуры.
        /// </summary>
        public (double, double) FigureCoordinates
        {
            get
            {
                return (horizontalCoordinate, verticalCoordinate);
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле figureColor.
        /// </summary>
        public string FigureColor
        {
            get
            {
                return figureColor;
            }
        }
        #endregion

        #region Методы
        public void MovementHorizontally()
        {
            horizontalCoordinate++;
        }

        public void MovementVertically()
        {
            verticalCoordinate++;
        }

        public void ChangingColorOfFigure(string newColor)
        {
            figureColor = newColor;
        }

        public abstract void FigureStatusSurvey();

        public abstract void DisplayingFigureData();
        #endregion
    }
}
