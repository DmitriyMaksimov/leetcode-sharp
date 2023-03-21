using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00700Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00700();
        sut.SearchBST(TreeNode.Parse("[4,2,7,1,3]"), 2).Should().BeEquivalentTo(TreeNode.Parse("[2,1,3]"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00700();
        sut.SearchBST(TreeNode.Parse("[4,2,7,1,3]"), 5).Should().BeNull();
    }
}