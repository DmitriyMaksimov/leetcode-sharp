namespace UnitTests;

[TestFixture]
public class S00154Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00154();
        Assert.That(sut.FindMin([1, 3, 5]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00154();
        Assert.That(sut.FindMin([2, 2, 2, 0, 1]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00154();
        Assert.That(sut.FindMin([3, 3, 1, 3]), Is.EqualTo(1));
    }
}