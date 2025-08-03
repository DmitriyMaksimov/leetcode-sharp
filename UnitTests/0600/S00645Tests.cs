using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00645Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00645();
        Assert.That(sut.FindErrorNums([1, 2, 2, 4]), Is.EqualTo((int[]) [2, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00645();
        Assert.That(sut.FindErrorNums([1, 1]), Is.EqualTo((int[]) [1, 2]));
    }

}