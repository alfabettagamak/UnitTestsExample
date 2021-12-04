
using System;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using UnitTestsExample.App;

public class Tests
{
    [Test]

    [TestCase("")]
    [TestCase(null)]
    public void CheckIsEmptyByEmptyStringTesting(string massege)
    {
        var actual = SimpleClass.IsEmpty(massege);
        var expected = "Вы ничего не ввели";
        Assert.True(actual, $" Сработало неверно. Ожидалось  {expected}. Получено: Вы ввели {massege}");
    }

    [Test]
    [TestCase("hh")]
    [TestCase("-1")]
    public void CheckIsDigitOnlyByLetterЕTesting(string message)
    {
        var actual = SimpleClass.IsDigitOnly(message);
        string expected = "Вы ввели не цифры, как мы будем их складывать?";
        Assert.False(actual,
            $" Сработало неверно. Ожидалось сообщение: {expected}. Получили: Метод IsDigitOnly принял в дальнейшую обработку. Метод IsDigitOnly сработал не корректно и принял в дальнейшую обработку {message} ");
    }

    [Test]
    [TestCase("-1")]
    [TestCase("0")]
    [TestCase("1")]
    [TestCase("8")]
    [TestCase("9")]
    [TestCase("10")]

    public void CheckIsDigitOnlyByBorderlineValueTesting(string message)
    {
        var actual = SimpleClass.IsDigitOnly(message);
        bool expected = true;
        Assert.True(actual,
            $" Сработало неверно. Ожидалось сообщение: {expected}. Получили: Вы ввели не цифры, как мы будем их складывать?");
    }

    [Test]

    [TestCase("123456789")]
    [TestCase("1234567891")]

    public void CheckIsLengthLessMaxIntLengthByVeryGreatValueTesting(string message)
    {
        var actual = SimpleClass.IsLengthLessMaxIntLength(message);
        string expected = $"Вы ввели очень большое значение. Больше, чем {int.MaxValue.ToString().Length - 1}";
        Assert.False(actual,
            $" Сработало неверно. Ожидалось сообщение: {expected}. Получили: Метод IsDigitOnly принял в дальнейшую обработку. Метод IsDigitOnly сработал не корректно и принял в дальнейшую обработку {message}.");
    }

    [Test]
    [TestCase("1234567890")]
    public void CheckIsLengthLessMaxIntLengthByErrorMessageTesting(string message)
    {
        var actual = SimpleClass.IsLengthLessMaxIntLength(message);
        string expected =
            $"Вы ввели очень большое значение. Длинна числа больше, чем {int.MaxValue.ToString().Length - 1}";
        Assert.True(actual,
            $" Сработало неверно. Ожидалось сообщение: {expected}. Получено: Вы ввели очень большое значение. Больше, чем {int.MaxValue.ToString().Length - 1}");
    }
}