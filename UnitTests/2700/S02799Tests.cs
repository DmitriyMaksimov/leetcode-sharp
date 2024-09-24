using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02799Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02799();
        sut.CountCompleteSubarrays([1, 3, 1, 2, 2]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02799();
        sut.CountCompleteSubarrays([5, 5, 5, 5]).Should().Be(10);
    }
}
