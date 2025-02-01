using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00108Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00108();
        Assert.That(sut.SortedArrayToBST(new[] {-10, -3, 0, 5, 9}).AsString(), Is.EqualTo("[0,-10,5,null,-3,null,9]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00108();
        Assert.That(sut.SortedArrayToBST(new[] {1, 3}).AsString(), Is.EqualTo("[1,null,3]"));
    }
}