using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03090Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03090();
        Assert.That(sut.MaximumLengthSubstring("bcbbbcba"), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03090();
        Assert.That(sut.MaximumLengthSubstring("aaaa"), Is.EqualTo(2));
    }
}