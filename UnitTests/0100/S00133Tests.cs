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

        Assert.That(cloneGraph, Is.Not.Null);
        Assert.That(cloneGraph, Is.Not.SameAs(n1));
        Assert.That(cloneGraph.val, Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00133();
        Assert.That(sut.CloneGraph(null), Is.Null);
    }

    [Test]
    public void T3()
    {
        var sut = new S00133();
        var n1 = new S00133.Node(1);
        var cloneGraph = sut.CloneGraph(n1);
        Assert.That(cloneGraph, Is.Not.SameAs(n1));
        Assert.That(cloneGraph.val, Is.EqualTo(1));
        Assert.That(cloneGraph.neighbors, Is.Empty);
    }
}
