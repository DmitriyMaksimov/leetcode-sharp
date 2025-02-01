using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01775Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01775();
        Assert.That(sut.MinOperations([1, 2, 3, 4, 5, 6], [1, 1, 2, 2, 2, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01775();
        Assert.That(sut.MinOperations([1, 1, 1, 1, 1, 1, 1], [6]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01775();
        Assert.That(sut.MinOperations([6, 6], [1]), Is.EqualTo(3));
    }
}
