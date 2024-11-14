using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02064Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02064();
        sut.MinimizedMaximum(6, [11, 6]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02064();
        sut.MinimizedMaximum(7, [15, 10, 10]).Should().Be(5);
    }

    [Test]
    public void T3()
    {
        var sut = new S02064();
        sut.MinimizedMaximum(1, [100000]).Should().Be(100000);
    }
}
