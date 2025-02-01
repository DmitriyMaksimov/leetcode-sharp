using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00823Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00823();
        Assert.That(sut.NumFactoredBinaryTrees(new[] {2, 4}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00823();
        Assert.That(sut.NumFactoredBinaryTrees(new[] {2, 4, 5, 10}), Is.EqualTo(7));
    }
}