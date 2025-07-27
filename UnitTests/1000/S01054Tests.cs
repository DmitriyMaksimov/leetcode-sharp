using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01054))]
public class S01054Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01054();
        Assert.That(sut.RearrangeBarcodes([1, 1, 1, 2, 2, 2]), Is.EqualTo([1, 2, 1, 2, 1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01054();
        Assert.That(sut.RearrangeBarcodes([1, 1, 1, 1, 2, 2, 3, 3]), Is.EqualTo([1, 2, 1, 2, 1, 3, 1, 3]));
    }
}