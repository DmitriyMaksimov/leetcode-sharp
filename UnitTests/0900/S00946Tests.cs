using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00946Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00946();
        sut.ValidateStackSequences(new[] {1, 2, 3, 4, 5}, new[] {4, 5, 3, 2, 1}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00946();
        sut.ValidateStackSequences(new[] {1, 2, 3, 4, 5}, new[] {4, 3, 5, 1, 2}).Should().BeFalse();
    }
}