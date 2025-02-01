using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00089Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00089();
        Assert.That(sut.GrayCode(2), Is.EqualTo((int[]) [0, 1, 3, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00089();
        Assert.That(sut.GrayCode(1), Is.EqualTo((int[]) [0, 1]));
    }
}
