using System.Collections.Generic;

namespace Решение_задач
{
    /// <summary>
    /// Класс, описывающий команду, которая участвует в турнире.
    /// </summary>
    class Team
    {
        #region Поля
        readonly string teamCountry;
        readonly List<Person> teamMembers =  new List<Person>();
        #endregion

        #region Конструктор
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса Team.
        /// </summary>
        /// <param name="teamCountry"> Страна команды. </param>
        /// <param name="teamMembers"> Учасники команды. </param>
        public Team(string teamCountry, params Person[] teamMembers)
        {
            this.teamCountry = teamCountry;
            
            foreach (Person player in teamMembers)
            {
                this.teamMembers.Add(player);
            }
        }
        #endregion
    }
}
