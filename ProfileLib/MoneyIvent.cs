using System;
using System.Collections.Generic;

namespace AppData
{
    public class MoneyIvent
    {
        /* Класс планируется использовать для сохранения данных о транзакциях пользователя:
         * * поступлениях
         * * списаниях
         *
         * кроме того, ведем учет баланса по счетам пользователя
         */
        
        //для всех
        public string Title = null;// название
        
        public double Money = 0;// денежная сумма (+или-)

        public string Account = null;// счет зачисления/списания
        
        //вариативная смена регулярности транзакции
        public int Regularity = 0;// как часто? (кол-во дней)
        
        //вариативная смена даты транзакции
        public DateTime Date = DateTime.Today.Date;//дата денежного ивента
        
        //для расходов
        public string Category = null;//категория (для трат)

        public MoneyIvent(){}
        
        public MoneyIvent(string title, double income, string account)//доход разовый
        {
            Title = title;
            Money = income;
            Account = account;
        }
        
        public MoneyIvent(string title, double income, string account, DateTime date)//доход разовый др дата
        {
            Title = title;
            Money = income;
            Account = account;
            Date = date;
        }
        
        public MoneyIvent(string title, double income, string account, int regularity)//доход регулярный
        {
            Title = title;
            Money = income;
            Account = account;
            Regularity = regularity;
        }
        
        public MoneyIvent(string title, double income, string account, int regularity, DateTime date)//доход регулярный др дата
        {
            Title = title;
            Money = income;
            Account = account;
            Regularity = regularity;
            Date = date;
        }
        
        public MoneyIvent(string title, double spend, string account, string category)//расход разовый
        {
            Title = title;
            Money = spend;
            Account = account;
            Category = category;
        }

        public MoneyIvent(string title, double spend, string account, int regularity, string category)//расход регулярный
        {
            Title = title;
            Money = spend;
            Account = account;
            Regularity = regularity;
            Category = category;
        }
          
        public MoneyIvent(string title, double spend, string account, string category, DateTime date)//расход разовый др дата
        {
            Title = title;
            Money = spend;
            Account = account;
            Category = category;
            Date = date;
        }
        
        public MoneyIvent(string title, double spend, string account, string category, int regularity, DateTime date)//расход регулярный др дата
        {
            Title = title;
            Money = spend;
            Account = account;
            Regularity = regularity;
            Category = category;
            Date = date;
        }
        
        public override string ToString()
        {
            // "Название:1000:сбер:7:Продукты:02/25/2022;"
            return $"{Title}:{Money}:{Account}:{Regularity}:{Category}:{Date};";
        }
        
        public static MoneyIvent FromString(string data)
        {
            //перевод данных из строки формата: (предварительный сплит по ";")
            //  Название:1000:сбер:7:Продукты:02/25/2022"
            //в обьект класса
            
            MoneyIvent ivent = new MoneyIvent();
            
            string[] array = data.Split(':');
            
            ivent.Title = array[0];
            ivent.Money = double.Parse(array[1]);
            ivent.Account = array[2];
            ivent.Regularity = int.Parse(array[3]);
            ivent.Category = array[4];
            ivent.Date = DateTime.Parse(array[5]);

            return ivent;
        }
        
    }
}
/*
 
Доход:

1. Название
2. Сумма
3. Счет поступления
4. Регулярность (нед/2нед/мес/6мес/год)
5. Дата (сейчас/юзер ввод)

Расход:

1. Название
2. Категория
3. Сумма
4. Счет списания
5. Регулярность (1раз/нед/2нед/мес/6мес/год)
6. Дата (сейчас/юзер ввод)

Счета хранения средств

Цели

1. Название
2. Сумма
3. Срок (начало + конец)       //нужна динамика?или только цифры?
4. Регулярность пополнения (нед/2нед/мес/6мес/год) 
 */