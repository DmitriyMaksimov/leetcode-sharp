using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01446Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01446();
        Assert.That(sut.MaxPower("leetcode"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01446();
        Assert.That(sut.MaxPower("abbcccddddeeeeedcba"), Is.EqualTo(5));
    }
}