using AppData1;

namespace appData1
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Profile testProfile = new Profile("Алексей");
            testProfile.Accounts.Add(new Account("Мульти Карта ВТБ", 2095));
            testProfile.Goals.Add(new Goal());
            testProfile.Categories.Add(new Category("Продукты", 5000));
            testProfile.Categories.Add(new Category("Одежда", 2900, 5150.30));
            testProfile.Transactions.Add(new MoneyIvent("Стипендия", 2095, "Мульти Карта ВТБ",
                new DateTime(2022, 4, 29)));
            testProfile.Transactions.Add(new MoneyIvent("Брюки", 5150.30, "Мульти Карта ВТБ"));
            
            testProfile.ToJson("file.json");

            Profile newTestProfile = Profile.FromJson("file.json");
            Console.WriteLine(newTestProfile == null);
            Console.WriteLine($"{newTestProfile.UserName} : {newTestProfile.Balance}");
        }
    }
}