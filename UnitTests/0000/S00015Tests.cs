using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00015Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00015();
        sut.ThreeSum(new[] {-1, 0, 1, 2, -1, -4}).Should().BeEquivalentTo(new[] {new[] {-1, -1, 2}, new[] {-1, 0, 1}});
    }

    [Test]
    public void T2()
    {
        var sut = new S00015();
        Assert.That(sut.ThreeSum(new[] {0, 1, 1}), Is.Empty);
    }

    [Test]
    public void T3()
    {
        var sut = new S00015();
        sut.ThreeSum(new[] {0, 0, 0}).Should().BeEquivalentTo(new[] {new[] {0, 0, 0}});
    }
}