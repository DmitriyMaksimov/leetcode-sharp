using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00844Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00844();
        sut.BackspaceCompare("ab#c", "ad#c").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00844();
        sut.BackspaceCompare("ab##", "c#d#").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S00844();
        sut.BackspaceCompare("a#c", "b").Should().BeFalse();
    }
}