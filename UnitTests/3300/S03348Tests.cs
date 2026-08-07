using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03348))]
public class S03348Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03348();
        Assert.That(sut.SmallestNumber("1234", 256), Is.EqualTo("1488"));
    }

    [Test]
    public void T2()
    {
        var sut = new S03348();
        Assert.That(sut.SmallestNumber("12355", 50), Is.EqualTo("12355"));
    }

    [Test]
    public void T3()
    {
        var sut = new S03348();
        Assert.That(sut.SmallestNumber("11111", 26), Is.EqualTo("-1"));
    }
}