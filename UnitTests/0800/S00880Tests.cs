using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00880Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00880();
        Assert.That(sut.DecodeAtIndex("leet2code3", 10), Is.EqualTo("o"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00880();
        Assert.That(sut.DecodeAtIndex("ha22", 5), Is.EqualTo("h"));
    }

    [Test]
    public void T3()
    {
        var sut = new S00880();
        Assert.That(sut.DecodeAtIndex("a2345678999999999999999", 1), Is.EqualTo("a"));
    }
}