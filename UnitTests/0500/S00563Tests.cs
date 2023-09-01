using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00563Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00563();
        sut.FindTilt(TreeNode.Parse("[1,2,3]")).Should().Be(1);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00563();
        sut.FindTilt(TreeNode.Parse("[4,2,9,3,5,null,7]")).Should().Be(15);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00563();
        sut.FindTilt(TreeNode.Parse("[21,7,14,1,1,2,2,3,3]")).Should().Be(9);
    }

}