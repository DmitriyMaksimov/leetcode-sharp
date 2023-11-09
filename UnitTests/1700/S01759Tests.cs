using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01759Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01759();
        sut.CountHomogenous("abbcccaa").Should().Be(13);
    }

    [Test]
    public void T2()
    {
        var sut = new S01759();
        sut.CountHomogenous("xy").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01759();
        sut.CountHomogenous("zzzzz").Should().Be(15);
    }
}