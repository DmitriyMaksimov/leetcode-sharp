using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00098Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00098();
        Assert.That(sut.IsValidBST(TreeNode.Parse("[2,1,3]")), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00098();
        Assert.That(sut.IsValidBST(TreeNode.Parse("[5,1,4,null,null,3,6]")), Is.False);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00098();
        TreeNode.Print(TreeNode.Parse("[5,4,6,null,null,3,7]"));
        Assert.That(sut.IsValidBST(TreeNode.Parse("[5,4,6,null,null,3,7]")), Is.False);
    }
}
