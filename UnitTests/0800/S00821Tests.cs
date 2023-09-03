using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00821Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00821();
        sut.ShortestToChar("loveleetcode", 'e').Should().Equal(3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0);
    }

    [Test]
    public void T2()
    {
        var sut = new S00821();
        sut.ShortestToChar("aaab", 'b').Should().Equal(3, 2, 1, 0);
    }
}