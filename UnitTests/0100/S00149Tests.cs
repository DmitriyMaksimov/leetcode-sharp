using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00149Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00149();
        Assert.That(sut.MaxPoints([[1, 1], [2, 2], [3, 3]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00149();
        Assert.That(sut.MaxPoints([[1, 1], [3, 2], [5, 3], [4, 1], [2, 3], [1, 4]]), Is.EqualTo(4));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00149();
        Assert.That(sut.MaxPoints([[0, 0]]), Is.EqualTo(1));
    }
}