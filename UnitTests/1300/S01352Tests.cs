using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01352Tests
{
    [Test]
    public void T1()
    {
        var productOfNumbers = new S01352.ProductOfNumbers();
        productOfNumbers.Add(3); // [3]
        productOfNumbers.Add(0); // [3,0]
        productOfNumbers.Add(2); // [3,0,2]
        productOfNumbers.Add(5); // [3,0,2,5]
        productOfNumbers.Add(4); // [3,0,2,5,4]
        Assert.That(productOfNumbers.GetProduct(2), Is.EqualTo(20)); // The product of the last 2 numbers is 5 * 4 = 20
        Assert.That(productOfNumbers.GetProduct(3), Is.EqualTo(40)); // The product of the last 3 numbers is 2 * 5 * 4 = 40
        Assert.That(productOfNumbers.GetProduct(4), Is.EqualTo(0)); // The product of the last 4 numbers is 0 * 2 * 5 * 4 = 0
        productOfNumbers.Add(8); // [3,0,2,5,4,8]
        Assert.That(productOfNumbers.GetProduct(2), Is.EqualTo(32)); // The product of the last 2 numbers is 4 * 8 = 32
    }
}
