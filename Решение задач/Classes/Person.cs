namespace Решение_задач
{
    /// <summary>
    /// Перечислимый тип, содержащий должности людей.
    /// </summary>
    enum PositionOfPerson
    {
        игрок,
        организатор
    }
    /// <summary>
    /// Класс, описывающий человека.
    /// </summary>
    class Person
    {
        #region Поля
        readonly string personName;
        readonly PositionOfPerson positionOfPerson;
        #endregion

        #region Методы
        /// <summary>
        /// Метод, позволяющий организатору добавить команду в шоу.
        /// </summary>
        /// <param name="tournament"> Шоу Большие гонки. </param>
        /// <param name="teams"> Команды. </param>
        public void AddingTeamToShow(BigRaceShow tournament, params Team[] teams)
        {
            if (positionOfPerson == PositionOfPerson.организатор)
            {
                foreach (Team team in teams)
                {
                    tournament.AddTeamToTeamsList(team);
                }
            }
        }

        /// <summary>
        /// Метод, позволяющий организатору добавить игру в шоу.
        /// </summary>
        /// <param name="tournament"> Шоу Большие гонки. </param>
        /// <param name="games"> Игра. </param>
        public void AddingGameToToShow(BigRaceShow tournament, params Game[] games)
        {
            if (positionOfPerson == PositionOfPerson.организатор)
            {
                foreach (Game game in games)
                {
                    tournament.AddGameToShow(game);
                }
            }
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Person.
        /// </summary>
        /// <param name="personName"> Имя человека. </param>
        /// <param name="positionOfPerson"> Должность человека. </param>
        public Person(string personName, PositionOfPerson positionOfPerson)
        {
            this.personName = personName;
            this.positionOfPerson = positionOfPerson;
        }
        #endregion
    }
}
