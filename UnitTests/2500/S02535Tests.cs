using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02535Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02535();
        sut.DifferenceOfSum(new[] {1, 15, 6, 3}).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02535();
        sut.DifferenceOfSum(new[] {1, 2, 3, 4}).Should().Be(0);
    }
}