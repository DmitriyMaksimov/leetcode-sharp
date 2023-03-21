using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01567Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01567();
        sut.GetMaxLen(new []{1,-2,-3,4}).Should().Be(4);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S01567();
        sut.GetMaxLen(new []{0,1,-2,-3,-4}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01567();
        sut.GetMaxLen(new []{-1,-2,-3,0,1}).Should().Be(2);
    }
}