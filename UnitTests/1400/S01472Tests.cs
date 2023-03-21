﻿using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01472Tests
{
    [Test]
    public void T1()
    {
        var browserHistory = new S01472.BrowserHistory("leetcode.com");
        browserHistory.Visit("google.com");                             // You are in "leetcode.com". Visit "google.com"
        browserHistory.Visit("facebook.com");                           // You are in "google.com". Visit "facebook.com"
        browserHistory.Visit("youtube.com");                            // You are in "facebook.com". Visit "youtube.com"
        browserHistory.Back(1).Should().Be("facebook.com");             // You are in "youtube.com", move back to "facebook.com" return "facebook.com"
        browserHistory.Back(1).Should().Be("google.com");               // You are in "facebook.com", move back to "google.com" return "google.com"
        browserHistory.Forward(1).Should().Be("facebook.com");          // You are in "google.com", move forward to "facebook.com" return "facebook.com"
        browserHistory.Visit("linkedin.com");                           // You are in "facebook.com". Visit "linkedin.com"
        browserHistory.Forward(2).Should().Be("linkedin.com");          // You are in "linkedin.com", you cannot move forward any steps.
        browserHistory.Back(2).Should().Be("google.com");               // You are in "linkedin.com", move back two steps to "facebook.com" then to "google.com". return "google.com"
        browserHistory.Back(7).Should().Be("leetcode.com");             // You are in "google.com", you can move back only one step to "leetcode.com". return "leetcode.com"
    }
}