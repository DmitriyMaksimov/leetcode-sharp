using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03192Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03192();
        Assert.That(sut.MinOperations([0, 1, 1, 0, 1]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S03192();
        Assert.That(sut.MinOperations([1, 0, 0, 0]), Is.EqualTo(1));
    }
}
