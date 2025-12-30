using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03674))]
public class S03674Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03674();
        Assert.That(sut.MinOperations([1, 2]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03674();
        Assert.That(sut.MinOperations([5, 5, 5]), Is.Zero);
    }
}