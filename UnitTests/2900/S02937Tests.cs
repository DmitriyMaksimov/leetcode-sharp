using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02937Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02937();
        sut.FindMinimumOperations("abc", "abb", "ab").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02937();
        sut.FindMinimumOperations("dac", "bac", "cac").Should().Be(-1);
    }
}