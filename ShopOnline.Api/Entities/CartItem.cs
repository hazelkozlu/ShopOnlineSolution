namespace ShopOnline.Api.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId  { get; set; }
        // the cart entity has a one to many relationship with the cart item entity
        public int ProductId { get; set; }
        public int Qty { get; set; }

    }
}
