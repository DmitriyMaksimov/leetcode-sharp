using leetcode_sharp._0300;

namespace UnitTests;

[TestFixture]
public class S00319Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00319();
        sut.BulbSwitch(3).Should().Be(1);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00319();
        sut.BulbSwitch(0).Should().Be(0);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00319();
        sut.BulbSwitch(1).Should().Be(1);
    }
}