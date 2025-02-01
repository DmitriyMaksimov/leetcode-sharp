namespace UnitTests;

[TestFixture]
public class S00096Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00096();
        Assert.That(sut.NumTrees(3), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00096();
        Assert.That(sut.NumTrees(1), Is.EqualTo(1));
    }
}