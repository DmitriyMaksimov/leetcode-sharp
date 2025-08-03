using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01817Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01817();
        Assert.That(sut.FindingUsersActiveMinutes([
            [0, 5], [1, 2], [0, 2], [0, 5], [1, 3]
        ], 5), Is.EqualTo((int[]) [0, 2, 0, 0, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01817();
        Assert.That(sut.FindingUsersActiveMinutes([[1, 1], [2, 2], [2, 3]], 4), Is.EqualTo((int[]) [1, 1, 0, 0]));
    }
}