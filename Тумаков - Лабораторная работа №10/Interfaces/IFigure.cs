namespace Тумаков___Лабораторная_работа__10
{
    /// <summary>
    /// Интерфейс, определеющий методы работы с геометрическими фигурами.
    /// </summary>
    interface IFigure
    {
        /// <summary>
        /// Метод, позволяющий передвигать фигуру по горизонтали.
        /// </summary>
        void MovementHorizontally();

        /// <summary>
        /// Метод, позволяющий передвигать фигуру по вертикали.
        /// </summary>
        void MovementVertically();

        /// <summary>
        /// Метод, позволяющий изменить цвет фигуры.
        /// </summary>
        /// <param name="newColor"> Новый цвет фигуры. </param>
        void ChangingColorOfFigure(string newColor);

        /// <summary>
        /// Метод, который выводит на экран состояние фигуры (видимое, невидимое).
        /// </summary>
        void FigureStatusSurvey();

        /// <summary>
        /// Метод, который выводит на экран все данные о фигуре.
        /// </summary>
        void DisplayingFigureData();
    }
}
