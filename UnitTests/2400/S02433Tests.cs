using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02433Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02433();
        Assert.That(sut.FindArray(new[] {5, 2, 0, 3, 1}), Is.EqualTo((int[]) [5, 7, 2, 3, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02433();
        Assert.That(sut.FindArray(new[] {13}), Is.EqualTo((int[]) [13]));
    }
}