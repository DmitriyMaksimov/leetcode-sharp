using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01260Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01260();
        Assert.That(sut.ShiftGrid([[1, 2, 3], [4, 5, 6], [7, 8, 9]], 1), Is.EquivalentTo([
            [9, 1, 2], [3, 4, 5], new[] {6, 7, 8}
        ]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01260();
        Assert.That(sut.ShiftGrid([
            [3, 8, 1, 9], [19, 7, 2, 5], [4, 6, 11, 10], [12, 0, 21, 13]
        ], 4), Is.EquivalentTo([[12, 0, 21, 13], [3, 8, 1, 9], [19, 7, 2, 5], new[] {4, 6, 11, 10}]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01260();
        Assert.That(sut.ShiftGrid([[1, 2, 3], [4, 5, 6], [7, 8, 9]], 9), Is.EquivalentTo([
            [1, 2, 3], [4, 5, 6], new[] {7, 8, 9}
        ]));
    }
}