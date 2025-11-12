using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02654))]
public class S02654Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02654();
        Assert.That(sut.MinOperations([2, 6, 3, 4]), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02654();
        Assert.That(sut.MinOperations([2, 10, 6, 14]), Is.EqualTo(-1));
    }
}