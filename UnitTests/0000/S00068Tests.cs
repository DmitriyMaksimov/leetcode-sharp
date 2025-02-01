using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00068Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00068();
        Assert.That(sut.FullJustify(new[] {"This", "is", "an", "example", "of", "text", "justification."}, 16), Is.EqualTo((string[]) ["This    is    an",
        "example  of text",
        "justification.  "]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00068();
        Assert.That(sut.FullJustify(new[] {"What", "must", "be", "acknowledgment", "shall", "be"}, 16), Is.EqualTo((string[]) ["What   must   be",
        "acknowledgment  ",
        "shall be        "]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00068();
        Assert.That(sut.FullJustify(
            new[]
            {
                "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.",
                "Art", "is", "everything", "else", "we", "do"
            }, 20), Is.EqualTo((string[]) ["Science  is  what we",
        "understand      well",
        "enough to explain to",
        "a  computer.  Art is",
        "everything  else  we",
        "do                  "]));
    }
}
