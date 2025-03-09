using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03477Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03477();
        Assert.That(sut.NumOfUnplacedFruits([4, 2, 5], [3, 5, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03477();
        Assert.That(sut.NumOfUnplacedFruits([3, 6, 1], [6, 4, 7]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03477();
        Assert.That(sut.NumOfUnplacedFruits([6, 5], [3, 5]), Is.EqualTo(1));
    }
}
