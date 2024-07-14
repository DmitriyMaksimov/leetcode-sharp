using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03194Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03194();
        sut.MinimumAverage([7, 8, 3, 4, 15, 13, 4, 1]).Should().Be(5.5);
    }

    [Test]
    public void T2()
    {
        var sut = new S03194();
        sut.MinimumAverage([1, 9, 8, 3, 10, 5]).Should().Be(5.5);
    }

    [Test]
    public void T3()
    {
        var sut = new S03194();
        sut.MinimumAverage([1, 2, 3, 7, 8, 9]).Should().Be(5);
    }
}