using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02197))]
public class S02197Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02197();
        Assert.That(sut.ReplaceNonCoprimes([6, 4, 3, 2, 7, 6, 2]), Is.EqualTo([12, 7, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02197();
        Assert.That(sut.ReplaceNonCoprimes([2, 2, 1, 1, 3, 3, 3]), Is.EqualTo([2, 1, 1, 3]));
    }
}