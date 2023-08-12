﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00032Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00032();
        sut.LongestValidParentheses("(()").Should().Be(2);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00032();
        sut.LongestValidParentheses(")()())").Should().Be(4);
    }

    [Test]
    public void T3()
    {
        var sut = new S00032();
        sut.LongestValidParentheses("").Should().Be(0);
    }

}