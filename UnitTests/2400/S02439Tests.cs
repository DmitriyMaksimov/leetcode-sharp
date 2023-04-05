using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02439Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02439();
        sut.MinimizeArrayValue(new[] { 3,7,1,6}).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S02439();
        sut.MinimizeArrayValue(new[] {10,1 }).Should().Be(10);
    }
}