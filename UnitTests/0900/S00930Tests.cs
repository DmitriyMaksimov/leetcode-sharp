using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00930Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00930();
        sut.NumSubarraysWithSum([1, 0, 1, 0, 1], 2).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00930();
        sut.NumSubarraysWithSum([0, 0, 0, 0, 0], 0).Should().Be(15);
    }
}