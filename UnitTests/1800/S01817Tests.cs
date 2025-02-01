using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01817Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01817();
        Assert.That(sut.FindingUsersActiveMinutes(new[] {new[] {0, 5}, new[] {1, 2}, new[] {0, 2}, new[] {0, 5}, new[] {1, 3}}, 5), Is.EqualTo((int[]) [0, 2, 0, 0, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01817();
        Assert.That(sut.FindingUsersActiveMinutes(new[] {new[] {1, 1}, new[] {2, 2}, new[] {2, 3}}, 4), Is.EqualTo((int[]) [1, 1, 0, 0]));
    }
}