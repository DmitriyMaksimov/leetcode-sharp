using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02133Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02133();
        Assert.That(sut.CheckValid([[1, 2, 3], [3, 1, 2], [2, 3, 1]]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02133();
        Assert.That(sut.CheckValid([[1, 1, 1], [1, 2, 3], [1, 2, 3]]), Is.False);
    }
}
