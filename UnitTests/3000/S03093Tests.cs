using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03093))]
public class S03093Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03093();
        Assert.That(sut.StringIndices(["abcd", "bcd", "xbcd"], ["cd", "bcd", "xyz"]), Is.EqualTo([1, 1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03093();
        Assert.That(sut.StringIndices(["abcdefgh", "poiuygh", "ghghgh"], ["gh", "acbfgh", "acbfegh"]), Is.EqualTo([2, 0, 2]));
    }
}