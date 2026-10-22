using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03942))]
public class S03942Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03942();
        Assert.That(sut.MinOperations([0, 2, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03942();
        Assert.That(sut.MinOperations([1, 0, 2]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S03942();
        Assert.That(sut.MinOperations([2, 0, 1, 3]), Is.EqualTo(-1));
    }
}