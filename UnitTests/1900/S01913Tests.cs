using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01913Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01913();
        sut.MaxProductDifference(new[] { 5,6,2,7,4}).Should().Be(34);
    }

    [Test]
    public void T2()
    {
        var sut = new S01913();
        sut.MaxProductDifference(new[] {4,2,5,9,7,4,8 }).Should().Be(64);
    }
}