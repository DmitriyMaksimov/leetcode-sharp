using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02369Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02369();
        sut.ValidPartition(new[] {4, 4, 4, 5, 6}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02369();
        sut.ValidPartition(new[] {1, 1, 1, 2}).Should().BeFalse();
    }
}