using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02239Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02239();
        sut.FindClosestNumber(new[] {-4, -2, 1, 4, 8}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02239();
        sut.FindClosestNumber(new[] {2, -1, 1}).Should().Be(1);
    }
}