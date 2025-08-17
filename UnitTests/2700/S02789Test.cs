using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02789))]
public class S02789Test
{
    [Test]
    public void T1()
    {
        var sut = new S02789();
        Assert.That(sut.MaxArrayValue([2, 3, 7, 9, 3]), Is.EqualTo(21));
    }

    [Test]
    public void T2()
    {
        var sut = new S02789();
        Assert.That(sut.MaxArrayValue([5, 3, 3]), Is.EqualTo(11));
    }
}