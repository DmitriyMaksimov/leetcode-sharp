using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03020))]
public class S03020Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03020();
        Assert.That(sut.MaximumLength([5, 4, 1, 2, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03020();
        Assert.That(sut.MaximumLength([1, 3, 2, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03020();
        Assert.That(
            sut.MaximumLength([48841, 358801, 28561, 18974736, 4356, 221, 358801, 599, 13, 4356, 66, 48841, 28561, 815730721, 13, 815730721, 18974736, 66, 169, 599, 169, 221]),
            Is.EqualTo(7));
    }
}