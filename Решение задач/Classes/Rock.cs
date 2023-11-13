using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий игру Скала для турнира.
    /// </summary>
    class Rock : IGame
    {
        #region Методы
        public void StartTheGame()
        {
            Console.WriteLine($"Началась игра Скала");
        }
        #endregion
    }
}
