using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00334Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00334();
        sut.IncreasingTriplet(new[] {1, 2, 3, 4, 5}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00334();
        sut.IncreasingTriplet(new[] {5, 4, 3, 2, 1}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S00334();
        sut.IncreasingTriplet(new[] {2, 1, 5, 0, 4, 6}).Should().BeTrue();
    }
}