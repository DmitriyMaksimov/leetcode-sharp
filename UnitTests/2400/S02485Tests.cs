using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02485Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02485();
        sut.PivotInteger(8).Should().Be(6);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02485();
        sut.PivotInteger(1).Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02485();
        sut.PivotInteger(4).Should().Be(-1);
    }
}