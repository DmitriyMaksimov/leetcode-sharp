using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00098Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00098();
        sut.IsValidBST(TreeNode.Parse("[2,1,3]")).Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00098();
        sut.IsValidBST(TreeNode.Parse("[5,1,4,null,null,3,6]")).Should().BeFalse();
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00098();
        TreeNode.Print(TreeNode.Parse("[5,4,6,null,null,3,7]"));
        sut.IsValidBST(TreeNode.Parse("[5,4,6,null,null,3,7]")).Should().BeFalse();
    }
}