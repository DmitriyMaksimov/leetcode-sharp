using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03158Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03158();
        Assert.That(sut.DuplicateNumbersXOR([1, 2, 1, 3]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03158();
        Assert.That(sut.DuplicateNumbersXOR([1, 2, 3]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03158();
        Assert.That(sut.DuplicateNumbersXOR([1, 2, 2, 1]), Is.EqualTo(3));
    }
}