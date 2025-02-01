using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02641Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02641();
        Assert.That(sut.ReplaceValueInTree(TreeNode.Parse("[5,4,9,1,10,null,7]")).AsString(), Is.EqualTo("[0,0,0,7,7,null,11]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02641();
        Assert.That(sut.ReplaceValueInTree(TreeNode.Parse("[3,1,2]")).AsString(), Is.EqualTo("[0,0,0]"));
    }
}
