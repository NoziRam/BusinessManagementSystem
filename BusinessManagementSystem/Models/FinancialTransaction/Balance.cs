using BusinessManagementSystem.Models.BaseEntityModels;

namespace BusinessManagementSystem.Models.FinancialTransaction
{
   
    public class Balance : BaseEntity
    {
        public double CurrentAssets { get; set; }
        public double CassacashRegister { get; set; }
        public double SavingMoney { get; set; }
        public double Debtors { get; set; }
        public double GoodsOnTheWay { get; set; }
        public double StockProducts { get; set; }
        public double FixedAssets { get; set; }
        public double Transport { get; set; }
        public double Equipment { get; set; }
        public double Building { get; set; }
        public double Liabilitiies { get; set; }
        public double ShortTermLiabilitiies { get; set; }
        public double LongTermLiabilitiies { get; set; }
        public double Capital { get; set; }
        public DateTime DateTime { get; set; }
      
    }
}
