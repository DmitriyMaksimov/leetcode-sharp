using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S100186Tests
{
    [Test]
    public void T1()
    {
        var sut = new S100186();
        sut.CountMatchingSubarrays([1, 2, 3, 4, 5, 6], [1, 1]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S100186();
        sut.CountMatchingSubarrays([1, 4, 4, 1, 3, 5, 5, 3], [1, 0, -1]).Should().Be(2);
    }
}