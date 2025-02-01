using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00919Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00919.CBTInserter(TreeNode.Parse("[1, 2]"));
        Assert.That(sut.Insert(3), Is.EqualTo(1));
        Assert.That(sut.Insert(4), Is.EqualTo(2));
        sut.Get_root().Should().BeEquivalentTo(TreeNode.Parse("[1, 2, 3, 4]"));
    }
}
