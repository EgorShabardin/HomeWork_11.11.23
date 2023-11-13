using System;

namespace Тумаков___Лабораторная_работа__10
{
    /// <summary>
    /// Класс, реализующий шифровку и дешифровку строк, выполняя замену каждой буквы, стоящей в алфавите на i-й позиции,
    /// на букву того же регистра, расположенную в алфавите на i-й позиции с конца алфавита.
    /// </summary>
    class BCipher : ICipher
    {
        #region Поля
        private string decodedMessage;
        private string codedMessage;
        #endregion

        #region Свойства
        /// <summary>
        /// Свойство, позволяющее получить сообщение (зашифрованное или расшифрованное).
        /// </summary>
        public string Message
        {
            get
            {
                if (decodedMessage != "")
                {
                    return decodedMessage;
                }
                else
                {
                    return codedMessage;
                }
            }
        }
        #endregion

        #region Методы
        public bool Encode()
        {
            if (codedMessage == "" && decodedMessage != "")
            {
                for (int i = 0; i < decodedMessage.Length; i++)
                {
                    char newLetter;

                    if (Char.IsLetter(decodedMessage[i]))
                    {
                        if (decodedMessage.ToLower()[i] >= 'а' && decodedMessage.ToLower()[i] <= 'я')
                        {
                            newLetter = (char)((int)'я' - ((int)decodedMessage.ToLower()[i] - (int)'а'));
                        }
                        else
                        {
                            newLetter = (char)((int)'z' - ((int)decodedMessage.ToLower()[i] - (int)'a'));
                        }

                        if (Char.IsUpper(decodedMessage[i]))
                        {
                            codedMessage += newLetter.ToString().ToUpper();
                        }
                        else
                        {
                            codedMessage += newLetter;
                        }
                    }
                    else
                    {
                        codedMessage += decodedMessage[i];
                    }
                }

                decodedMessage = "";
                return true;
            }

            return false;
        }

        public bool Decode()
        {
            if (codedMessage != "" && decodedMessage == "")
            {
                for (int i = 0; i < codedMessage.Length; i++)
                {
                    char newLetter;

                    if (Char.IsLetter(codedMessage[i]))
                    {
                        if (codedMessage.ToLower()[i] >= 'а' && codedMessage.ToLower()[i] <= 'я')
                        {
                            newLetter = (char)(((int)'я' - (int)codedMessage.ToLower()[i]) + (int)'а');
                        }
                        else
                        {
                            newLetter = (char)(((int)'z' - (int)codedMessage.ToLower()[i]) + (int)'a');
                        }

                        if (Char.IsUpper(codedMessage[i]))
                        {
                            decodedMessage += newLetter.ToString().ToUpper();
                        }
                        else
                        {
                            decodedMessage += newLetter;
                        }
                    }
                    else
                    {
                        decodedMessage += decodedMessage[i];
                    }
                }

                codedMessage = "";
                return true;
            }

            return false;
        }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Конструктор, позволяющий создать экземпляр класса BCipher.
        /// </summary>
        /// <param name="decodedMessage"> Сообщение, которое необходимо зашифровать. </param>
        public BCipher(string decodedMessage)
        {
            this.decodedMessage = decodedMessage;
            codedMessage = "";
        }
        #endregion
    }
}