using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01030Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01030();
        sut.AllCellsDistOrder(1, 2, 0, 0).Should().BeEquivalentTo(new[] {new[] {0, 0}, new[] {0, 1}});
    }

    [Test]
    public void T2()
    {
        var sut = new S01030();
        sut.AllCellsDistOrder(2, 2, 0, 1).Should()
            .BeEquivalentTo(new[] {new[] {0, 1}, new[] {0, 0}, new[] {1, 1}, new[] {1, 0}});
    }

    [Test]
    public void T3()
    {
        var sut = new S01030();
        sut.AllCellsDistOrder(2, 3, 1, 2).Should().BeEquivalentTo(new[]
            {new[] {1, 2}, new[] {0, 2}, new[] {1, 1}, new[] {0, 1}, new[] {1, 0}, new[] {0, 0}});
    }
}