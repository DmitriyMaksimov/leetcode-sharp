using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01897Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01897();
        sut.MakeEqual(new[] {"abc", "aabc", "bc"}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01897();
        sut.MakeEqual(new[] {"ab", "a"}).Should().BeFalse();
    }
}