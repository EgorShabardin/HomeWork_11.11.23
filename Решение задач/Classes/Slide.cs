using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий игру Горка для турнира.
    /// </summary>
    class Sidle : IGame
    {
        #region Методы
        public void StartTheGame()
        {
            Console.WriteLine($"Началась игра Горка");
        }
        #endregion
    }
}
