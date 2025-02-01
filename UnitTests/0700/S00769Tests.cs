using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00769Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00769();
        Assert.That(sut.MaxChunksToSorted([4, 3, 2, 1, 0]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00769();
        Assert.That(sut.MaxChunksToSorted([1, 0, 2, 3, 4]), Is.EqualTo(4));
    }
}
