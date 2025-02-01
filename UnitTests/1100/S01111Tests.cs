using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01111Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01111();
        Assert.That(sut.MaxDepthAfterSplit("(()())"), Is.EqualTo((int[]) [0, 1, 1, 1, 1, 0]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01111();
        Assert.That(sut.MaxDepthAfterSplit("()(())()"), Is.EqualTo((int[]) [0, 0, 0, 1, 1, 0, 0, 0]));
    }
}