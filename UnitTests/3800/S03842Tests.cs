using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03842))]
public class S03842Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03842();
        Assert.That(sut.ToggleLightBulbs([10, 30, 20, 10]), Is.EqualTo([20, 30]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03842();
        Assert.That(sut.ToggleLightBulbs([100, 100]), Is.Empty);
    }
}