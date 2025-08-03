using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01406Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01406();
        Assert.That(sut.StoneGameIII([1,2,3,7]), Is.EqualTo("Bob"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01406();
        Assert.That(sut.StoneGameIII([1,2,3,-9]), Is.EqualTo("Alice"));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01406();
        Assert.That(sut.StoneGameIII([1,2,3,6]), Is.EqualTo("Tie"));
    }
}
