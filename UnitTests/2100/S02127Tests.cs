using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02127Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02127();
        Assert.That(sut.MaximumInvitations([2, 2, 1, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02127();
        Assert.That(sut.MaximumInvitations([1, 2, 0]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02127();
        Assert.That(sut.MaximumInvitations([3, 0, 1, 4, 1]), Is.EqualTo(4));
    }
}
