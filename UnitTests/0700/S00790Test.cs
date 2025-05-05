using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00790))]
public class S00790Test
{
    [Test]
    public void T1()
    {
        var sut = new S00790();
        Assert.That(sut.NumTilings(3), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S00790();
        Assert.That(sut.NumTilings(1), Is.EqualTo(1));
    }
}
