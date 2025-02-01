using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00368Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00368();
        Assert.That(sut.LargestDivisibleSubset([1, 2, 3]), Is.EqualTo((int[]) [2, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00368();
        Assert.That(sut.LargestDivisibleSubset([1, 2, 4, 8]), Is.EqualTo((int[]) [8, 4, 2, 1]));
    }
}