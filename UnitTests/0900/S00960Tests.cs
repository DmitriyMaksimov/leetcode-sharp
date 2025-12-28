using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00960))]
public class S00960Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00960();
        Assert.That(sut.MinDeletionSize(["babca", "bbazb"]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00960();
        Assert.That(sut.MinDeletionSize(["edcba"]), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S00960();
        Assert.That(sut.MinDeletionSize(["ghi", "def", "abc"]), Is.Zero);
    }
}