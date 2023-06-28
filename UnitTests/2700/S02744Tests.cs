using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02744Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02744();
        sut.MaximumNumberOfStringPairs(new[] {"cd", "ac", "dc", "ca", "zz"}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02744();
        sut.MaximumNumberOfStringPairs(new[] {"ab", "ba", "cc"}).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02744();
        sut.MaximumNumberOfStringPairs(new[] {"aa", "ab"}).Should().Be(0);
    }
}