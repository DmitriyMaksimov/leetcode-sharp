using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02358Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02358();
        Assert.That(sut.MaximumGroups([10, 6, 12, 7, 3, 5]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02358();
        Assert.That(sut.MaximumGroups([8, 8]), Is.EqualTo(1));
    }
}
