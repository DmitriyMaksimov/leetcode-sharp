using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00328UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00328();

        var n5 = new S00328.ListNode(5);
        var n4 = new S00328.ListNode(4, n5);
        var n3 = new S00328.ListNode(3, n4);
        var n2 = new S00328.ListNode(2, n3);
        var n1 = new S00328.ListNode(1, n2);

        var oddEvenList = sut.OddEvenList(n1);
        var ints = new List<int>();
        while (oddEvenList != null)
        {
            ints.Add(oddEvenList.val);
            oddEvenList = oddEvenList.next;
        }

        ints.Should().BeEquivalentTo(new[] {1, 3, 5, 2, 4});
    }

    [Test]
    public void Test2()
    {
        var sut = new S00328();

        sut.OddEvenList(null).Should().BeNull();
    }

    [Test]
    [TestCase("121", true)]
    [TestCase("1234321", true)]
    [TestCase("123432", false)]
    public void Palindrome(string s, bool expected)
    {
        isPalindrome(s).Should().Be(expected);
    }

    private static bool isPalindrome(string s)
    {
        for (var i = 0; i < s.Length / 2; i++)
        {
            if (s[i] != s[s.Length - i - 1]) return false;
        }

        return true;
    }
}