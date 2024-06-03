using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02486Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02486();
        sut.AppendCharacters("coaching", "coding").Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02486();
        sut.AppendCharacters("abcde", "a").Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S02486();
        sut.AppendCharacters("z", "abcde").Should().Be(5);
    }
}