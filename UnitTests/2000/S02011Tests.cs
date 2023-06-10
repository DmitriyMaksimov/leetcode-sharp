using leetcode_sharp._2000;

namespace UnitTests;

[TestFixture]
public class S02011Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02011();
        sut.FinalValueAfterOperations(new[] {"--X","X++","X++"}).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S02011();
        sut.FinalValueAfterOperations(new[] {"++X","++X","X++"}).Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S02011();
        sut.FinalValueAfterOperations(new[] {"X++","++X","--X","X--"}).Should().Be(0);
    }
}