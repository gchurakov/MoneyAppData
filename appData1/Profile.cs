using System.Collections.Generic;
using AppData;

namespace AppData1
{
    public class Profile
    {
        //профиль юзера со всеми данными
        public List<MoneyIvent> Transactions = new List<MoneyIvent>();
        public List<Goal> Goals = new List<Goal>();
        public List<Category> Categories = new List<Category>();
        public List<Account> Accounts = new List<Account>();

        public double Balance
        {
            get
            {
                double sum = 0;
                foreach (Account account in Accounts)
                    sum += account.Balance;
                return sum;
            }
        }
    }
}