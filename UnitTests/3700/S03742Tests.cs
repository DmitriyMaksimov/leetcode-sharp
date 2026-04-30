using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03742))]
public class S03742Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03742();
        Assert.That(sut.MaxPathScore([[0, 1], [2, 0]], 1), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03742();
        Assert.That(sut.MaxPathScore([[0, 1], [1, 2]], 1), Is.EqualTo(-1));
    }
}