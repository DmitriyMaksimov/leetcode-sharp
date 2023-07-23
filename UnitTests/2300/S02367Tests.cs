using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02367Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02367();
        sut.ArithmeticTriplets(new[] {0, 1, 4, 6, 7, 10}, 3).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02367();
        sut.ArithmeticTriplets(new[] {4, 5, 6, 7, 8, 9}, 2).Should().Be(2);
    }
}