using System;
using NUnit.Framework;
using UnitTestsExample.App;

namespace UnitTestsExample.Tests;

public class Tests
{
    [Test]
    [TestCase("")]
    [TestCase(null)]

    public void CheckIsEmptyTesting(string text)
    {
        var actual = SimpleClass.IsEmpty("");
        bool expected = true;
        Assert.AreEqual(expected, actual,
            $"IsEmpty отработал неправильно, на вход получена не пустая строка. Ожидали: {expected}. Получено: {actual}");
    }

    [Test]
    [TestCase("text")]
    public void CheckIsEmptyByNonEmptyTesting(string text)
    {
        var actual = SimpleClass.IsEmpty("text");
        bool expected = false;
        Assert.AreEqual(expected, actual,
            $"IsEmpty отработал неправильно, на вход ничего не получено. Ожидали: {expected}. Получено: {actual}");
    }

    [Test]
    [TestCase("message")]
    public void CheckIsDigitOnlyByStringTesting(string message)
    {
        var actual = SimpleClass.IsDigitOnly(message);
        bool expected = false;
        Assert.AreEqual(expected, actual,
            $"IsDigitOnly отработал неправильно, на вход получено число. Ожидали: {expected}. Получено: {actual}");
    }

    [Test]
    [TestCase('c')]
    public void CheckIsDigitOnlyByIntTesting(int c)
    {
        var numStr = Convert.ToString(c);
        var actual = SimpleClass.IsDigitOnly(numStr);
        bool expected = true;
        Assert.AreEqual(expected, actual,
            $"IsDigitOnly отработал неправильно, на вход получен текст. Ожидали: {expected}. Получено: {actual}");
    }
}
    