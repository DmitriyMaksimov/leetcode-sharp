using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00042Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00042();
        Assert.That(sut.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00042();
        Assert.That(sut.Trap([4, 2, 0, 3, 2, 5]), Is.EqualTo(9));
    }
}