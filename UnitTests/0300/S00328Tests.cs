using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00328Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00328();

        var root = ListNode.Parse("[1,2,3,4,5]")!;

        var oddEvenList = sut.OddEvenList(root);
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
        Assert.That(isPalindrome(s), Is.EqualTo(expected));
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