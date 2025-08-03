using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02328Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02328();
        Assert.That(sut.CountPaths([[1, 1], [3, 4]]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02328();
        Assert.That(sut.CountPaths([[1], [2]]), Is.EqualTo(3));
    }
}