using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02327))]
public class S02327Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02327();
        Assert.That(sut.PeopleAwareOfSecret(6, 2, 4), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S02327();
        Assert.That(sut.PeopleAwareOfSecret(4, 1, 3), Is.EqualTo(6));
    }
}