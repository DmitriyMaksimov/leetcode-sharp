using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02571Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02571();
        Assert.That(sut.MinOperations(39), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S02571();
        Assert.That(sut.MinOperations(54), Is.EqualTo(3));
    }
}
