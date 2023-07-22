using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01028Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01028();
        sut.RecoverFromPreorder("1-2--3--4-5--6--7").Should().BeEquivalentTo(TreeNode.Parse("[1,2,5,3,4,6,7]"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01028();
        sut.RecoverFromPreorder("1-2--3---4-5--6---7").Should().BeEquivalentTo(TreeNode.Parse("[1,2,5,3,null,6,null,4,null,7]"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01028();
        sut.RecoverFromPreorder("1-401--349---90--88").Should().BeEquivalentTo(TreeNode.Parse("[1,401,null,349,88,90]"));
    }
}