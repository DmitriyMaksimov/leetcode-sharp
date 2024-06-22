using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01248Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01248();
        sut.NumberOfSubarrays([1, 1, 2, 1, 1], 3).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01248();
        sut.NumberOfSubarrays([2, 4, 6], 1).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S01248();
        sut.NumberOfSubarrays([2, 2, 2, 1, 2, 2, 1, 2, 2, 2], 2).Should().Be(16);
    }
}