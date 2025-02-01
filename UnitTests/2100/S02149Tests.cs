using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02149Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02149();
        Assert.That(sut.RearrangeArray(new[] {3, 1, -2, -5, 2, -4}), Is.EqualTo((int[]) [3, -2, 1, -5, 2, -4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02149();
        Assert.That(sut.RearrangeArray(new[] {-1, 1}), Is.EqualTo((int[]) [1, -1]));
    }
}