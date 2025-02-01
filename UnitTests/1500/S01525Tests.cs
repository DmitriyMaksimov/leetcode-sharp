using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01525Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01525();
        Assert.That(sut.NumSplits("aacaba"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01525();
        Assert.That(sut.NumSplits("abcd"), Is.EqualTo(1));
    }
}
