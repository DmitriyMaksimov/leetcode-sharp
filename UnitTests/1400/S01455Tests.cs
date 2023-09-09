using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01455Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01455();
        sut.IsPrefixOfWord("i love eating burger", "burg").Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01455();
        sut.IsPrefixOfWord("this problem is an easy problem", "pro").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01455();
        sut.IsPrefixOfWord("i am tired", "you").Should().Be(-1);
    }
}