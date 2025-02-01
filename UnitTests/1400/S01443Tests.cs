using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01443Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01443();
        Assert.That(sut.MinTime(7, new[] {new[] {0, 1}, new[] {0, 2}, new[] {1, 4}, new[] {1, 5}, new[] {2, 3}, new[] {2, 6}}, new[] {false, false, true, false, true, true, false}), Is.EqualTo(8));
    }

    [Test]
    public void T2()
    {
        var sut = new S01443();
        Assert.That(sut.MinTime(7, new[] {new[] {0, 1}, new[] {0, 2}, new[] {1, 4}, new[] {1, 5}, new[] {2, 3}, new[] {2, 6}}, new[] {false,false,false,false,false,false,false}), Is.EqualTo(0));
    }
}