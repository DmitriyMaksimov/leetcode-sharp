using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02208))]
public class S02208Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02208();
        Assert.That(sut.HalveArray([5, 19, 8, 1]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02208();
        Assert.That(sut.HalveArray([3, 8, 20]), Is.EqualTo(3));
    }
}
