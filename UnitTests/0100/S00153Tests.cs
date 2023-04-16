namespace UnitTests;

[TestFixture]
public class S00153Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00153();
        sut.FindMin(new[] {3,4,5,1,2 }).Should().Be(1);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00153();
        sut.FindMin(new[] {4,5,6,7,0,1,2 }).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00153();
        sut.FindMin(new[] {11,13,15,17 }).Should().Be(11);
    }
}