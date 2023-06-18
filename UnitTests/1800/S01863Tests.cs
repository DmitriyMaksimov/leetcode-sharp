using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01863Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01863();
        sut.SubsetXORSum(new[] {1, 3}).Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S01863();
        sut.SubsetXORSum(new[] {5, 1, 6}).Should().Be(28);
    }

    [Test]
    public void T3()
    {
        var sut = new S01863();
        sut.SubsetXORSum(new[] {3, 4, 5, 6, 7, 8}).Should().Be(480);
    }
}