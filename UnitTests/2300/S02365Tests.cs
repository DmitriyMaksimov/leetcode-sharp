using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02365Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02365();
        sut.TaskSchedulerII([1, 2, 1, 2, 3, 1], 3).Should().Be(9);
    }

    [Test]
    public void T2()
    {
        var sut = new S02365();
        sut.TaskSchedulerII([5, 8, 8, 5], 2).Should().Be(6);
    }
}
