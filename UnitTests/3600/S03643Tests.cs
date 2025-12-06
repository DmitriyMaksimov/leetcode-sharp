using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03643))]
public class S03643Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03643();
        Assert.That(sut.ReverseSubmatrix([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12], [13, 14, 15, 16]], 1, 0, 3),
            Is.EqualTo([(int[])[1, 2, 3, 4], [13, 14, 15, 8], [9, 10, 11, 12], [5, 6, 7, 16]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03643();
        Assert.That(sut.ReverseSubmatrix([[3, 4, 2, 3], [2, 3, 4, 2]], 0, 2, 2), Is.EqualTo([(int[])[3, 4, 4, 2], [2, 3, 2, 3]]));
    }
}