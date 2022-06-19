namespace AppData1
{
    public class Category
    {
        // категория расходов и ее хорактеристики 
        
        public string Title { get; set; } = null;// название
        public double MoneyPlanned { get; set; }= 0;//запланировано
        public double MoneySpent { get; set; }= 0;//потрачено
        public double Balance{ get; set; }//остаток

        public Category()
        {
            Balance = MoneyPlanned - MoneySpent;
        }
        
        public Category(string title, double moneyPlanned)
        {
            Title = title;
            MoneyPlanned = moneyPlanned;
            Balance = MoneyPlanned - MoneySpent;
        }
        
        public Category(string title, double moneySpent, int isOnlySpent)
        {
            Title = title;
            MoneySpent = moneySpent;
            //Balance = MoneyPlanned - MoneySpent;
        }
        
        public Category(string title, double moneyPlanned, double moneySpent)
        {
            Title = title;
            MoneyPlanned = moneyPlanned;
            MoneySpent = moneySpent;
            Balance = MoneyPlanned - MoneySpent;
        }
        
        public override string ToString()
        {
            // "Название:1000:12:988;"
            return $"{Title}:{MoneyPlanned}:{MoneySpent}:{Balance};";
        }
        
    }
}