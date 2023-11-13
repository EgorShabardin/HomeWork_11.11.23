using System.Collections.Generic;
using System.ServiceModel;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий шоу Большие гонки.
    /// </summary>
    class BigRaceShow
    {
        #region Поля
        private List<IGame> gamesList = new List<IGame>();
        private List<Team> teamsList = new List<Team>();
        private static BigRaceShow show = null;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее читать поле gamesList.
        /// </summary>
        public List<IGame> GamesList
        {
            get
            {
                return gamesList;
            }
        }

        /// <summary>
        /// Свойство, позволяющее читать поле teamsList.
        /// </summary>
        public List<Team> TeamsList
        {
            get
            {
                return teamsList;
            }
        }
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
        public void StartShow()
        {
            foreach(IGame game in gamesList)
            {
                game.startTheGame();
            }
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса BigRaceShow только один раз.
        /// </summary>
        /// <returns> Экземпляр класса BigRaceShow. </returns>
        public static BigRaceShow getInstanse()
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
