using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00529Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00529();
        Assert.That(sut.UpdateBoard([['E', 'E', 'E', 'E', 'E'], ['E', 'E', 'M', 'E', 'E'], ['E', 'E', 'E', 'E', 'E'], ['E', 'E', 'E', 'E', 'E']], [3, 0]), Is.EquivalentTo(
            (char[][]) [['B', '1', 'E', '1', 'B'], ['B', '1', 'M', '1', 'B'], ['B', '1', '1', '1', 'B'], ['B', 'B', 'B', 'B', 'B']
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00529();
        Assert.That(sut.UpdateBoard([['B', '1', 'E', '1', 'B'], ['B', '1', 'M', '1', 'B'], ['B', '1', '1', '1', 'B'], ['B', 'B', 'B', 'B', 'B']], [1, 2]), Is.EquivalentTo(
            (char[][]) [['B', '1', 'E', '1', 'B'], ['B', '1', 'X', '1', 'B'], ['B', '1', '1', '1', 'B'], ['B', 'B', 'B', 'B', 'B']
        ]));
    }
}
