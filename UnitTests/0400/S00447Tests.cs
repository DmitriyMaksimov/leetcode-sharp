using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00447Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00447();
        Assert.That(sut.NumberOfBoomerangs([[0, 0], [1, 0], [2, 0]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00447();
        Assert.That(sut.NumberOfBoomerangs([[1, 1], [2, 2], [3, 3]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00447();
        Assert.That(sut.NumberOfBoomerangs([[1, 1]]), Is.EqualTo(0));
    }
}
