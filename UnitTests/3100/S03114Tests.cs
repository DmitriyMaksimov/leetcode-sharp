using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03114Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03114();
        sut.FindLatestTime("1?:?4").Should().Be("11:54");
    }

    [Test]
    public void T2()
    {
        var sut = new S03114();
        sut.FindLatestTime("0?:5?").Should().Be("09:59");
    }

    [Test]
    public void T3()
    {
        var sut = new S03114();
        sut.FindLatestTime("?7:5?").Should().Be("07:59");
    }
}