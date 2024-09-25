using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02416Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02416();
        sut.SumPrefixScores(["abc", "ab", "bc", "b"]).Should().Equal(5, 4, 3, 2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02416();
        sut.SumPrefixScores(["abcd"]).Should().Equal(4);
    }
}
