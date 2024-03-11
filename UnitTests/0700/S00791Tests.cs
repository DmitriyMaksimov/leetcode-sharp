using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00791Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00791();
        sut.CustomSortString("cba", "abcd").Should().Be("cbad");
    }

    [Test]
    public void T2()
    {
        var sut = new S00791();
        sut.CustomSortString("bcafg", "abcd").Should().Be("bcad");
    }
}