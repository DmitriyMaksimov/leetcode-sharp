using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S00066))]
public class S00066Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00066();
        Assert.That(sut.PlusOne([1, 2, 3]), Is.EqualTo([1, 2, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00066();
        Assert.That(sut.PlusOne([4, 3, 2, 1]), Is.EqualTo([4, 3, 2, 2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00066();
        Assert.That(sut.PlusOne([9]), Is.EqualTo([1, 0]));
    }
}