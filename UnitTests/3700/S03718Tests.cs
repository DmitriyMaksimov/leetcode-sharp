using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03718))]
public class S03718Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03718();
        Assert.That(sut.MissingMultiple([8, 2, 3, 4, 6], 2), Is.EqualTo(10));
    }

    [Test]
    public void T2()
    {
        var sut = new S03718();
        Assert.That(sut.MissingMultiple([1, 4, 7, 10, 15], 5), Is.EqualTo(5));
    }
}