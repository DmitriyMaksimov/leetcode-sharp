using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03127Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03127();
        Assert.That(sut.CanMakeSquare([['B','W','B'],['B','W','W'],['B','W','B']]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03127();
        Assert.That(sut.CanMakeSquare([['B','W','B'],['W','B','W'],['B','W','B']]), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03127();
        Assert.That(sut.CanMakeSquare([['B','W','B'],['B','W','W'],['B','W','W']]), Is.True);
    }
}
