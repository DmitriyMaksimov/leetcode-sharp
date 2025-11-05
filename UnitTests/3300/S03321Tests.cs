using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03321))]
public class S03321Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03321();
        Assert.That(sut.FindXSum([1, 1, 2, 2, 3, 4, 2, 3], 6, 2), Is.EqualTo([6, 10, 12]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03321();
        Assert.That(sut.FindXSum([3, 8, 7, 8, 7, 5], 2, 2), Is.EqualTo([11, 15, 15, 15, 12]));
    }
}