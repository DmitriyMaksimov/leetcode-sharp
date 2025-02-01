using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03375Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03375();
        Assert.That(sut.MinOperations([5, 2, 5, 4, 5], 2), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03375();
        Assert.That(sut.MinOperations([2, 1, 2], 2), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03375();
        Assert.That(sut.MinOperations([9, 7, 5, 3], 1), Is.EqualTo(4));
    }
}
