using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03442Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03442();
        Assert.That(sut.MaxDifference("aaaaabbc"), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03442();
        Assert.That(sut.MaxDifference("abcabcab"), Is.EqualTo(1));
    }
}
