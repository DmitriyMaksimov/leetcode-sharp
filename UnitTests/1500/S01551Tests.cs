using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01551Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01551();
        Assert.That(sut.MinOperations(3), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01551();
        Assert.That(sut.MinOperations(6), Is.EqualTo(9));
    }
}