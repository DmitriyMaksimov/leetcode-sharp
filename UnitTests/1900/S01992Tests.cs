using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01992Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01992();
        Assert.That(sut.FindFarmland([[1, 0, 0], [0, 1, 1], [0, 1, 1]]), Is.EquivalentTo((int[][]) [[0, 0, 0, 0], [1, 1, 2, 2]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01992();
        Assert.That(sut.FindFarmland([[1, 1], [1, 1]]), Is.EquivalentTo((int[][]) [[0, 0, 1, 1]]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01992();
        Assert.That(sut.FindFarmland([[0]]), Is.Empty);
    }
}
