using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02997Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02997();
        Assert.That(sut.MinOperations([2, 1, 3, 4], 1), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02997();
        Assert.That(sut.MinOperations([2, 0, 2, 0], 0), Is.EqualTo(0));
    }
}