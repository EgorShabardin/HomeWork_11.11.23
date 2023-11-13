using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий игру Море для турнира.
    /// </summary>
    class Sea : IGame
    {
        #region Методы
        public void StartTheGame()
        {
            Console.WriteLine($"Началась игра Море");
        }
        #endregion
    }
}
