using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerceApp.Models
{
    public class ShoppingCard
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<CardItem> CartItems { get; set; }

        [NotMapped]
        public double CartTotal { get; set; }
        [NotMapped]
        public string StripePaymentIntentId { get; set; }
        [NotMapped]
        public string ClientSecret { get; set; }
    }
}
