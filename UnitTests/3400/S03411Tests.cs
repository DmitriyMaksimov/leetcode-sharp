using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03411Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03411();
        Assert.That(sut.MaxLength([1, 2, 1, 2, 1, 1, 1]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03411();
        Assert.That(sut.MaxLength([2, 3, 4, 5, 6]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S03411();
        Assert.That(sut.MaxLength([1, 2, 3, 1, 4, 5, 1]), Is.EqualTo(5));
    }

    [Test]
    public void T4()
    {
        var sut = new S03411();
        Assert.That(sut.MaxLength([7, 9, 3]), Is.EqualTo(2));
    }
}
