using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00652Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00652();
        var treeNodes = sut.FindDuplicateSubtrees(TreeNode.Parse("[1,2,3,4,null,2,4,null,null,4]")).Select(x => x.AsString()).ToList();
        Assert.That(treeNodes, Has.Count.EqualTo(2));
        Assert.That(treeNodes, Is.EquivalentTo((string[]) ["[2,4]", "[4]"]));
    }    

    [Test]
    public void T2()
    {
        var sut = new S00652();
        var treeNodes = sut.FindDuplicateSubtrees(TreeNode.Parse("[2,1,1]")).Select(x => x.AsString()).ToList();;
        Assert.That(treeNodes, Has.Count.EqualTo(1));
        Assert.That(treeNodes, Is.EquivalentTo((string[]) ["[1]"]));
    }    
}
