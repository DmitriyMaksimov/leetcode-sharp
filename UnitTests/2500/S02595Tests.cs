using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02595Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02595();
        Assert.That(sut.EvenOddBit(17), Is.EqualTo((int[]) [2, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02595();
        Assert.That(sut.EvenOddBit(2), Is.EqualTo((int[]) [0, 1]));
    }
}