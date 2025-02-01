using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00234Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00234();
        Assert.That(sut.IsPalindrome(ListNode.Parse("[1,2,2,1]")), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00234();
        Assert.That(sut.IsPalindrome(ListNode.Parse("[1,2]")), Is.False);
    }
}
