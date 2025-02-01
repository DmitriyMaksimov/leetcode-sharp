using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00937Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00937();
        Assert.That(sut.ReorderLogFiles(["dig1 8 1 5 1", "let1 art can", "dig2 3 6", "let2 own kit dig", "let3 art zero"]), Is.EqualTo((string[]) ["let1 art can", "let3 art zero", "let2 own kit dig", "dig1 8 1 5 1", "dig2 3 6"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00937();
        Assert.That(sut.ReorderLogFiles(["a1 9 2 3 1", "g1 act car", "zo4 4 7", "ab1 off key dog", "a8 act zoo"]), Is.EqualTo((string[]) ["g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7"]));
    }
}
