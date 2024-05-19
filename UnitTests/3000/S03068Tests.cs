using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03068Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03068();
        sut.MaximumValueSum([1, 2, 1], 3, [[0, 1], [0, 2]]).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S03068();
        sut.MaximumValueSum([2, 3], 7, [[0, 1]]).Should().Be(9);
    }

    [Test]
    public void T3()
    {
        var sut = new S03068();
        sut.MaximumValueSum([7, 7, 7, 7, 7, 7], 3, [[0, 1], [0, 2], [0, 3], [0, 4], [0, 5]]).Should().Be(42);
    }
}