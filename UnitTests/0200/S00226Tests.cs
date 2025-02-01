using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00226Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00226();
        Assert.That(sut.InvertTree(TreeNode.Parse("[4,2,7,1,3,6,9]")).AsString(), Is.EqualTo("[4,7,2,9,6,3,1]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00226();
        Assert.That(sut.InvertTree(TreeNode.Parse("[2,1,3]")).AsString(), Is.EqualTo("[2,3,1]"));
    }
}