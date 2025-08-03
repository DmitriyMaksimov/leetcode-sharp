using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02869Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02869();
        Assert.That(sut.MinOperations([3, 1, 5, 4, 2], 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02869();
        Assert.That(sut.MinOperations([3, 1, 5, 4, 2], 5), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S02869();
        Assert.That(sut.MinOperations([3, 2, 5, 3, 1], 3), Is.EqualTo(4));
    }
}