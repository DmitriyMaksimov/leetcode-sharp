using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02011Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02011();
        Assert.That(sut.FinalValueAfterOperations(["--X","X++","X++"]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02011();
        Assert.That(sut.FinalValueAfterOperations(["++X","++X","X++"]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02011();
        Assert.That(sut.FinalValueAfterOperations(["X++","++X","--X","X--"]), Is.EqualTo(0));
    }
}