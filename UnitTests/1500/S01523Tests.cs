using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01523Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01523();
        sut.CountOdds(3, 7).Should().Be(3);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01523();
        sut.CountOdds(8, 10).Should().Be(1);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01523();
        sut.CountOdds(8, 9).Should().Be(1);
    }
    
    [Test]
    public void T4()
    {
        var sut = new S01523();
        sut.CountOdds(8, 11).Should().Be(2);
    }
    
    [Test]
    public void T5()
    {
        var sut = new S01523();
        sut.CountOdds(6, 6).Should().Be(0);
    }
    
    [Test]
    public void T6()
    {
        var sut = new S01523();
        sut.CountOdds(7, 7).Should().Be(1);
    }
    
    [Test]
    public void T7()
    {
        var sut = new S01523();
        sut.CountOdds(0, 0).Should().Be(0);
    }
}