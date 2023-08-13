using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00068Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00068();
        sut.FullJustify(new[] {"This", "is", "an", "example", "of", "text", "justification."}, 16).Should().Equal(
            "This    is    an",
            "example  of text",
            "justification.  ");
    }

    [Test]
    public void T2()
    {
        var sut = new S00068();
        sut.FullJustify(new[] {"What", "must", "be", "acknowledgment", "shall", "be"}, 16).Should().Equal(
            "What   must   be",
            "acknowledgment  ",
            "shall be        ");
    }

    [Test]
    public void T3()
    {
        var sut = new S00068();
        sut.FullJustify(
            new[]
            {
                "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.",
                "Art", "is", "everything", "else", "we", "do"
            }, 20).Should().Equal(
            "Science  is  what we",
            "understand      well",
            "enough to explain to",
            "a  computer.  Art is",
            "everything  else  we",
            "do                  ");
    }
}