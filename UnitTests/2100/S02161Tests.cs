using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02161Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02161();
        Assert.That(sut.PivotArray([9, 12, 5, 10, 14, 3, 10], 10), Is.EqualTo((int[]) [9, 5, 3, 10, 10, 12, 14]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02161();
        Assert.That(sut.PivotArray([-3, 4, 3, 2], 2), Is.EqualTo((int[]) [-3, 2, 4, 3]));
    }
}