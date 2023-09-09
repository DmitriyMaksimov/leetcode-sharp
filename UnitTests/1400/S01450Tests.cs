using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01450Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01450();
        sut.BusyStudent(new[] {1, 2, 3}, new[] {3, 2, 7}, 4).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01450();
        sut.BusyStudent(new[] {4}, new[] {4}, 4).Should().Be(1);
    }
}