using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00449Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00449.Codec();
        var serialize = sut.serialize(TreeNode.Parse("[2,1,3]"));
        sut.deserialize(serialize).Should().BeEquivalentTo(TreeNode.Parse("[2,1,3]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00449.Codec();
        var serialize = sut.serialize(TreeNode.Parse("[]"));
        sut.deserialize(serialize).Should().BeEquivalentTo(TreeNode.Parse("[]"));
    }
}
