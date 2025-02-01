using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00932Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00932();
        Assert.That(sut.BeautifulArray(4), Is.EqualTo((int[]) [1, 3, 2, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00932();
        Assert.That(sut.BeautifulArray(5), Is.EqualTo((int[]) [1, 5, 3, 2, 4]));
    }
}
