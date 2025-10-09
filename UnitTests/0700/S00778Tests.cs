using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00778))]
public class S00778Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00778();
        Assert.That(sut.SwimInWater([[0, 2], [1, 3]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00778();
        Assert.That(sut.SwimInWater([[0, 1, 2, 3, 4], [24, 23, 22, 21, 5], [12, 13, 14, 15, 16], [11, 17, 18, 19, 20], [10, 9, 8, 7, 6]]), Is.EqualTo(16));
    }
}