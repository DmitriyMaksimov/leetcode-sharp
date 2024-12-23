using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03392Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03392();
        sut.CountSubarrays([1, 2, 1, 4, 1]).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03392();
        sut.CountSubarrays([1, 1, 1]).Should().Be(0);
    }
}
