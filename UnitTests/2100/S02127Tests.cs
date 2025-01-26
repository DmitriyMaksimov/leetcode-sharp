using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02127Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02127();
        sut.MaximumInvitations([2, 2, 1, 2]).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02127();
        sut.MaximumInvitations([1, 2, 0]).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02127();
        sut.MaximumInvitations([3, 0, 1, 4, 1]).Should().Be(4);
    }
}
