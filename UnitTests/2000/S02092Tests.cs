using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02092))]
public class S02092Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02092();
        Assert.That(sut.FindAllPeople(6, [[1, 2, 5], [2, 3, 8], [1, 5, 10]], 1), Is.EqualTo([0, 1, 2, 3, 5]));
    }

    [Test]
    public void T2()
    {
        var sut = new S02092();
        Assert.That(sut.FindAllPeople(4, [[3, 1, 3], [1, 2, 2], [0, 3, 3]], 3), Is.EqualTo([0, 1, 3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S02092();
        Assert.That(sut.FindAllPeople(5, [[3, 4, 2], [1, 2, 1], [2, 3, 1]], 1), Is.EqualTo([0, 1, 2, 3, 4]));
    }
}