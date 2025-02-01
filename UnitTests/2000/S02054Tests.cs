using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02054Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02054();
        Assert.That(sut.MaxTwoEvents([[1, 3, 2], [4, 5, 2], [2, 4, 3]]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02054();
        Assert.That(sut.MaxTwoEvents([[1, 3, 2], [4, 5, 2], [1, 5, 5]]), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S02054();
        Assert.That(sut.MaxTwoEvents([[1, 5, 3], [1, 5, 1], [6, 6, 5]]), Is.EqualTo(8));
    }
}
