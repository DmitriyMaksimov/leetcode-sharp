using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01574Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01574();
        sut.FindLengthOfShortestSubarray([1, 2, 3, 10, 4, 2, 3, 5]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01574();
        sut.FindLengthOfShortestSubarray([5, 4, 3, 2, 1]).Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S01574();
        sut.FindLengthOfShortestSubarray([1, 2, 3]).Should().Be(0);
    }
}
