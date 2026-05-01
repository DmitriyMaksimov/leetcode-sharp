using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00396))]
public class S00396Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00396();
        Assert.That(sut.MaxRotateFunction([4, 3, 2, 6]), Is.EqualTo(26));
    }

    [Test]
    public void T2()
    {
        var sut = new S00396();
        Assert.That(sut.MaxRotateFunction([100]), Is.Zero);
    }
}