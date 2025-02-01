using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00241Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00241();
        Assert.That(sut.DiffWaysToCompute("2-1-1"), Is.EquivalentTo((int[]) [0, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00241();
        Assert.That(sut.DiffWaysToCompute("2*3-4*5"), Is.EquivalentTo((int[]) [-34, -14, -10, -10, 10]));
    }
}
