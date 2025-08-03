using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00740Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00740();
        Assert.That(sut.DeleteAndEarn([3, 4, 2]), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S00740();
        Assert.That(sut.DeleteAndEarn([2, 2, 3, 3, 3, 4]), Is.EqualTo(9));
    }
}