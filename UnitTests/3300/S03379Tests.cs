using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03379Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03379();
        Assert.That(sut.ConstructTransformedArray([3, -2, 1, 1]), Is.EqualTo((int[]) [1, 1, 1, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03379();
        Assert.That(sut.ConstructTransformedArray([-1, 4, -1]), Is.EqualTo((int[]) [-1, -1, 4]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03379();
        Assert.That(sut.ConstructTransformedArray([-10, -10]), Is.EqualTo((int[]) [-10, -10]));
    }
}
