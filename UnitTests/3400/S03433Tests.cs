using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03433))]
public class S03433Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03433();
        Assert.That(sut.CountMentions(2, [["MESSAGE", "10", "id1 id0"], ["OFFLINE", "11", "0"], ["MESSAGE", "71", "HERE"]]), Is.EqualTo([2, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03433();
        Assert.That(sut.CountMentions(2, [["MESSAGE", "10", "id1 id0"], ["OFFLINE", "11", "0"], ["MESSAGE", "12", "ALL"]]), Is.EqualTo([2, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03433();
        Assert.That(sut.CountMentions(2, [["OFFLINE", "10", "0"], ["MESSAGE", "12", "HERE"]]), Is.EqualTo([0, 1]));
    }
}