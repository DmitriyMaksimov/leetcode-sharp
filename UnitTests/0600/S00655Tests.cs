using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00655Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00655();
        Assert.That(sut.PrintTree(TreeNode.Parse("[1,2]")), Is.EquivalentTo((string[][]) [["", "1", ""], ["2", "", ""]]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00655();
        Assert.That(sut.PrintTree(TreeNode.Parse("[1,2,3,null,4]")), Is.EquivalentTo(
            (string[][]) [["", "", "", "1", "", "", ""],
            ["", "2", "", "", "", "3", ""],
            ["", "", "4", "", "", "", ""]
        ]));
    }
}
