using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02962Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02962();
        sut.CountSubarrays([1, 3, 2, 3, 3], 2).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S02962();
        sut.CountSubarrays([1, 4, 2, 1], 3).Should().Be(0);
    }
}