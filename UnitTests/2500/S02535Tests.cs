using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02535Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02535();
        Assert.That(sut.DifferenceOfSum([1, 15, 6, 3]), Is.EqualTo(9));
    }

    [Test]
    public void T2()
    {
        var sut = new S02535();
        Assert.That(sut.DifferenceOfSum([1, 2, 3, 4]), Is.EqualTo(0));
    }
}