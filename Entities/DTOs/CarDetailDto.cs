using Core.Entities.Abstract;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public CarDetailDto(string brandName, string colorName, decimal dailyPrice)
        {
            BrandName = brandName;
            ColorName = colorName;
            DailyPrice = dailyPrice;
        }
        public CarDetailDto()
        {

        }

        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
