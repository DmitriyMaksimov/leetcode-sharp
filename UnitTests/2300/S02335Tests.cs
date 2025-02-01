using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02335Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02335();
        Assert.That(sut.FillCups(new[] {1, 4, 2}), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02335();
        Assert.That(sut.FillCups(new[] {5, 4, 4}), Is.EqualTo(7));
    }

    [Test]
    public void T3()
    {
        var sut = new S02335();
        Assert.That(sut.FillCups(new[] {5, 0, 0}), Is.EqualTo(5));
    }
}