using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03354Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03354();
        sut.CountValidSelections([1, 0, 2, 0, 3]).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S03354();
        sut.CountValidSelections([2, 3, 4, 0, 4, 1, 0]).Should().Be(0);
    }
}
