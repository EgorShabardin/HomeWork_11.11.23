using System.Collections.Generic;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий шоу Большие гонки.
    /// </summary>
    class BigRaceShow
    {
        #region Поля
        readonly List<IGame> gamesList = new List<IGame>();
        readonly List<Team> teamsList = new List<Team>();
        private static BigRaceShow show = null;
        #endregion

        #region Методы
        /// <summary>
        /// Метод, позволяющий добавить игру в шоу.
        /// </summary>
        /// <param name="game"> Игра. </param>
        public void AddGameToShow(IGame game)
        {
            gamesList.Add(game);
        }

        /// <summary>
        /// Метод, позволяющий добавить команду в шоу.
        /// </summary>
        /// <param name="team"> Команда. </param>
        public void AddTeamToTeamsList(Team team)
        {
            teamsList.Add(team);
        }

        /// <summary>
        /// Метод, позволяющий начать шоу.
        /// </summary>
        public void StartShow(IGame game)
        {
            game.StartTheGame();
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса BigRaceShow только один раз.
        /// </summary>
        /// <returns> Экземпляр класса BigRaceShow. </returns>
        public static BigRaceShow getInstance()
        {
            if (show == null)
            {
                show = new BigRaceShow(); 
            }

            return show;
        }
        #endregion
    }
}
