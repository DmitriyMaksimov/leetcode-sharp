using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00705Tests
{
    [Test]
    public void T1()
    {
        var myHashSet = new S00705.MyHashSet();
        myHashSet.Add(1);
        myHashSet.Add(2);
        myHashSet.Contains(1).Should().BeTrue();
        myHashSet.Contains(3).Should().BeFalse();
        myHashSet.Add(2);
        myHashSet.Contains(2).Should().BeTrue();
        myHashSet.Remove(2);
        myHashSet.Contains(2).Should().BeFalse();
    }
}