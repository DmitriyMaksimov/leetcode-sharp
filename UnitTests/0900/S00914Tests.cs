using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00914Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00914();
        Assert.That(sut.HasGroupsSizeX(new[] {1, 2, 3, 4, 4, 3, 2, 1}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00914();
        Assert.That(sut.HasGroupsSizeX(new[] {1, 1, 1, 2, 2, 2, 3, 3}), Is.False);
    }
}
