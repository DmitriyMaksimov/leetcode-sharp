using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01935Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01935();
        Assert.That(sut.CanBeTypedWords("hello world", "ad"), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01935();
        Assert.That(sut.CanBeTypedWords("leet code", "lt"), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01935();
        Assert.That(sut.CanBeTypedWords("leet code", "e"), Is.EqualTo(0));
    }
}