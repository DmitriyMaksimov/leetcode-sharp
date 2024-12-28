using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00689Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00689();
        sut.MaxSumOfThreeSubarrays([1, 2, 1, 2, 6, 7, 5, 1], 2).Should().Equal(0, 3, 5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00689();
        sut.MaxSumOfThreeSubarrays([1, 2, 1, 2, 1, 2, 1, 2, 1], 2).Should().Equal(0, 2, 4);
    }
}
