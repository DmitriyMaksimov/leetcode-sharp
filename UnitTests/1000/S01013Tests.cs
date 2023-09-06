using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01013Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01013();
        sut.CanThreePartsEqualSum(new[] {0, 2, 1, -6, 6, -7, 9, 1, 2, 0, 1}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01013();
        sut.CanThreePartsEqualSum(new[] {0, 2, 1, -6, 6, 7, 9, -1, 2, 0, 1}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01013();
        sut.CanThreePartsEqualSum(new[] {3, 3, 6, 5, -2, 2, 5, 1, -9, 4}).Should().BeTrue();
    }
}