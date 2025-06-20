namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03443))]
public class S03443Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03443();
        Assert.That(sut.MaxDistance("NWSE", 1), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03443();
        Assert.That(sut.MaxDistance("NSWWEW", 3), Is.EqualTo(6));
    }
}