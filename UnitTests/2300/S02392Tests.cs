using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02392Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02392();
        sut.BuildMatrix(3, [[1, 2], [3, 2]], [[2, 1], [3, 2]]).Should().BeEquivalentTo([(int[])[0, 0, 1], [3, 0, 0], [0, 2, 0]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S02392();
        sut.BuildMatrix(3, [[1, 2], [2, 3], [3, 1], [2, 3]], [[2, 1]]).Should().BeEmpty();
    }
}