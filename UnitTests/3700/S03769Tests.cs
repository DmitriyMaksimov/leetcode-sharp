using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03769))]
public class S03769Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03769();
        Assert.That(sut.SortByReflection([4, 5, 4]), Is.EqualTo([4, 4, 5]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03769();
        Assert.That(sut.SortByReflection([3, 6, 5, 8]), Is.EqualTo([8, 3, 6, 5]));
    }
}