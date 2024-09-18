using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00179Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00179();
        sut.LargestNumber([10, 2]).Should().Be("210");
    }

    [Test]
    public void T2()
    {
        var sut = new S00179();
        sut.LargestNumber([3, 30, 34, 5, 9]).Should().Be("9534330");
    }

    [Test]
    public void T3()
    {
        var sut = new S00179();
        sut.LargestNumber([0, 0]).Should().Be("0");
    }
}
