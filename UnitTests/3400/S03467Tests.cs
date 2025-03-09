using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03467Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03467();
        Assert.That(sut.TransformArray([4, 3, 2, 1]), Is.EqualTo([0, 0, 1, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03467();
        Assert.That(sut.TransformArray([1, 5, 1, 4, 2]), Is.EqualTo([0, 0, 1, 1, 1]));
    }
}
