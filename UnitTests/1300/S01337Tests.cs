using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01337Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01337();
        Assert.That(sut.KWeakestRows(new[] {new[] {1, 1, 0, 0, 0}, new[] {1, 1, 1, 1, 0}, new[] {1, 0, 0, 0, 0}, new[] {1, 1, 0, 0, 0}, new[] {1, 1, 1, 1, 1}}, 3), Is.EqualTo((int[]) [2, 0, 3]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01337();
        Assert.That(sut.KWeakestRows(new[] {new[] {1, 0, 0, 0}, new[] {1, 1, 1, 1}, new[] {1, 0, 0, 0}, new[] {1, 0, 0, 0}}, 2), Is.EqualTo((int[]) [0, 2]));
    }
}