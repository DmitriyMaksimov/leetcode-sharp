using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01700Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01700();
        Assert.That(sut.CountStudents([1, 1, 0, 0], [0, 1, 0, 1]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S01700();
        Assert.That(sut.CountStudents([1, 1, 1, 0, 0, 1], [1, 0, 0, 0, 1, 1]), Is.EqualTo(3));
    }
}