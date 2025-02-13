using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03066Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03066();
        Assert.That(sut.MinOperations([2, 11, 10, 1, 3], 10), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03066();
        Assert.That(sut.MinOperations([1, 1, 2, 4, 9], 20), Is.EqualTo(4));
    }
}
