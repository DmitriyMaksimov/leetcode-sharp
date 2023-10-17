using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01361Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01361();
        sut.ValidateBinaryTreeNodes(4, new[] {1, -1, 3, -1}, new[] {2, -1, -1, -1}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01361();
        sut.ValidateBinaryTreeNodes(4, new[] {1, -1, 3, -1}, new[] {2, 3, -1, -1}).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01361();
        sut.ValidateBinaryTreeNodes(2, new[] {1, 0}, new[] {-1, -1}).Should().BeFalse();
    }
}