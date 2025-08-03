using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02500Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02500();
        Assert.That(sut.DeleteGreatestValue([[1, 2, 4], [3, 3, 1]]), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02500();
        Assert.That(sut.DeleteGreatestValue([[10]]), Is.EqualTo(10));
    }
}