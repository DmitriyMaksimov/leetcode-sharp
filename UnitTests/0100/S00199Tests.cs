using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00199Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00199();
        Assert.That(sut.RightSideView(TreeNode.Parse("[1,2,3,null,5,null,4]")), Is.EqualTo((int[]) [1,3,4]));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00199();
        Assert.That(sut.RightSideView(TreeNode.Parse("[1,null,3]")), Is.EqualTo((int[]) [1,3]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00199();
        Assert.That(sut.RightSideView(TreeNode.Parse("[]")), Is.Empty);
    }

}