using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01859Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01859();
        sut.SortSentence("is2 sentence4 This1 a3").Should().Be("This is a sentence");
    }

    [Test]
    public void T2()
    {
        var sut = new S01859();
        sut.SortSentence("Myself2 Me1 I4 and3").Should().Be("Me Myself and I");
    }
}