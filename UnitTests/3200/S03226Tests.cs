using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03226Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03226();
        Assert.That(sut.MinChanges(13, 4), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03226();
        Assert.That(sut.MinChanges(21, 21), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03226();
        Assert.That(sut.MinChanges(14, 13), Is.EqualTo(-1));
    }
}