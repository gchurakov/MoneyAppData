using System.Collections.Generic;
using AppData;
using Newtonsoft.Json;

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

        public void ToJson(string jsonFileName = "default_name.json")
        {
            // сохранение данных
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            FileStream fs = new FileStream(jsonFileName, FileMode.OpenOrCreate);
        }
        
        public static Profile FromJson(string jsonFileName = "default_name.json")
        {
            // чтение данных
            Profile profile;
            using (var reader = new StreamReader(jsonFileName))
            {
                string json = reader.ReadToEnd();
                profile = JsonConvert.DeserializeObject<Profile>(json);
            }
            return profile;
        }
    }
}