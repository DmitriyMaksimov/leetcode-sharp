using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01822Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01822();
        sut.ArraySign(new[] {-1,-2,-3,-4,3,2,1}).Should().Be(1);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01822();
        sut.ArraySign(new[] {1,5,0,2,-3}).Should().Be(0);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S01822();
        sut.ArraySign(new[] {-1,1,-1,1,-1}).Should().Be(-1);
    }
}