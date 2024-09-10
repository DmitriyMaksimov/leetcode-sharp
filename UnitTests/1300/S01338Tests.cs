using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01338Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01338();
        sut.MinSetSize([3, 3, 3, 3, 5, 5, 5, 2, 2, 7]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01338();
        sut.MinSetSize([7, 7, 7, 7, 7, 7]).Should().Be(1);
    }
}
