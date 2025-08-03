using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02657Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02657();
        Assert.That(sut.FindThePrefixCommonArray([1, 3, 2, 4], [3, 1, 2, 4]), Is.EqualTo((int[]) [0, 2, 3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02657();
        Assert.That(sut.FindThePrefixCommonArray([2, 3, 1], [3, 1, 2]), Is.EqualTo((int[]) [0, 1, 3]));
    }
}