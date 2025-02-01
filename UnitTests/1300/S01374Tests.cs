using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01374Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01374();
        Assert.That(sut.GenerateTheString(4), Is.EqualTo("aaab"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01374();
        Assert.That(sut.GenerateTheString(2), Is.EqualTo("ab"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01374();
        Assert.That(sut.GenerateTheString(7), Is.EqualTo("aaaaaaa"));
    }
}