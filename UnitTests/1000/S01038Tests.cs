using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01038Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01038();
        Assert.That(sut.BstToGst(TreeNode.Parse("[4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]")).AsString(), Is.EqualTo("[30,36,21,36,35,26,15,null,null,null,33,null,null,null,8]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01038();
        Assert.That(sut.BstToGst(TreeNode.Parse("[0,null,1]")).AsString(), Is.EqualTo("[1,null,1]"));
    }
}