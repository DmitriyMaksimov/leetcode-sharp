using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02448Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02448();
        sut.MinCost(new[] {1, 3, 5, 2}, new[] {2, 3, 1, 14}).Should().Be(8);
    }

    [Test]
    public void T2()
    {
        var sut = new S02448();
        sut.MinCost(new[] {2, 2, 2, 2, 2}, new[] {4, 2, 8, 1, 3}).Should().Be(0);
    }
}