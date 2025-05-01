using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02071))]
public class S02071Test
{
    [Test]
    public void T1()
    {
        var sut = new S02071();
        Assert.That(sut.MaxTaskAssign([3, 2, 1], [0, 3, 3], 1, 1), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02071();
        Assert.That(sut.MaxTaskAssign([5, 4], [0, 0, 0], 1, 5), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02071();
        Assert.That(sut.MaxTaskAssign([10, 15, 30], [0, 10, 10, 10, 10], 3, 10), Is.EqualTo(2));
    }
}
