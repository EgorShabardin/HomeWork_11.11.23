using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий игру Мышеловка для турнира.
    /// </summary>
    class Mousetrap : IGame
    {
        #region Методы
        public void StartTheGame()
        {
            Console.WriteLine($"Началась игра Мышеловка");
        }
        #endregion
    }
}
