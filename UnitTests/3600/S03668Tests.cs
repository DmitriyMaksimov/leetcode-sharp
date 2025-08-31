using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03668))]
public class S03668Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03668();
        Assert.That(sut.RecoverOrder([3, 1, 2, 5, 4], [1, 3, 4]), Is.EqualTo([3, 1, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03668();
        Assert.That(sut.RecoverOrder([1, 4, 5, 3, 2], [2, 5]), Is.EqualTo([5, 2]));
    }
}