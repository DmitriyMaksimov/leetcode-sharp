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
        productOfNumbers.GetProduct(2).Should().Be(20); // The product of the last 2 numbers is 5 * 4 = 20
        productOfNumbers.GetProduct(3).Should().Be(40); // The product of the last 3 numbers is 2 * 5 * 4 = 40
        productOfNumbers.GetProduct(4).Should().Be(0); // The product of the last 4 numbers is 0 * 2 * 5 * 4 = 0
        productOfNumbers.Add(8); // [3,0,2,5,4,8]
        productOfNumbers.GetProduct(2).Should().Be(32); // The product of the last 2 numbers is 4 * 8 = 32
    }
}
