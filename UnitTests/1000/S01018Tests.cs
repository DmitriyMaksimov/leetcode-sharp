using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01018Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01018();
        Assert.That(sut.PrefixesDivBy5([0, 1, 1]), Is.EqualTo((bool[]) [true, false, false]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01018();
        Assert.That(sut.PrefixesDivBy5([1, 1, 1]), Is.EqualTo((bool[]) [false, false, false]));
    }
}
