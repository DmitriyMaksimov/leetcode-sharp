using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00648Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00648();
        Assert.That(sut.ReplaceWords(["cat", "bat", "rat"], "the cattle was rattled by the battery"), Is.EqualTo("the cat was rat by the bat"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00648();
        Assert.That(sut.ReplaceWords(["a", "b", "c"], "aadsfasf absbs bbab cadsfafs"), Is.EqualTo("a a b c"));
    }
}