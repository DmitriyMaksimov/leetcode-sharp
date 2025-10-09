using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03494))]
public class S03494Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03494();
        Assert.That(sut.MinTime([1, 5, 2, 4], [5, 1, 4, 2]), Is.EqualTo(110));
    }

    [Test]
    public void T2()
    {
        var sut = new S03494();
        Assert.That(sut.MinTime([1, 1, 1], [1, 1, 1]), Is.EqualTo(5));
    }
}