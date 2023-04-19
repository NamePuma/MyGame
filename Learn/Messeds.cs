using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    public static class Messeds
    {
        public const string HELLO = "Добро пожаловать в приложение Oleshkina!!!";
        public const string SELECTED = "|||   ";
        public const string CREATE = "Создайте своего персонажа";
        public const string Name = "Придумайте имя: ";
        public const char Man = 'М';
        public const char Woman = 'Ж';
        public const string AGE = "Возраст персонажу: ";
        public const string SEX = "Выбирете пол...";
        public const string BORDER = "-------------------------------";
        public const string EXCEPTIONNUMBER = "Значение должно быть целочисленым";
        public const string FINISHCREATEPERSON = "Ваш персонаж...";
        public const string NEXT = "Далее";
        public const string CHANGE = "Изменить";
        public const string CORRENTROOM = "Текущая страница: ";
        public const string CORRENTPERSON = "Текущай персонаж: ";
        public const string OBJECTROOM = "Объекты в комнате: ";
        public const string NEXTROOM = "Перейти в...";
        public const string WHEREGO = "Куда переходим?";
        public const string SOUTH = "Юг";
        public const string NORTH = "Север";
        public const string WEST = "Запад";
        public const string EAST = "Восток";
        public const string CENTER = "Центр";
        public const string GOAGAIN = "Нажмите клавиду чтобы продолжить";
        public const string ANOTERLOCATION = "Другая локация";
        private static string choiceStart = "Начать";
        private static string choiceExit = "Выйти";

        public static string ChooseStart { get => choiceStart; set => choiceStart = value; }
        public static string ChooseExit { get => choiceExit; set => choiceExit = value; }
    }
}
