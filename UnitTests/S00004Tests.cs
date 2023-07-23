using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00004Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00004();
        sut.FindMedianSortedArrays(new[] {1, 2}, new[] {2}).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00004();
        sut.FindMedianSortedArrays(new[] {1, 2}, new[] {3, 4}).Should().Be(2.5);
    }
}