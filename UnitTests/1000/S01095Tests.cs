using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01095Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01095();
        var mountainArray = new S01095.MountainArray(new[] {1, 2, 3, 4, 5, 3, 1});
        sut.FindInMountainArray(3, mountainArray).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01095();
        var mountainArray = new S01095.MountainArray(new[] {0, 1, 2, 4, 2, 1});
        sut.FindInMountainArray(3, mountainArray).Should().Be(-1);
    }
}