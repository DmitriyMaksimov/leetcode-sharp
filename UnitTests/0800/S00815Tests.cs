using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00815Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00815();
        Assert.That(sut.NumBusesToDestination([[1, 2, 7], [3, 6, 7]], 1, 6), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00815();
        Assert.That(sut.NumBusesToDestination([
            [7, 12], [4, 5, 15], [6], [15, 19], [9, 12, 13]
        ], 15, 12), Is.EqualTo(-1));
    }
}