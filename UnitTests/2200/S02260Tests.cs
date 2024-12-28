using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02260Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02260();
        sut.MinimumCardPickup([3, 4, 2, 3, 4, 7]).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02260();
        sut.MinimumCardPickup([1, 0, 5, 3]).Should().Be(-1);
    }
}
