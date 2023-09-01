using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00589Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00589();
        sut.Preorder(null).Should().BeEmpty();
    }

    [Test]
    public void T2()
    {
        var sut = new S00589();
        sut.Preorder(new S00589.Node()).Should().Equal(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00589();
        sut.Preorder(new S00589.Node(1, new List<S00589.Node?> {new(3, new List<S00589.Node?> {new(5), new(6)}), new(2), new(4)}))
            .Should().Equal(1, 3, 5, 6, 2, 4);
    }

    [Test]
    public void T4()
    {
        var sut = new S00589();
        sut.Preorder(new S00589.Node(1, new List<S00589.Node?> {new(2), new(3, new List<S00589.Node?> {new(6), new(7, new List<S00589.Node?> {new(11, new List<S00589.Node?> {new(14)})})}), new(4, new List<S00589.Node?> {new(8, new List<S00589.Node?> {new(12)})}), new(5, new List<S00589.Node?> {new(9, new List<S00589.Node?> {new(13)}), new(10)})}))
            .Should().Equal(1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10);
    }

}