using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00648Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00648();
        sut.ReplaceWords(["cat", "bat", "rat"], "the cattle was rattled by the battery").Should().Be("the cat was rat by the bat");
    }

    [Test]
    public void T2()
    {
        var sut = new S00648();
        sut.ReplaceWords(["a", "b", "c"], "aadsfasf absbs bbab cadsfafs").Should().Be("a a b c");
    }
}