using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00766Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00766();
        sut.IsToeplitzMatrix(new[] {new[] {1, 2, 3, 4}, new[] {5, 1, 2, 3}, new[] {9, 5, 1, 2}}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00766();
        sut.IsToeplitzMatrix(new[] {new[] {1, 2}, new[] {2, 2}}).Should().BeFalse();
    }
}