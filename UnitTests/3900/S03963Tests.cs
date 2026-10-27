using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03963))]
public class S03963Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03963();
        Assert.That(sut.CreateGrid(2, 3), Is.EqualTo(["...", "##."]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03963();
        Assert.That(sut.CreateGrid(3, 3), Is.EqualTo(["...", "##.", "##."]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03963();
        Assert.That(sut.CreateGrid(1, 4), Is.EqualTo(["...."]));
    }
}