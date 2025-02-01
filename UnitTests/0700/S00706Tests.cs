using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00706Tests
{
    [Test]
    public void T1()
    {
        var myHashMap = new S00706.MyHashMap();
        myHashMap.Put(1, 1); // The map is now [[1,1]]
        myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
        Assert.That(myHashMap.Get(1), Is.EqualTo(1)); // return 1, The map is now [[1,1], [2,2]]
        Assert.That(myHashMap.Get(3), Is.EqualTo(-1)); // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
        myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
        Assert.That(myHashMap.Get(2), Is.EqualTo(1)); // return 1, The map is now [[1,1], [2,1]]
        myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
        Assert.That(myHashMap.Get(2), Is.EqualTo(-1)); // return -1 (i.e., not found), The map is now [[1,1]]   
    }
}