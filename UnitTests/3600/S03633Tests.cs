using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03633))]
public class S03633Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03633();
        Assert.That(sut.EarliestFinishTime([2, 8], [4, 1], [6], [3]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S03633();
        Assert.That(sut.EarliestFinishTime([5], [3], [1], [10]), Is.EqualTo(14));
    }
}