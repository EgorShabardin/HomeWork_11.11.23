using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий игру Почтальон для турнира.
    /// </summary>
    class Postmen : IGame
    {
        #region Методы
        public void StartTheGame()
        {
            Console.WriteLine($"Началась игра Почтальон");
        }
        #endregion
    }
}
