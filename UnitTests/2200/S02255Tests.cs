using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02255Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02255();
        sut.CountPrefixes(new[] {"a", "b", "c", "ab", "bc", "abc"}, "abc").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02255();
        sut.CountPrefixes(new[] {"a", "a"}, "aa").Should().Be(2);
    }
}