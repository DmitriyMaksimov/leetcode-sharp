using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00697Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00697();
        Assert.That(sut.FindShortestSubArray([1, 2, 2, 3, 1]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00697();
        Assert.That(sut.FindShortestSubArray([1, 2, 2, 3, 1, 4, 2]), Is.EqualTo(6));
    }
}