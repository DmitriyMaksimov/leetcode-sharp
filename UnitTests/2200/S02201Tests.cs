using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02201Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02201();
        Assert.That(sut.DigArtifacts(2, [[0, 0, 0, 0], [0, 1, 1, 1]], [[0, 0], [0, 1]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02201();
        Assert.That(sut.DigArtifacts(2, [[0, 0, 0, 0], [0, 1, 1, 1]], [[0, 0], [0, 1], [1, 1]]), Is.EqualTo(2));
    }
}
