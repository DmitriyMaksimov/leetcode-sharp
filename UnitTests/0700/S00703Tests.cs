using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00703Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00703.KthLargest(3, new[] {4, 5, 8, 2});
        Assert.That(sut.Add(3), Is.EqualTo(4));
        Assert.That(sut.Add(5), Is.EqualTo(5));
        Assert.That(sut.Add(10), Is.EqualTo(5));
        Assert.That(sut.Add(9), Is.EqualTo(8));
        Assert.That(sut.Add(4), Is.EqualTo(8));
    }
}