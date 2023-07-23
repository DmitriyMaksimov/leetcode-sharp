namespace UnitTests;

[TestFixture]
public class S00154Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00154();
        sut.FindMin(new[] {1, 3, 5}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S00154();
        sut.FindMin(new[] {2, 2, 2, 0, 1}).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00154();
        sut.FindMin(new[] {3, 3, 1, 3}).Should().Be(1);
    }
}