using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01319Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01319();
        Assert.That(sut.MakeConnected(4, new[] {new[] {0, 1}, new[] {0, 2}, new[] {1, 2}}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01319();
        Assert.That(sut.MakeConnected(6, new[] {new[] {0, 1}, new[] {0, 2}, new[] {0, 3}, new[] {1, 2}}), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01319();
        Assert.That(sut.MakeConnected(6, new[] {new[] {0, 1}, new[] {0, 2}, new[] {0, 3}, new[] {1, 2}, new[] {1, 3}}), Is.EqualTo(2));
    }
}