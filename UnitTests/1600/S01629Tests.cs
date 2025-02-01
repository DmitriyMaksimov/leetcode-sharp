using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01629Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01629();
        Assert.That(sut.SlowestKey(new[] {9, 29, 49, 50}, "cbcd"), Is.EqualTo('c'));
    }

    [Test]
    public void T2()
    {
        var sut = new S01629();
        Assert.That(sut.SlowestKey(new[] {12, 23, 36, 46, 62}, "spuda"), Is.EqualTo('a'));
    }
}