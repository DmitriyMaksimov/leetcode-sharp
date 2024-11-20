using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02516Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02516();
        sut.TakeCharacters("aabaaaacaabc", 2).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S02516();
        sut.TakeCharacters("a", 1).Should().Be(-1);
    }
}
