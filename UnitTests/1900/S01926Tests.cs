using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01926Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S01926();
        Assert.That(sut.NearestExit([['+','+','.','+'], ['.','.','.','+'], ['+','+','+','.']], [1, 2]), Is.EqualTo(1));
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S01926();
        Assert.That(sut.NearestExit([['+','+','+'], ['.','.','.'], ['+','+','+']], [1, 0]), Is.EqualTo(2));
    }
    
    [Test]
    public void Test3()
    {
        var sut = new S01926();
        Assert.That(sut.NearestExit([['.','+']], [0, 0]), Is.EqualTo(-1));
    }
}