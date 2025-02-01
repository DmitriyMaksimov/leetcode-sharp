using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01859Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01859();
        Assert.That(sut.SortSentence("is2 sentence4 This1 a3"), Is.EqualTo("This is a sentence"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01859();
        Assert.That(sut.SortSentence("Myself2 Me1 I4 and3"), Is.EqualTo("Me Myself and I"));
    }
}