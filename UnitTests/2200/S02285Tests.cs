using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02285Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02285();
        Assert.That(sut.MaximumImportance(5, [[0, 1], [1, 2], [2, 3], [0, 2], [1, 3], [2, 4]]), Is.EqualTo(43));
    }

    [Test]
    public void T2()
    {
        var sut = new S02285();
        Assert.That(sut.MaximumImportance(5, [[0, 3], [2, 4], [1, 3]]), Is.EqualTo(20));
    }
}