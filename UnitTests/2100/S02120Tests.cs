using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02120Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02120();
        Assert.That(sut.ExecuteInstructions(3, new[] {0, 1}, "RRDDLU"), Is.EqualTo((int[]) [1, 5, 4, 3, 1, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02120();
        Assert.That(sut.ExecuteInstructions(2, new[] {1, 1}, "LURD"), Is.EqualTo((int[]) [4, 1, 0, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02120();
        Assert.That(sut.ExecuteInstructions(1, new[] {0, 0}, "LRUD"), Is.EqualTo((int[]) [0, 0, 0, 0]));
    }
}