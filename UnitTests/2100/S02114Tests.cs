using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02114Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02114();
        sut.MostWordsFound(new[] {"alice and bob love leetcode", "i think so too", "this is great thanks very much"}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02114();
        sut.MostWordsFound(new[] {"please wait", "continue to fight", "continue to win"}).Should().Be(3);
    }
}