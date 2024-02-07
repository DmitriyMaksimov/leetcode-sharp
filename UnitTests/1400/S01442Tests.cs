using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01442Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01442();
        sut.CountTriplets([2, 3, 1, 6, 7]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01442();
        sut.CountTriplets([1, 1, 1, 1, 1]).Should().Be(10);
    }
}