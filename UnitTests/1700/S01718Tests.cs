using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01718Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01718();
        Assert.That(sut.ConstructDistancedSequence(3), Is.EqualTo((int[]) [3, 1, 2, 3, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01718();
        Assert.That(sut.ConstructDistancedSequence(5), Is.EqualTo((int[]) [5, 3, 1, 4, 3, 5, 2, 4, 2]));
    }
}
