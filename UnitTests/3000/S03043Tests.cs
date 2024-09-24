using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03043Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03043();
        sut.LongestCommonPrefix([1, 10, 100], [1000]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S03043();
        sut.LongestCommonPrefix([1, 2, 3], [4, 4, 4]).Should().Be(0);
    }
}
