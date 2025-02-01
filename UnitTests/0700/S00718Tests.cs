using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00718Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00718();
        Assert.That(sut.FindLength([1, 2, 3, 2, 1], [3, 2, 1, 4, 7]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00718();
        Assert.That(sut.FindLength([0, 0, 0, 0, 0], [0, 0, 0, 0, 0]), Is.EqualTo(5));
    }
}
