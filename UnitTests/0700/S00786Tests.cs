using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00786Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00786();
        sut.KthSmallestPrimeFraction([1, 2, 3, 5], 3).Should().BeEquivalentTo([2, 5]);
    }

    [Test]
    public void T2()
    {
        var sut = new S00786();
        sut.KthSmallestPrimeFraction([1, 7], 1).Should().BeEquivalentTo([1, 7]);
    }
}