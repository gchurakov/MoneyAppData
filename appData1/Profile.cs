using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace AppData1
{
    public class Profile
    {
        //профиль юзера со всеми данными
        public string UserName{ get; set; } = null;
        public int PinCode{ get; set; } = 0;//пин код
        
        public List<MoneyIvent> Transactions{ get; set; } = new List<MoneyIvent>();
        public List<Goal> Goals{ get; set; } = new List<Goal>();
        public List<Category> Categories{ get; set; } = new List<Category>();
        public List<Account> Accounts{ get; set; } = new List<Account>();

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

        public Profile(){}

        public Profile(string name)
        {
            UserName = name;
        }
        public void ToJson(string jsonFileName = "default_name.json")
        {
            // сохранение данных
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            using (var writer = new StreamWriter(jsonFileName))
            {
                writer.Write(json);
            }
        }
        
        public static Profile FromJson(string jsonFileName = "default_name.json")
        {
            // чтение данных
            string json;
            try
            {
                using (var reader = new StreamReader(jsonFileName))
                {
                    json = reader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<Profile>(json);
            }
            catch (IOException e)
            {
                Console.WriteLine($"Ошибка при чтении файла! {e.Message}");
                return new Profile();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Ошибка при чтении файла! {e.Message}");
                return new Profile();
            }
        }
    }
}