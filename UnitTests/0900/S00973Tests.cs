using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00973Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00973();
        sut.KClosest([[1, 3], [-2, 2]], 1).Should().BeEquivalentTo([(int[]) [-2, 2]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S00973();
        sut.KClosest([[3, 3], [5, -1], [-2, 4]], 2).Should().BeEquivalentTo([(int[]) [3, 3], [-2, 4]]);
    }
}
