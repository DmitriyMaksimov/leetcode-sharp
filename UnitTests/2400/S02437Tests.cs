using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02437Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02437();
        sut.CountTime("?5:00").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02437();
        sut.CountTime("0?:0?").Should().Be(100);
    }

    [Test]
    public void T3()
    {
        var sut = new S02437();
        sut.CountTime("??:??").Should().Be(1440);
    }
}