using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01170Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01170();
        Assert.That(sut.NumSmallerByFrequency(["cbd"], ["zaaaz"]), Is.EqualTo((int[]) [1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01170();
        Assert.That(sut.NumSmallerByFrequency(["bbb", "cc"], ["a", "aa", "aaa", "aaaa"]), Is.EqualTo((int[]) [1, 2]));
    }
}
