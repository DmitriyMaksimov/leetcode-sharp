using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00621Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00621();
        sut.LeastInterval(['A', 'A', 'A', 'B', 'B', 'B'], 2).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S00621();
        sut.LeastInterval(['A', 'C', 'A', 'B', 'D', 'B'], 1).Should().Be(6);
    }

    [Test]
    public void T3()
    {
        var sut = new S00621();
        sut.LeastInterval(['A', 'A', 'A', 'B', 'B', 'B'], 3).Should().Be(10);
    }
}