using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00806Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00806();
        Assert.That(sut.NumberOfLines([10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], "abcdefghijklmnopqrstuvwxyz"), Is.EqualTo((int[]) [3, 60]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00806();
        Assert.That(sut.NumberOfLines([4,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10], "bbbcccdddaaa"), Is.EqualTo((int[]) [2, 4]));
    }
}