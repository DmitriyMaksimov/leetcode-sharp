using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03427Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03427();
        Assert.That(sut.SubarraySum([2, 3, 1]), Is.EqualTo(11));
    }

    [Test]
    public void T2()
    {
        var sut = new S03427();
        Assert.That(sut.SubarraySum([3, 1, 1, 2]), Is.EqualTo(13));
    }
}
