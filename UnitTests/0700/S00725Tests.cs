using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00725Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00725();
        Assert.That(sut.SplitListToParts(ListNode.Parse("[1,2,3]"), 5).Select(x => x.AsString()), Is.EquivalentTo((string[]) ["[1]", "[2]", "[3]", "[]", "[]"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00725();
        Assert.That(sut.SplitListToParts(ListNode.Parse("[1,2,3,4,5,6,7,8,9,10]"), 3).Select(x => x.AsString()), Is.EquivalentTo((string[]) ["[1,2,3,4]", "[5,6,7]", "[8,9,10]"]));
    }
}
