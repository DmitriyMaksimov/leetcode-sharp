using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02975))]
public class S02975Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02975();
        Assert.That(sut.MaximizeSquareArea(4, 3, [2, 3], [2]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02975();
        Assert.That(sut.MaximizeSquareArea(6, 7, [2], [4]), Is.EqualTo(-1));
    }
}