using System;

namespace Решение_задач
{
    class Program
    {
        static void Main()
        {
            // Программа создает команды, игры и начинает шоу Большие гонки.
            Console.WriteLine("{0, 91}", "Программа создает команды, игры и начинает шоу Большие гонки\n");

            #region Команда России
            Person Alexander = new Person("Александр", PositionOfPerson.игрок);
            Person Alexei = new Person("Алексей", PositionOfPerson.игрок);
            Person Andrey = new Person("Андрей", PositionOfPerson.игрок);
            Person Boris = new Person("Борис", PositionOfPerson.игрок);
            Person Vasiliy = new Person("Василий", PositionOfPerson.игрок);
            Person Gleb = new Person("Глеб", PositionOfPerson.игрок);
            Person Denis = new Person("Денис", PositionOfPerson.игрок);
            Person Eugene = new Person("Евгений", PositionOfPerson.игрок);
            Person Ivan = new Person("Иван", PositionOfPerson.игрок);
            Person Ilya = new Person("Илья", PositionOfPerson.игрок);
            Person Kirill = new Person("Кирилл", PositionOfPerson.игрок);
            Person Makar = new Person("Макар", PositionOfPerson.игрок);
            Person Nikita = new Person("Никита", PositionOfPerson.игрок);
            Person Oleg = new Person("Олег", PositionOfPerson.игрок);
            Person Paul = new Person("Павел", PositionOfPerson.игрок);

            Team russianTeam = new Team("Россия", Alexander, Alexei, Andrey, Boris, Vasiliy, Gleb, Denis, Eugene, Ivan, Ilya, Kirill, Makar, Nikita, Oleg, Paul);
            #endregion

            #region Команда Франции
            Person Andre = new Person("Андре", PositionOfPerson.игрок);
            Person Arno = new Person("Арно", PositionOfPerson.игрок);
            Person Gustave = new Person("Гюстав", PositionOfPerson.игрок);
            Person David = new Person("Дэвид", PositionOfPerson.игрок);
            Person Gerard = new Person("Жерар", PositionOfPerson.игрок);
            Person Joseph = new Person("Жозеф", PositionOfPerson.игрок);
            Person Yvon = new Person("Ивон", PositionOfPerson.игрок);
            Person Karin = new Person("Карин", PositionOfPerson.игрок);
            Person Colette = new Person("Колетт", PositionOfPerson.игрок);
            Person Lambert = new Person("Ламберт", PositionOfPerson.игрок);
            Person Luke = new Person("Люк", PositionOfPerson.игрок);
            Person Mark = new Person("Марк", PositionOfPerson.игрок);
            Person Marseilles = new Person("Vfhctkm", PositionOfPerson.игрок);
            Person Nadine = new Person("Надин", PositionOfPerson.игрок);
            Person Nicole = new Person("Николь", PositionOfPerson.игрок);

            Team frenchTeam = new Team("Франция", Andre, Arno, Gustave, David, Gerard, Joseph, Yvon, Karin, Colette, Lambert, Luke, Mark, Marseilles, Nadine, Nicole);
            #endregion

            #region Команда Китая
            Person Wei = new Person("Вэй", PositionOfPerson.игрок);
            Person Xiuying = new Person("Сюин", PositionOfPerson.игрок);
            Person Minh = new Person("Минь", PositionOfPerson.игрок);
            Person Jing = new Person("Цзин", PositionOfPerson.игрок);
            Person Lei = new Person("Лэй", PositionOfPerson.игрок);
            Person Yun = new Person("Юн", PositionOfPerson.игрок);
            Person Ciao = new Person("Чао", PositionOfPerson.игрок);
            Person Xiulan = new Person("Сюлань", PositionOfPerson.игрок);
            Person Qiang = new Person("Цян", PositionOfPerson.игрок);
            Person Gan = new Person("Ган", PositionOfPerson.игрок);
            Person Guiyin = new Person("Гуйин", PositionOfPerson.игрок);
            Person Jie = new Person("Цзе", PositionOfPerson.игрок);
            Person Tao = new Person("Тао", PositionOfPerson.игрок);
            Person Lee = new Person("Ли", PositionOfPerson.игрок);
            Person Fan = new Person("Фан", PositionOfPerson.игрок);

            Team chineseTeam = new Team("Китай", Wei, Xiuying, Minh, Jing, Lei, Yun, Ciao, Xiulan, Qiang, Gan, Guiyin, Jie, Tao, Lee, Fan);
            #endregion

            #region Команда Казахстана
            Person Abai = new Person("Абай", PositionOfPerson.игрок);
            Person Azamat = new Person("Азамат", PositionOfPerson.игрок);
            Person Aidar = new Person("Айдар", PositionOfPerson.игрок);
            Person Bakir = new Person("Бакир", PositionOfPerson.игрок);
            Person Gabit = new Person("Габит", PositionOfPerson.игрок);
            Person Daniyar = new Person("Данияр", PositionOfPerson.игрок);
            Person Erden = new Person("Ерден", PositionOfPerson.игрок);
            Person Jean = new Person("Жан", PositionOfPerson.игрок);
            Person Zhupar = new Person("Жупар", PositionOfPerson.игрок);
            Person Zhangir = new Person("Жангир", PositionOfPerson.игрок);
            Person Diyar = new Person("Дияр", PositionOfPerson.игрок);
            Person Danesh = new Person("Данеш", PositionOfPerson.игрок);
            Person Gafu = new Person("Гафу", PositionOfPerson.игрок);
            Person Bokey = new Person("Бокей", PositionOfPerson.игрок);
            Person Bates = new Person("Батес", PositionOfPerson.игрок);

            Team kazakhstanTeam = new Team("Казахстан", Abai, Azamat, Aidar, Bakir, Gabit, Daniyar, Erden, Jean, Zhangir, Zhupar, Diyar, Danesh, Gafu, Bokey, Bates);
            #endregion

            Person OlivierGagnan = new Person("Оливье Ганьян", PositionOfPerson.организатор);
            BigRaceShow bigRaceShow = new BigRaceShow();
            OlivierGagnan.AddingTeamToShow(bigRaceShow, russianTeam, chineseTeam, kazakhstanTeam, frenchTeam);

            Game beach = new Game("Пляж");
            Game mousetrap = new Game("Мышеловка");
            Game sea = new Game("Море");
            Game fishing = new Game("Рыбалка");
            Game postmen = new Game("Почтальоны");
            Game slide = new Game("Горка");

            OlivierGagnan.AddingGameToToShow(bigRaceShow, beach, mousetrap, sea, fishing, postmen, slide);

            bigRaceShow.StartShow();
            Console.WriteLine();
            
            Game rock = new Game("Скала");
            OlivierGagnan.AddingGameToToShow(bigRaceShow, rock);
            bigRaceShow.StartShow();

        }
    }
}
