using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01765Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01765();
        sut.HighestPeak([[0, 1], [0, 0]]).Should().BeEquivalentTo([(int[]) [1, 0], [2, 1]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S01765();
        sut.HighestPeak([[0, 0, 1], [1, 0, 0], [0, 0, 0]]).Should().BeEquivalentTo([(int[]) [1, 1, 0], [0, 1, 1], [1, 2, 2]]);
    }
}
