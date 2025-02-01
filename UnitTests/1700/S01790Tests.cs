using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01790Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01790();
        Assert.That(sut.AreAlmostEqual("bank", "kanb"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01790();
        Assert.That(sut.AreAlmostEqual("attack", "defend"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01790();
        Assert.That(sut.AreAlmostEqual("kelb", "kelb"), Is.True);
    }
}
