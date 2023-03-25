namespace UnitTests;

[TestFixture]
public class S00096Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00096();
        sut.NumTrees(3).Should().Be(5);
    }

    [Test]
    public void T2()
    {
        var sut = new S00096();
        sut.NumTrees(1).Should().Be(1);
    }
}