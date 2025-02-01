using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00590Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00590();
        Assert.That(sut.Postorder(null), Is.Empty);
    }

    [Test]
    public void T2()
    {
        var sut = new S00590();
        Assert.That(sut.Postorder(new S00590.Node()), Is.EquivalentTo(new List<int> {0}));
    }

    [Test]
    public void T3()
    {
        var sut = new S00590();
        Assert.That(sut.Postorder(new S00590.Node(1,
                new List<S00590.Node?> {new(3, new List<S00590.Node?> {new(5), new(6)}), new(2), new(4)})), Is.EqualTo((int[]) [5, 6, 3, 2, 4, 1]));
    }

    [Test]
    public void T4()
    {
        var sut = new S00590();
        Assert.That(sut.Postorder(new S00590.Node(1,
                new List<S00590.Node?>
                {
                    new(2),
                    new(3,
                        new List<S00590.Node?>
                            {new(6), new(7, new List<S00590.Node?> {new(11, new List<S00590.Node?> {new(14)})})}),
                    new(4, new List<S00590.Node?> {new(8, new List<S00590.Node?> {new(12)})}),
                    new(5, new List<S00590.Node?> {new(9, new List<S00590.Node?> {new(13)}), new(10)})
                })), Is.EqualTo((int[]) [2, 6, 14, 11, 7, 3, 12, 8, 4, 13, 9, 10, 5, 1]));
    }
}