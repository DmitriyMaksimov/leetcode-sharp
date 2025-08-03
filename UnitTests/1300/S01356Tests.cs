using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01356Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01356();
        Assert.That(sut.SortByBits([0, 1, 2, 3, 4, 5, 6, 7, 8]), Is.EqualTo((int[]) [0, 1, 2, 4, 8, 3, 5, 6, 7]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01356();
        Assert.That(sut.SortByBits([1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1]), Is.EqualTo((int[]) [1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024]));
    }
}
