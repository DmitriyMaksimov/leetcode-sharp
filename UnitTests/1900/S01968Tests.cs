using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01968Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01968();
        Assert.That(sut.RearrangeArray([1, 2, 3, 4, 5]), Is.EqualTo([1, 3, 2, 5, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01968();
        Assert.That(sut.RearrangeArray([6, 2, 0, 9, 7]), Is.EqualTo([6, 0, 9, 2, 7]));
    }
}
