using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01420Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01420();
        Assert.That(sut.NumOfArrays(2, 3, 1), Is.EqualTo(6));
    }

    [Test]
    public void T2()
    {
        var sut = new S01420();
        Assert.That(sut.NumOfArrays(5, 2, 3), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01420();
        Assert.That(sut.NumOfArrays(9, 1, 1), Is.EqualTo(1));
    }
}