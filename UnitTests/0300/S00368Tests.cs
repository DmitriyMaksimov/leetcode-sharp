using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00368Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00368();
        sut.LargestDivisibleSubset([1, 2, 3]).Should().Equal(2, 1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00368();
        sut.LargestDivisibleSubset([1, 2, 4, 8]).Should().Equal(8, 4, 2, 1);
    }
}