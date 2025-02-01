using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01523Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01523();
        Assert.That(sut.CountOdds(3, 7), Is.EqualTo(3));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01523();
        Assert.That(sut.CountOdds(8, 10), Is.EqualTo(1));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01523();
        Assert.That(sut.CountOdds(8, 9), Is.EqualTo(1));
    }
    
    [Test]
    public void T4()
    {
        var sut = new S01523();
        Assert.That(sut.CountOdds(8, 11), Is.EqualTo(2));
    }
    
    [Test]
    public void T5()
    {
        var sut = new S01523();
        Assert.That(sut.CountOdds(6, 6), Is.EqualTo(0));
    }
    
    [Test]
    public void T6()
    {
        var sut = new S01523();
        Assert.That(sut.CountOdds(7, 7), Is.EqualTo(1));
    }
    
    [Test]
    public void T7()
    {
        var sut = new S01523();
        Assert.That(sut.CountOdds(0, 0), Is.EqualTo(0));
    }
}