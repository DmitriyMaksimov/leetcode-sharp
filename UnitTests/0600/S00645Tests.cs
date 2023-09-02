using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00645Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00645();
        sut.FindErrorNums(new[] {1, 2, 2, 4}).Should().Equal(2, 3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00645();
        sut.FindErrorNums(new[] {1, 1}).Should().Equal(1, 2);
    }

}