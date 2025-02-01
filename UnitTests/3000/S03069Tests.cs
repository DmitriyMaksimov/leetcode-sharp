using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03069Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03069();
        Assert.That(sut.ResultArray([2, 1, 3]), Is.EqualTo((int[]) [2, 3, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03069();
        Assert.That(sut.ResultArray([5, 4, 3, 8]), Is.EqualTo((int[]) [5, 3, 4, 8]));
    }
}