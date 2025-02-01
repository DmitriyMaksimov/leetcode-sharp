using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00540Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00540();
        Assert.That(sut.SingleNonDuplicate(new[] {1, 1, 2, 3, 3, 4, 4, 8, 8}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00540();
        Assert.That(sut.SingleNonDuplicate(new[] {3,3,7,7,10,11,11}), Is.EqualTo(10));
    }
}