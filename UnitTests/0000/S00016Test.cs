using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00016))]
public class S00016Test
{
    [Test]
    public void T1()
    {
        var sut = new S00016();
        Assert.That(sut.ThreeSumClosest([-1, 2, 1, -4], 1), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00016();
        Assert.That(sut.ThreeSumClosest([0, 0, 0], 1), Is.EqualTo(0));
    }
}