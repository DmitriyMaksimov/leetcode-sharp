using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03325Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03325();
        Assert.That(sut.NumberOfSubstrings("abacb", 2), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03325();
        Assert.That(sut.NumberOfSubstrings("abcde", 1), Is.EqualTo(15));
    }
}
