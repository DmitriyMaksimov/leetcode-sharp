using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00319Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00319();
        Assert.That(sut.BulbSwitch(3), Is.EqualTo(1));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00319();
        Assert.That(sut.BulbSwitch(0), Is.EqualTo(0));
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00319();
        Assert.That(sut.BulbSwitch(1), Is.EqualTo(1));
    }
}