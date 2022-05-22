namespace AppData
{
    public class Account
    {
        //банковские счета пользователя названия и балансы
        public string Title = null;
        public double Balance = 0;

        public Account(){}
        public Account(string title, double balance)
        {
            Title = title;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"{Title}:{Balance};";
        }
        
        public static Account FromString(string data)
        {
            //перевод данных из строки формата: (предварительный сплит по ";")
            //  сбер:700"
            //в обьект класса
            
            Account acc = new Account();
            
            string[] array = data.Split(':');
            
            acc.Title = array[0];
            acc.Balance = double.Parse(array[1]);

            return acc;
        }
    }
}