using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00134Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00134();
        Assert.That(sut.CanCompleteCircuit(new[] {1, 2, 3, 4, 5}, new[] {3, 4, 5, 1, 2}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S00134();
        Assert.That(sut.CanCompleteCircuit(new[] {2, 3, 4}, new[] {3, 4, 3}), Is.EqualTo(-1));
    }
}