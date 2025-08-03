using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00088Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00088();
        var nums1 = new[] {1, 2, 3, 0, 0, 0};
        sut.Merge(nums1, 3, [2, 5, 6], 3);
        Assert.That(nums1, Is.EqualTo((int[]) [1, 2, 2, 3, 5, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00088();
        var nums1 = new[] {1};
        sut.Merge(nums1, 1, [], 0);
        Assert.That(nums1, Is.EqualTo((int[]) [1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00088();
        var nums1 = new[] {0};
        sut.Merge(nums1, 0, [1], 1);
        Assert.That(nums1, Is.EqualTo((int[]) [1]));
    }
}