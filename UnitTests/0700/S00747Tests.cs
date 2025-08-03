using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00747Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00747();
        Assert.That(sut.DominantIndex([3, 6, 1, 0]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00747();
        Assert.That(sut.DominantIndex([1, 2, 3, 4]), Is.EqualTo(-1));
    }
}