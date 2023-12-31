using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02970Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02970();
        sut.IncremovableSubarrayCount(new[] {1, 2, 3, 4}).Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S02970();
        sut.IncremovableSubarrayCount(new[] {6, 5, 7, 8}).Should().Be(7);
    }

    [Test]
    public void T3()
    {
        var sut = new S02970();
        sut.IncremovableSubarrayCount(new[] {8, 7, 6, 6}).Should().Be(3);
    }
}