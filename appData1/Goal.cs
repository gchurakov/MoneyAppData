using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AppData1
{
    [XmlType(TypeName = "goal")]
    public class Goal
    {
        // цели / копилки / сборы денег
        public string Title{ get; set; } = null;// название
        
        public double MoneyGoal{ get; set; } = 0;// цель денежная сумма 
        public double MoneyFounded{ get; set; } = 0;// собранная денежная сумма 
        
        public string Vault{ get; set; } = null;// счета хранения средств
        
        public DateTime Start { get; set; }= DateTime.Today.Date;//начало
        public DateTime Finish { get; set; }= default;//конец
        
        public int Regularity { get; set; }= 0;// как часто? (кол-во дней)
        
        public bool IsFounded{ get; set; }// деньги собраны

        public Goal()
        {
            IsFounded = MoneyGoal < MoneyFounded;
        }

        public Goal(string title, double moneyGoal, DateTime finish)
        {//старт сегодня с 0
            Title = title;
            MoneyGoal = moneyGoal;
            Finish = finish;
            IsFounded = MoneyGoal < MoneyFounded;
        }
        
        public Goal(string title, double moneyGoal, double moneyFounded, DateTime finish)
        {//старт сегодня с суммы
            Title = title;
            MoneyGoal = moneyGoal;
            MoneyFounded = moneyFounded;
            Finish = finish;
            IsFounded = MoneyGoal < MoneyFounded;
        }
        
        public Goal(string title, double moneyGoal, DateTime start, DateTime finish)
        {//старт  с 0
            Title = title;
            MoneyGoal = moneyGoal;
            Start = start;
            Finish = finish;
            IsFounded = MoneyGoal < MoneyFounded;
        }
        
        public Goal(string title, double moneyGoal, double moneyFounded, DateTime start, DateTime finish)
        {//старт с суммы
            Title = title;
            MoneyGoal = moneyGoal;
            Start = start;
            Finish = finish;
            IsFounded = MoneyGoal < MoneyFounded;
        }
        
        public Goal(string title, double moneyGoal, DateTime finish, int regularity)
        {//старт сегодня с 0
            Title = title;
            MoneyGoal = moneyGoal;
            Finish = finish;
            Regularity = regularity;
            IsFounded = MoneyGoal < MoneyFounded;
        }
        
        public Goal(string title, double moneyGoal, double moneyFounded, DateTime finish, int regularity)
        {//старт сегодня с суммы
            Title = title;
            MoneyGoal = moneyGoal;
            MoneyFounded = moneyFounded;
            Finish = finish;
            Regularity = regularity;
            IsFounded = MoneyGoal < MoneyFounded;
        }
        
        public Goal(string title, double moneyGoal, DateTime start, DateTime finish, int regularity)
        {//старт  с 0
            Title = title;
            MoneyGoal = moneyGoal;
            Start = start;
            Finish = finish;
            Regularity = regularity;
            IsFounded = MoneyGoal < MoneyFounded;
        }

        public Goal(string title, double moneyGoal, double moneyFounded, DateTime start, DateTime finish, int regularity)
        {
            //старт с суммы
            Title = title;
            MoneyGoal = moneyGoal;
            Start = start;
            Finish = finish;
            Regularity = regularity;
            IsFounded = MoneyGoal < MoneyFounded;
        }

        public override string ToString()
        {
            // "Название:1000:12:сбер:02/25/2022:12/31/2022:7:false;"
            return $"{Title}:{MoneyGoal}:{MoneyFounded}:{Vault}:{Start.ToString()}:{Finish.ToString()}:{Regularity}:{IsFounded};";
        }

        public static Goal FromString(string data)
        {
            //перевод данных из строки формата: (предварительный сплит по ";")
            //  "Название:1000:12:сбер:02/25/2022:12/31/2022:7:false"
            //в обьект класса
            
            Goal goal = new Goal();
            
            string[] array = data.Split(':');
            
            goal.Title = array[0];
            goal.MoneyGoal = double.Parse(array[1]);
            goal.MoneyFounded = double.Parse(array[2]);
            goal.Vault = array[3];
            goal.Start = DateTime.Parse(array[4]);
            goal.Finish = DateTime.Parse(array[5]);
            goal.Regularity = int.Parse(array[6]);
            goal.IsFounded = bool.Parse(array[7]);

            return goal;
        }
    }
}