namespace Hyundai.Api.Models
{
    public class Product
    {
        public int id { get; set; }
        public string? title { get; set; }
        public string? description { get; set; }

        public string? artist { get; set; }
        public string? image1 {get; set;}
        public string? image2 {get; set;}
        public bool isFree {  get; set; }
        public string? accentColor { get; set; } 
        public string? textColor { get; set; }
        public string? backgroundColor { get; set; }
        public string? feature_order { get; set; }

        public string? price { get; set; }



    }
}
