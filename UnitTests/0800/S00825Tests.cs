using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00825Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00825();
        Assert.That(sut.NumFriendRequests([16, 16]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00825();
        Assert.That(sut.NumFriendRequests([16, 17, 18]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00825();
        Assert.That(sut.NumFriendRequests([20, 30, 100, 110, 120]), Is.EqualTo(3));
    }
}
