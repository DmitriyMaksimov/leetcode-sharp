using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01078Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01078();
        Assert.That(sut.FindOcurrences("alice is a good girl she is a good student", "a", "good"), Is.EqualTo((string[]) ["girl", "student"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01078();
        Assert.That(sut.FindOcurrences("we will we will rock you", "we", "will"), Is.EqualTo((string[]) ["we", "rock"]));
    }
}
