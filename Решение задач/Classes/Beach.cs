using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий игру Пляж для турнира.
    /// </summary>
    class Beach : IGame
    {
        #region Методы
        public void StartTheGame()
        {
            Console.WriteLine($"Началась игра Пляж");
        }
        #endregion
    }
}
