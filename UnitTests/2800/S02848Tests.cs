using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02848Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02848();
        Assert.That(sut.NumberOfPoints([[3, 6], [1, 5], [4, 7]]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02848();
        Assert.That(sut.NumberOfPoints([[1, 3], [5, 8]]), Is.EqualTo(7));
    }
}