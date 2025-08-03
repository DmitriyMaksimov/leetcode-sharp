using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00035Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00035();
        Assert.That(sut.SearchInsert([1, 3, 5, 6], 5), Is.EqualTo(2));
    }

    [Test]
    public void Test2()
    {
        var sut = new S00035();
        Assert.That(sut.SearchInsert([1, 3, 5, 6], 2), Is.EqualTo(1));
    }

    [Test]
    public void Test3()
    {
        var sut = new S00035();
        Assert.That(sut.SearchInsert([1, 3, 5, 6], 7), Is.EqualTo(4));
    }
}