using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03493))]
public class S03493Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03493();
        Assert.That(sut.NumberOfComponents([[1, 2], [1, 1], [3, 4], [4, 5], [5, 6], [7, 7]], 1), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03493();
        Assert.That(sut.NumberOfComponents([[1, 2, 3], [2, 3, 4], [4, 3, 5]], 2), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S03493();
        Assert.That(sut.NumberOfComponents([[1, 1], [1, 1]], 2), Is.EqualTo(2));
    }
}