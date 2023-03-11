using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00109Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00109();
        sut.SortedListToBST(ListNode.Parse("[-10,-3,0,5,9]")).Should().BeEquivalentTo(TreeNode.Parse("[0,-3,9,-10,null,5]"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00109();
        sut.SortedListToBST(ListNode.Parse("[]")).Should().BeNull();
    }
}