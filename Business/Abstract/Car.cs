namespace Business.Abstract
{
    public class Car
    {

        public int BrandId { get; set; }
        public int Id { get; set; }
        public int ColorId { get; internal set; }
        public int DailyPrice { get; internal set; }
    }
}