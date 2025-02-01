using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03000Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03000();
        Assert.That(sut.AreaOfMaxDiagonal(new[] {new[] {9, 3}, new[] {8, 6}}), Is.EqualTo(48));
    }

    [Test]
    public void T2()
    {
        var sut = new S03000();
        Assert.That(sut.AreaOfMaxDiagonal(new[] {new[] {3, 4}, new[] {4, 3}}), Is.EqualTo(12));
    }
}