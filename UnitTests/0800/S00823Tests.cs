using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00823Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00823();
        sut.NumFactoredBinaryTrees(new[] {2, 4}).Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00823();
        sut.NumFactoredBinaryTrees(new[] {2, 4, 5, 10}).Should().Be(7);
    }
}