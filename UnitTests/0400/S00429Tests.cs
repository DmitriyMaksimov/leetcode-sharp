using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00429Tests
{
    [Test]
    public void T1()
    {
        var n6 = new S00429.Node(6);
        var n5 = new S00429.Node(5);
        var n4 = new S00429.Node(4);
        var n3 = new S00429.Node(3, [n5, n6]);
        var n2 = new S00429.Node(2);
        var n1 = new S00429.Node(1, [n3, n2, n4]);
        var sut = new S00429();
        Assert.That(sut.LevelOrder(n1), Is.EquivalentTo((int[][]) [[1], [3, 2, 4], [5, 6]]));
    }
}
