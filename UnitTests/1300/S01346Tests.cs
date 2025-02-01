using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01346Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01346();
        Assert.That(sut.CheckIfExist(new[] {10, 2, 5, 3}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01346();
        Assert.That(sut.CheckIfExist(new[] {3, 1, 7, 11}), Is.False);
    }
}
