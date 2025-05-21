using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02216))]
public class S02216Test
{
    [Test]
    public void T1()
    {
        var sut = new S02216();
        Assert.That(sut.MinDeletion([1, 1, 2, 3, 5]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02216();
        Assert.That(sut.MinDeletion([1, 1, 2, 2, 3, 3]), Is.EqualTo(2));
    }
}
