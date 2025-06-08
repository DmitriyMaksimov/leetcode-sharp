using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02374))]
public class S02374Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02374();
        Assert.That(sut.EdgeScore([1, 0, 0, 0, 0, 7, 7, 5]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S02374();
        Assert.That(sut.EdgeScore([2, 0, 0, 2]), Is.EqualTo(0));
    }
}
