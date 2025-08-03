namespace UnitTests;

[TestFixture]
public class S00153Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00153();
        Assert.That(sut.FindMin([3, 4, 5, 1, 2]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00153();
        Assert.That(sut.FindMin([4, 5, 6, 7, 0, 1, 2]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S00153();
        Assert.That(sut.FindMin([11, 13, 15, 17]), Is.EqualTo(11));
    }
}