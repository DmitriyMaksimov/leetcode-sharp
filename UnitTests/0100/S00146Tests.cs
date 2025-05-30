﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00146Tests
{
    [Test]
    public void T1()
    {
        var lRuCache = new S00146.LRUCache(2);
        lRuCache.Put(1, 1); // cache is {1=1}
        lRuCache.Put(2, 2); // cache is {1=1, 2=2}
        Assert.That(lRuCache.Get(1), Is.EqualTo(1));    // return 1
        lRuCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
        Assert.That(lRuCache.Get(2), Is.EqualTo(-1));    // returns -1 (not found)
        lRuCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
        Assert.That(lRuCache.Get(1), Is.EqualTo(-1));    // return -1 (not found)
        Assert.That(lRuCache.Get(3), Is.EqualTo(3));    // return 3
        Assert.That(lRuCache.Get(4), Is.EqualTo(4));    // return 4
    }
}