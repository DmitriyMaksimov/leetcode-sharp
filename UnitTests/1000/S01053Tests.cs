using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01053Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01053();
        Assert.That(sut.PrevPermOpt1([3, 2, 1]), Is.EqualTo([3, 1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01053();
        Assert.That(sut.PrevPermOpt1([1, 1, 5]), Is.EqualTo([1, 1, 5]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01053();
        Assert.That(sut.PrevPermOpt1([1, 9, 4, 6, 7]), Is.EqualTo([1, 7, 4, 6, 9]));
    }
}
