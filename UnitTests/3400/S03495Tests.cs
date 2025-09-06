using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03495))]
public class S03495Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03495();
        Assert.That(sut.MinOperations([[1, 2], [2, 4]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S03495();
        Assert.That(sut.MinOperations([[2, 6]]), Is.EqualTo(4));
    }
}