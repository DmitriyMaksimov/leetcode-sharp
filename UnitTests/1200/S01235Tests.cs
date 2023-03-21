using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01235UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S01235();
        sut.JobScheduling(new[] {1, 2, 3, 3}, new[] {3, 4, 5, 6}, new[] {50, 10, 40, 70}).Should().Be(120);
    }

    [Test]
    public void Test2()
    {
        var sut = new S01235();
        sut.JobScheduling(new[] {1, 2, 3, 4, 6}, new[] {3, 5, 10, 6, 9}, new[] {20, 20, 100, 70, 60}).Should().Be(150);
    }

    [Test]
    public void Test3()
    {
        var sut = new S01235();
        sut.JobScheduling(new[] {1, 1, 1}, new[] {2, 3, 4}, new[] {5, 6, 4}).Should().Be(6);
    }
}