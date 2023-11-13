using System;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий игры для турнира.
    /// </summary>
    class Game : IGame
    {
        #region Поля
        readonly string gameTitle;
        #endregion

        #region Методы
        public void startTheGame()
        {
            Console.WriteLine($"Началась игра {gameTitle}");
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Game.
        /// </summary>
        /// <param name="gameTitle"> Название игры. </param>
        public Game(string gameTitle)
        {
            this.gameTitle = gameTitle;
        }
        #endregion
    }
}
