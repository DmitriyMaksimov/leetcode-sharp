using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01974Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01974();
        sut.MinTimeToType("abc").Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S01974();
        sut.MinTimeToType("bza").Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S01974();
        sut.MinTimeToType("zjpc").Should().Be(34);
    }
}