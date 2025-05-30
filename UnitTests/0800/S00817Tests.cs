using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00817Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00817();
        Assert.That(sut.NumComponents(ListNode.Parse("[0,1,2,3]"), [0, 1, 3]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00817();
        Assert.That(sut.NumComponents(ListNode.Parse("[0,1,2,3,4]"), [0, 3, 1, 4]), Is.EqualTo(2));
    }
}
