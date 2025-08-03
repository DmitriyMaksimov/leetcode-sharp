using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02932Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02932();
        Assert.That(sut.MaximumStrongPairXor([1, 2, 3, 4, 5]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02932();
        Assert.That(sut.MaximumStrongPairXor([10, 100]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S02932();
        Assert.That(sut.MaximumStrongPairXor([5, 6, 25, 30]), Is.EqualTo(7));
    }
}