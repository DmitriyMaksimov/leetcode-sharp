using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02416Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02416();
        Assert.That(sut.SumPrefixScores(["abc", "ab", "bc", "b"]), Is.EqualTo((int[]) [5, 4, 3, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02416();
        Assert.That(sut.SumPrefixScores(["abcd"]), Is.EqualTo((int[]) [4]));
    }
}
