using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01357Tests
{
    [Test]
    public void T1()
    {
        var cashier = new S01357.Cashier(3, 50, [1, 2, 3, 4, 5, 6, 7], [100, 200, 300, 400, 300, 200, 100]);
        cashier.GetBill([1,2],[1,2]);                        // return 500.0. 1st customer, no discount.
                                                             // bill = 1 * 100 + 2 * 200 = 500.
        cashier.GetBill([3,7],[10,10]);                      // return 4000.0. 2nd customer, no discount.
                                                             // bill = 10 * 300 + 10 * 100 = 4000.
        cashier.GetBill([1,2,3,4,5,6,7],[1,1,1,1,1,1,1]);    // return 800.0. 3rd customer, 50% discount.
                                                             // Original bill = 1600
                                                             // Actual bill = 1600 * ((100 - 50) / 100) = 800.
        cashier.GetBill([4],[10]);                           // return 4000.0. 4th customer, no discount.
        cashier.GetBill([7,3],[10,10]);                      // return 4000.0. 5th customer, no discount.
        cashier.GetBill([7,5,3,1,6,4,2],[10,10,10,9,9,9,7]); // return 7350.0. 6th customer, 50% discount.
                                                             // Original bill = 14700, but with
                                                             // Actual bill = 14700 * ((100 - 50) / 100) = 7350.
        cashier.GetBill([2,3,5],[5,3,2]);                    // return 2500.0.  7th customer, no discount.
    }
}