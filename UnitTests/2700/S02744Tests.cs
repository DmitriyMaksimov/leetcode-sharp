using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02744Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02744();
        Assert.That(sut.MaximumNumberOfStringPairs(new[] {"cd", "ac", "dc", "ca", "zz"}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02744();
        Assert.That(sut.MaximumNumberOfStringPairs(new[] {"ab", "ba", "cc"}), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02744();
        Assert.That(sut.MaximumNumberOfStringPairs(new[] {"aa", "ab"}), Is.EqualTo(0));
    }
}