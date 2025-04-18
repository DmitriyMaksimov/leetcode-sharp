﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02446Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02446();
        Assert.That(sut.HaveConflict(new[] {"01:15", "02:00"}, new[] {"02:00", "03:00"}), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02446();
        Assert.That(sut.HaveConflict(new[] {"01:00", "02:00"}, new[] {"01:20", "03:00"}), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S02446();
        Assert.That(sut.HaveConflict(new[] {"10:00", "11:00"}, new[] {"14:00", "15:00"}), Is.False);
    }
}
