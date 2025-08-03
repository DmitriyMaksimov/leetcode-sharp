using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01346Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01346();
        Assert.That(sut.CheckIfExist([10, 2, 5, 3]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01346();
        Assert.That(sut.CheckIfExist([3, 1, 7, 11]), Is.False);
    }
}
