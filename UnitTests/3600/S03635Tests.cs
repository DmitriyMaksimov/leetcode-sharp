using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03635))]
public class S03635Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03635();
        Assert.That(sut.EarliestFinishTime([2, 8], [4, 1], [6], [3]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S03635();
        Assert.That(sut.EarliestFinishTime([5], [3], [1], [10]), Is.EqualTo(14));
    }
}