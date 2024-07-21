using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03146Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03146();
        sut.FindPermutationDifference("abc", "bac").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S03146();
        sut.FindPermutationDifference("abcde", "edbac").Should().Be(12);
    }
}