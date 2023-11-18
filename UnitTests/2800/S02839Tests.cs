using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02839Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02839();
        sut.CanBeEqual("abcd", "cdab").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02839();
        sut.CanBeEqual("abcd", "dacb").Should().BeFalse();
    }
}