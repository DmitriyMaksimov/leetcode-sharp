using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00981Tests
{
    [Test]
    public void T1()
    {
        var timeMap = new S00981.TimeMap();
        timeMap.Set("foo", "bar", 1); // store the key "foo" and value "bar" along with timestamp = 1.
        Assert.That(timeMap.Get("foo", 1), Is.EqualTo("bar")); // return "bar"
        Assert.That(timeMap.Get("foo", 3),
            Is.EqualTo("bar")); // return "bar", since there is no value corresponding to foo at timestamp 3 and timestamp 2, then the only value is at timestamp 1 is "bar".
        timeMap.Set("foo", "bar2", 4); // store the key "foo" and value "bar2" along with timestamp = 4.
        Assert.That(timeMap.Get("foo", 4), Is.EqualTo("bar2")); // return "bar2"
        Assert.That(timeMap.Get("foo", 5), Is.EqualTo("bar2")); // return "bar2"
    }
}
