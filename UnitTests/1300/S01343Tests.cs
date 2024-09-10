using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01343Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01343();
        sut.NumOfSubarrays([2, 2, 2, 2, 5, 5, 5, 8], 3, 4).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01343();
        sut.NumOfSubarrays([11, 13, 17, 23, 29, 31, 7, 5, 2, 3], 3, 5).Should().Be(6);
    }
}
