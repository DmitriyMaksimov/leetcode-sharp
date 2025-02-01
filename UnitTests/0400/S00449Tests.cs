using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00449Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00449.Codec();
        var serialize = sut.serialize(TreeNode.Parse("[2,1,3]"));
        Assert.That(sut.deserialize(serialize).AsString(), Is.EqualTo("[2,1,3]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00449.Codec();
        var serialize = sut.serialize(TreeNode.Parse("[]"));
        Assert.That(sut.deserialize(serialize).AsString(), Is.EqualTo("[]"));
    }
}
