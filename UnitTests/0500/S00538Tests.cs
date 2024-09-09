using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00538Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00538();
        sut.ConvertBST(TreeNode.Parse("[4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]")).Should().BeEquivalentTo(TreeNode.Parse("[30,36,21,36,35,26,15,null,null,null,33,null,null,null,8]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00538();
        sut.ConvertBST(TreeNode.Parse("[0,null,1]")).Should().BeEquivalentTo(TreeNode.Parse("[1,null,1]"));
    }
}
