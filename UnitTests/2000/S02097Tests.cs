using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02097Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02097();
        var arrangement = sut.ValidArrangement([[5, 1], [4, 5], [11, 9], [9, 4]]);
        Verify(arrangement, [[11, 9], [9, 4], [4, 5], [5, 1]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S02097();
        var arrangement = sut.ValidArrangement([[1, 3], [3, 2], [2, 1]]);
        Verify(arrangement, [[1, 3], [3, 2], [2, 1]]);
    }

    [Test]
    public void T3()
    {
        var sut = new S02097();
        var arrangement = sut.ValidArrangement([[1, 2], [1, 3], [2, 1]]);
        Verify(arrangement, [[1,2],[2,1],[1,3]]);
    }

    [Test]
    public void T4()
    {
        var sut = new S02097();
        var arrangement = sut.ValidArrangement([[5,3],[2,3],[0,1],[1,4],[0,5],[3,2],[4,3],[3,0]]);
        Verify(arrangement, [[0,5],[5,3],[3,0],[0,1],[1,4],[4,3],[3,2],[2,3]]);
    }

    private static void Verify(int[][] arrangement, int[][] ints)
    {
        for (var i = 0; i < arrangement.Length; i++)
        {
            Assert.That(arrangement[i][0], Is.EqualTo(ints[i][0]));
            Assert.That(arrangement[i][1], Is.EqualTo(ints[i][1]));
        }
    }
}
