using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02385Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02385();
        Assert.That(sut.AmountOfTime(TreeNode.Parse("[1,5,3,null,4,10,6,9,2]"), 3), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S02385();
        Assert.That(sut.AmountOfTime(TreeNode.Parse("[1]"), 1), Is.EqualTo(0));
    }
}