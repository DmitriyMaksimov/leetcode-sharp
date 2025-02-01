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
        Assert.That(myHashSet.Contains(1), Is.True);
        Assert.That(myHashSet.Contains(3), Is.False);
        myHashSet.Add(2);
        Assert.That(myHashSet.Contains(2), Is.True);
        myHashSet.Remove(2);
        Assert.That(myHashSet.Contains(2), Is.False);
    }
}
