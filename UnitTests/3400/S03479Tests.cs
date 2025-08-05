using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03479))]
public class S03479Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03479();
        Assert.That(sut.NumOfUnplacedFruits([4, 2, 5], [3, 5, 4]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03479();
        Assert.That(sut.NumOfUnplacedFruits([3, 6, 1], [6, 4, 7]), Is.EqualTo(0));
    }
}