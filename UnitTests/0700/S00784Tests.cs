﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00784Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00784();
        sut.LetterCasePermutation("a1b2").Should().BeEquivalentTo("a1b2", "a1B2", "A1b2", "A1B2");
    }

    [Test]
    public void T2()
    {
        var sut = new S00784();
        sut.LetterCasePermutation("3z4").Should().BeEquivalentTo("3z4", "3Z4");
    }

    [Test]
    public void T3()
    {
        var sut = new S00784();
        Assert.That(sut.LetterCasePermutation("42"), Is.EquivalentTo((string[]) ["42"]));
    }
}
