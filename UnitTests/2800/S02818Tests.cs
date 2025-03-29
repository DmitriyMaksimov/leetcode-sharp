using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02818Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02818();
        Assert.That(sut.MaximumScore([8, 3, 9, 3, 8], 2), Is.EqualTo(81));
    }

    [Test]
    public void T2()
    {
        var sut = new S02818();
        Assert.That(sut.MaximumScore([19, 12, 14, 6, 10, 18], 3), Is.EqualTo(4788));
    }
}
