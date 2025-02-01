using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01235Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S01235();
        Assert.That(sut.JobScheduling(new[] {1, 2, 3, 3}, new[] {3, 4, 5, 6}, new[] {50, 10, 40, 70}), Is.EqualTo(120));
    }

    [Test]
    public void Test2()
    {
        var sut = new S01235();
        Assert.That(sut.JobScheduling(new[] {1, 2, 3, 4, 6}, new[] {3, 5, 10, 6, 9}, new[] {20, 20, 100, 70, 60}), Is.EqualTo(150));
    }

    [Test]
    public void Test3()
    {
        var sut = new S01235();
        Assert.That(sut.JobScheduling(new[] {1, 1, 1}, new[] {2, 3, 4}, new[] {5, 6, 4}), Is.EqualTo(6));
    }
}