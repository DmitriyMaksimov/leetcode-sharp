using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01897Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01897();
        Assert.That(sut.MakeEqual(["abc", "aabc", "bc"]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01897();
        Assert.That(sut.MakeEqual(["ab", "a"]), Is.False);
    }
}
