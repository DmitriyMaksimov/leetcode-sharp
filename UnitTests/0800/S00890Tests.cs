using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00890Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00890();
        Assert.That(sut.FindAndReplacePattern(["abc", "deq", "mee", "aqq", "dkd", "ccc"], "abb"), Is.EqualTo((string[]) ["mee", "aqq"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00890();
        Assert.That(sut.FindAndReplacePattern(["a", "b", "c"], "a"), Is.EqualTo((string[]) ["a", "b", "c"]));
    }
}
