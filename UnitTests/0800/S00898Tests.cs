using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00898))]
public class S00898Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00898();
        Assert.That(sut.SubarrayBitwiseORs([0]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00898();
        Assert.That(sut.SubarrayBitwiseORs([1, 1, 2]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00898();
        Assert.That(sut.SubarrayBitwiseORs([1, 2, 4]), Is.EqualTo(6));
    }
}