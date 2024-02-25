using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02326Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02326();
        sut.SpiralMatrix(3, 5, ListNode.Parse("[3,0,2,6,8,1,7,9,4,2,5,5,0]")).Should().BeEquivalentTo([(int[]) [3, 0, 2, 6, 8], [5, 0, -1, -1, 1], [5, 2, 4, 9, 7]]);
    }

    [Test]
    public void T2()
    {
        var sut = new S02326();
        sut.SpiralMatrix(1, 4, ListNode.Parse("[0,1,2]")).Should().BeEquivalentTo([(int[]) [0, 1, 2, -1]]);
    }
}