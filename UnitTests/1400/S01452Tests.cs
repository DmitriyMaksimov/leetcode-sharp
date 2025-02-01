using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01452Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01452();
        Assert.That(sut.PeopleIndexes([["leetcode", "google", "facebook"], ["google", "microsoft"], ["google", "facebook"], ["google"], ["amazon"]]), Is.EqualTo((int[]) [0, 1, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01452();
        Assert.That(sut.PeopleIndexes([["leetcode", "google", "facebook"], ["leetcode", "amazon"], ["facebook", "google"]]), Is.EqualTo((int[]) [0, 1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01452();
        Assert.That(sut.PeopleIndexes([["leetcode"], ["google"], ["facebook"], ["amazon"]]), Is.EqualTo((int[]) [0, 1, 2, 3]));
    }
}
