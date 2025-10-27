using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03701))]
public class S03701Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03701();
        Assert.That(sut.AlternatingSum([1, 3, 5, 7]), Is.EqualTo(-4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03701();
        Assert.That(sut.AlternatingSum([100]), Is.EqualTo(100));
    }
}