namespace Project_ShoppingCart_PRN211.Models
{
    public class Cart
    {
        private int quantity;
        private Shoe shoes;

        public Shoe Shoes
        {
            get { return shoes; }
            set { shoes = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

    }
}
