using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03551))]
public class S03551Test
{
    [Test]
    public void T1()
    {
        var sut = new S03551();
        Assert.That(sut.MinSwaps([22, 14, 33, 7]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S03551();
        Assert.That(sut.MinSwaps([18, 43, 34, 16]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03551();
        Assert.That(sut.MinSwaps([37, 100]), Is.EqualTo(1));
    }
}
