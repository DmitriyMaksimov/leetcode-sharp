using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03264Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03264();
        Assert.That(sut.GetFinalState([2, 1, 3, 5, 6], 5, 2), Is.EqualTo((int[]) [8, 4, 6, 5, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03264();
        Assert.That(sut.GetFinalState([1, 2], 3, 4), Is.EqualTo((int[]) [16, 8]));
    }
}
