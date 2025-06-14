using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01144))]
public class S01144Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01144();
        Assert.That(sut.MovesToMakeZigzag([1, 2, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01144();
        Assert.That(sut.MovesToMakeZigzag([9, 6, 1, 6, 2]), Is.EqualTo(4));
    }
}
