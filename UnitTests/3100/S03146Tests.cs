using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03146Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03146();
        Assert.That(sut.FindPermutationDifference("abc", "bac"), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03146();
        Assert.That(sut.FindPermutationDifference("abcde", "edbac"), Is.EqualTo(12));
    }
}