using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02178Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02178();
        Assert.That(sut.MaximumEvenSplit(12), Is.EqualTo((int[]) [2, 4, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02178();
        Assert.That(sut.MaximumEvenSplit(7), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S02178();
        Assert.That(sut.MaximumEvenSplit(28), Is.EqualTo((int[]) [2, 4, 6, 16]));
    }
}
