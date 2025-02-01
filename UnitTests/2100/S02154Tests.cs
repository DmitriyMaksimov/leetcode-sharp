using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02154Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02154();
        Assert.That(sut.FindFinalValue(new[] {5, 3, 6, 1, 12}, 3), Is.EqualTo(24));
    }

    [Test]
    public void T2()
    {
        var sut = new S02154();
        Assert.That(sut.FindFinalValue(new[] {2, 7, 9}, 4), Is.EqualTo(4));
    }
}