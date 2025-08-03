using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00169Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00169();
        Assert.That(sut.MajorityElement([3, 2, 3]), Is.EqualTo(3));
    }

    [Test]
    public void Test2()
    {
        var sut = new S00169();
        Assert.That(sut.MajorityElement([2, 2, 1, 1, 1, 2, 2]), Is.EqualTo(2));
    }

    [Test]
    public void Test3()
    {
        var sut = new S00169();
        Assert.That(sut.MajorityElement([1]), Is.EqualTo(1));
    }

    [Test]
    public void Test4()
    {
        var sut = new S00169();
        Assert.That(sut.MajorityElement([3, 3, 4]), Is.EqualTo(3));
    }

    [Test]
    public void Test5()
    {
        var sut = new S00169();
        Assert.That(sut.MajorityElement([-1, 1, 1, 1, 2, 1]), Is.EqualTo(1));
    }
}