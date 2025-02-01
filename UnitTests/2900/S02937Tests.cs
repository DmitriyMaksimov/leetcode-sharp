using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02937Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02937();
        Assert.That(sut.FindMinimumOperations("abc", "abb", "ab"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02937();
        Assert.That(sut.FindMinimumOperations("dac", "bac", "cac"), Is.EqualTo(-1));
    }
}