using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01915Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01915();
        sut.WonderfulSubstrings("aba").Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01915();
        sut.WonderfulSubstrings("aabb").Should().Be(9);
    }

    [Test]
    public void T3()
    {
        var sut = new S01915();
        sut.WonderfulSubstrings("he").Should().Be(2);
    }
}