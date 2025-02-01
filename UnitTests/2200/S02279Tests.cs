using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02279Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02279();
        Assert.That(sut.MaximumBags(new[] {2, 3, 4, 5}, new[] {1, 2, 4, 4}, 2), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02279();
        Assert.That(sut.MaximumBags(new[] {10,2,2}, new[] {2, 2, 0}, 100), Is.EqualTo(3));
    }
}