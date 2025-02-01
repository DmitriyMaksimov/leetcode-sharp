using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02540Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02540();
        Assert.That(sut.GetCommon(new[] {1, 2, 3}, new[] {2, 4}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02540();
        Assert.That(sut.GetCommon(new[] {1, 2, 3, 6}, new[] {2, 3, 4, 5}), Is.EqualTo(2));
    }
}