using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00133Tests
{
    [Test]
    public void T1()
    {
        var n1 = new S00133.Node(1);
        var n2 = new S00133.Node(2);
        var n3 = new S00133.Node(3);
        var n4 = new S00133.Node(4);

        n1.neighbors = new List<S00133.Node> {n2, n4};
        n2.neighbors = new List<S00133.Node> {n1, n3};
        n3.neighbors = new List<S00133.Node> {n2, n4};
        n4.neighbors = new List<S00133.Node> {n1, n3};

        var sut = new S00133();
        var cloneGraph = sut.CloneGraph(n1);

        cloneGraph.Should().NotBeNull();
        cloneGraph.Should().NotBeSameAs(n1);
        cloneGraph.val.Should().Be(1);
        var neighbors2 = cloneGraph.neighbors.Should().Contain(x => x.val == 2).Which.neighbors;
        var neighbors4 = cloneGraph.neighbors.Should().Contain(x => x.val == 4).Which.neighbors;

        var neighbors1 = neighbors2.Should().Contain(x => x.val == 1).Which.neighbors;
        var neighbors3 = neighbors2.Should().Contain(x => x.val == 3).Which.neighbors;
    }

    [Test]
    public void T2()
    {
        var sut = new S00133();
        sut.CloneGraph(null).Should().BeNull();
    }

    [Test]
    public void T3()
    {
        var sut = new S00133();
        var n1 = new S00133.Node(1);
        var cloneGraph = sut.CloneGraph(n1);
        cloneGraph.Should().NotBeSameAs(n1);
        cloneGraph.val.Should().Be(1);
        cloneGraph.neighbors.Should().BeEmpty();
    }
}