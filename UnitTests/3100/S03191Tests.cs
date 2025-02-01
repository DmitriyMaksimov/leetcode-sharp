using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03191Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03191();
        Assert.That(sut.MinOperations([0, 1, 1, 1, 0, 0]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03191();
        Assert.That(sut.MinOperations([0, 1, 1, 1]), Is.EqualTo(-1));
    }
}
