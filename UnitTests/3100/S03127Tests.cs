using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03127Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03127();
        sut.CanMakeSquare([['B','W','B'],['B','W','W'],['B','W','B']]).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S03127();
        sut.CanMakeSquare([['B','W','B'],['W','B','W'],['B','W','B']]).Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S03127();
        sut.CanMakeSquare([['B','W','B'],['B','W','W'],['B','W','W']]).Should().BeTrue();
    }
}