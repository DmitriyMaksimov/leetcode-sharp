using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02385Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02385();
        sut.AmountOfTime(TreeNode.Parse("[1,5,3,null,4,10,6,9,2]"), 3).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S02385();
        sut.AmountOfTime(TreeNode.Parse("[1]"), 1).Should().Be(0);
    }
}