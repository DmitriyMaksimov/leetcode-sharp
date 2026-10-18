using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03925))]
public class S03925Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03925();
        Assert.That(sut.ConcatWithReverse([1, 2, 3]), Is.EqualTo([1, 2, 3, 3, 2, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03925();
        Assert.That(sut.ConcatWithReverse([1]), Is.EqualTo([1, 1]));
    }
}