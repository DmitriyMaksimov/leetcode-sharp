using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02194Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02194();
        sut.CellsInRange("K1:L2").Should().Equal("K1","K2","L1","L2");
    }

    [Test]
    public void T2()
    {
        var sut = new S02194();
        sut.CellsInRange("A1:F1").Should().Equal("A1","B1","C1","D1","E1","F1");
    }
}