using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01967Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01967();
        sut.NumOfStrings(new[] {"a", "abc", "bc", "d"}, "abc").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01967();
        sut.NumOfStrings(new[] {"a", "b", "c"}, "aaaaabbbbb").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01967();
        sut.NumOfStrings(new[] {"a", "a", "a"}, "ab").Should().Be(3);
    }
}