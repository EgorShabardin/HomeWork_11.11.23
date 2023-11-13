using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий игру Рыбалка для турнира.
    /// </summary>
    class Fishing : IGame
    {
        #region Методы
        public void StartTheGame()
        {
            Console.WriteLine($"Началась игра Рыбалка");
        }
        #endregion
    }
}
