using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00458Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00458();
        sut.PoorPigs(4, 15, 15).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00458();
        sut.PoorPigs(4, 15, 30).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S00458();
        sut.PoorPigs(125, 1, 4).Should().Be(3);
    }
}