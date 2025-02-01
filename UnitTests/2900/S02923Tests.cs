using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02923Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02923();
        Assert.That(sut.FindChampion(new[] {new[] {0, 1}, new[] {0, 0}}), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S02923();
        Assert.That(sut.FindChampion(new[] {new[] {0, 0, 1}, new[] {1, 0, 1}, new[] {0, 0, 0}}), Is.EqualTo(1));
    }
}