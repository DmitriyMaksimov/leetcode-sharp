using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01526))]
public class S01526Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01526();
        Assert.That(sut.MinNumberOperations([1, 2, 3, 2, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01526();
        Assert.That(sut.MinNumberOperations([3, 1, 1, 2]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S01526();
        Assert.That(sut.MinNumberOperations([3, 1, 5, 4, 2]), Is.EqualTo(7));
    }
}