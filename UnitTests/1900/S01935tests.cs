using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01935Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01935();
        sut.CanBeTypedWords("hello world", "ad").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01935();
        sut.CanBeTypedWords("leet code", "lt").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S01935();
        sut.CanBeTypedWords("leet code", "e").Should().Be(0);
    }
}