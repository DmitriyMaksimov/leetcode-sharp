using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02140Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02140();
        Assert.That(sut.MostPoints([[3, 2], [4, 3], [4, 4], [2, 5]]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02140();
        Assert.That(sut.MostPoints([[1, 1], [2, 2], [3, 3], [4, 4], [5, 5]]), Is.EqualTo(7));
    }
}