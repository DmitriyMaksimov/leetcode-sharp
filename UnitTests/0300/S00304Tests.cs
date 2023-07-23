
namespace UnitTests;

[TestFixture]
public class S00304Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00304.NumMatrix(new []{new []{3, 0, 1, 4, 2}, new []{5, 6, 3, 2, 1}, new []{1, 2, 0, 1, 5}, new []{4, 1, 0, 1, 7}, new []{1, 0, 3, 0, 5}});
        sut.SumRegion(2, 1, 4, 3).Should().Be(8);
        sut.SumRegion(1, 1, 2, 2).Should().Be(11);
        sut.SumRegion(1, 2, 2, 4).Should().Be(12);
    }
}