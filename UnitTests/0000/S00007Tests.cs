using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00007Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00007();
        sut.Reverse(123).Should().Be(321);
    }

    [Test]
    public void T2()
    {
        var sut = new S00007();
        sut.Reverse(-123).Should().Be(-321);
    }

    [Test]
    public void T3()
    {
        var sut = new S00007();
        sut.Reverse(120).Should().Be(21);
    }
}
