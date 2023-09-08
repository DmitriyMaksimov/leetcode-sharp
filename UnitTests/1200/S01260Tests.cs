using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01260Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01260();
        sut.ShiftGrid(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}}, 1).Should()
            .BeEquivalentTo(new[] {new[] {9, 1, 2}, new[] {3, 4, 5}, new[] {6, 7, 8}});
    }

    [Test]
    public void T2()
    {
        var sut = new S01260();
        sut.ShiftGrid(new[] {new[] {3, 8, 1, 9}, new[] {19, 7, 2, 5}, new[] {4, 6, 11, 10}, new[] {12, 0, 21, 13}}, 4)
            .Should()
            .BeEquivalentTo(
                new[] {new[] {12, 0, 21, 13}, new[] {3, 8, 1, 9}, new[] {19, 7, 2, 5}, new[] {4, 6, 11, 10}});
    }

    [Test]
    public void T3()
    {
        var sut = new S01260();
        sut.ShiftGrid(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}}, 9).Should()
            .BeEquivalentTo(new[] {new[] {1, 2, 3}, new[] {4, 5, 6}, new[] {7, 8, 9}});
    }
}