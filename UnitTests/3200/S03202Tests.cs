using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03202))]
public class S03202Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03202();
        Assert.That(sut.MaximumLength([1, 2, 3, 4, 5], 2), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S03202();
        Assert.That(sut.MaximumLength([1, 4, 2, 3, 1, 4], 3), Is.EqualTo(4));
    }
}