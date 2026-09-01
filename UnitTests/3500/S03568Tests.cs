using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03568))]
public class S03568Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03568();
        Assert.That(sut.MinMoves(["LS", "RL"], 4), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03568();
        Assert.That(sut.MinMoves(["S.", "XL"], 2), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03568();
        Assert.That(sut.MinMoves(["L.S", "RXL"], 3), Is.EqualTo(-1));
    }
}