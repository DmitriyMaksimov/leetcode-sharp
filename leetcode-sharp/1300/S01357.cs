namespace leetcode_sharp;

// 1357. Apply Discount Every n Orders
// https://leetcode.com/problems/apply-discount-every-n-orders
public class S01357
{
    public class Cashier
    {
        private int _count = 0;
        private readonly int _n;
        private readonly int _discount;
        private readonly Dictionary<int, int> _prices = [];

        public Cashier(int n, int discount, int[] products, int[] prices)
        {
            _n = n;
            _discount = discount;

            for (var i = 0; i < products.Length; ++i)
            {
                _prices.Add(products[i], prices[i]);
            }
        }

        public double GetBill(int[] product, int[] amount)
        {
            var total = 0.0;
            
            for (var i = 0; i < product.Length; ++i)
            {
                total += _prices[product[i]] * amount[i];
            }

            return total * (++_count % _n == 0 ? 1 - _discount / 100.0 : 1);
        }
    }
}