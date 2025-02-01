using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00386Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00386();
        Assert.That(sut.LexicalOrder(13), Is.EqualTo((int[]) [1, 10, 11, 12, 13, 2, 3, 4, 5, 6, 7, 8, 9]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00386();
        Assert.That(sut.LexicalOrder(2), Is.EqualTo((int[]) [1, 2]));
    }
}
