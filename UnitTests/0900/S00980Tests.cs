using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00980Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00980();
        Assert.That(sut.UniquePathsIII([[1, 0, 0, 0], [0, 0, 0, 0], [0, 0, 2, -1]]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00980();
        Assert.That(sut.UniquePathsIII([[1, 0, 0, 0], [0, 0, 0, 0], [0, 0, 0, 2]]), Is.EqualTo(4));
    }
}