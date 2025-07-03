using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03592))]
public class S03592Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03592();
        Assert.That(sut.FindCoins([0, 1, 0, 2, 0, 3, 0, 4, 0, 5]), Is.EqualTo([2, 4, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03592();
        Assert.That(sut.FindCoins([1, 2, 2, 3, 4]), Is.EqualTo([1, 2, 5]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03592();
        Assert.That(sut.FindCoins([1, 2, 3, 4, 15]), Is.Empty);
    }
}