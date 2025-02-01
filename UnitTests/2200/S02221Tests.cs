using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02221Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02221();
        Assert.That(sut.TriangularSum(new[] {1, 2, 3, 4, 5}), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S02221();
        Assert.That(sut.TriangularSum(new[] {5}), Is.EqualTo(5));
    }
}