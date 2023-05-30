namespace WebApplication5
{
    public class Checkout
    {
        private Dictionary<char, int> prices;
        private Dictionary<char, (int quantity, int price)> offers;

        public Checkout()
        {
            prices = new Dictionary<char, int>
            {
                { 'A', 50 },
                { 'B', 30 },
                { 'C', 20 },
                { 'D', 15 }
            };

            offers = new Dictionary<char, (int quantity, int price)>
            {
                { 'A', (3, 130) },
                { 'B', (2, 45) }
            };
        }

        public int CalculateTotalCost(string skus)
        {
            Dictionary<char, int> itemCounts = new Dictionary<char, int>();

            foreach (char sku in skus)
            {
                if (!prices.ContainsKey(sku))
                    throw new ArgumentException($"Invalid SKU: {sku}");

                if (!itemCounts.ContainsKey(sku))
                    itemCounts[sku] = 0;

                itemCounts[sku]++;
            }

            int totalPrice = 0;

            foreach (var item in itemCounts)
            {
                char sku = item.Key;
                int quantity = item.Value;
                int price = prices[sku];

                if (offers.ContainsKey(sku))
                {
                    var offer = offers[sku];
                    int offerQuantity = offer.quantity;
                    int offerPrice = offer.price;

                    int numOffers = quantity / offerQuantity;
                    int remainingItems = quantity % offerQuantity;

                    totalPrice += numOffers * offerPrice;
                    totalPrice += remainingItems * price;
                }
                else
                {
                    totalPrice += quantity * price;
                }
            }

            return totalPrice;
        }
    }
}