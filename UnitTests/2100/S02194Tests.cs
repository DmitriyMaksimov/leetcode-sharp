using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02194Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02194();
        Assert.That(sut.CellsInRange("K1:L2"), Is.EqualTo((string[]) ["K1","K2","L1","L2"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02194();
        Assert.That(sut.CellsInRange("A1:F1"), Is.EqualTo((string[]) ["A1","B1","C1","D1","E1","F1"]));
    }
}
