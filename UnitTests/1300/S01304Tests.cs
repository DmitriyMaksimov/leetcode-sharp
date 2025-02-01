using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01304Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01304();
        var sumZero = sut.SumZero(5);
        Assert.That(sumZero, Has.Length.EqualTo(5));
        Assert.That(sumZero, Is.Unique);
        Assert.That(sumZero.Sum(), Is.EqualTo(0));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01304();
        var sumZero = sut.SumZero(3);
        Assert.That(sumZero, Has.Length.EqualTo(3));
        Assert.That(sumZero, Is.Unique);
        Assert.That(sumZero.Sum(), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01304();
        var sumZero = sut.SumZero(1);
        Assert.That(sumZero, Has.Length.EqualTo(1));
        Assert.That(sumZero, Is.Unique);
        Assert.That(sumZero.Sum(), Is.EqualTo(0));
    }
}
