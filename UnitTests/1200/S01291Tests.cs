using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01291Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01291();
        Assert.That(sut.SequentialDigits(100, 300), Is.EqualTo((int[]) [123, 234]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01291();
        Assert.That(sut.SequentialDigits(1000, 13000), Is.EqualTo((int[]) [1234, 2345, 3456, 4567, 5678, 6789, 12345]));
    }
}