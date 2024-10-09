using System;
using NUnit.Framework;

[TestFixture]
public class RomanTests
{
    private Roman roman;

    [SetUp]
    public void Setup()
    {
        roman = new Roman();
    }

    [Test]
    public void RomanToInt_SingleDigit_ReturnsCorrectValue()
    {
        Assert.AreEqual(1, roman.RomanToInt("I"));
        Assert.AreEqual(5, roman.RomanToInt("V"));
        Assert.AreEqual(10, roman.RomanToInt("X"));
        Assert.AreEqual(50, roman.RomanToInt("L"));
        Assert.AreEqual(100, roman.RomanToInt("C"));
        Assert.AreEqual(500, roman.RomanToInt("D"));
        Assert.AreEqual(1000, roman.RomanToInt("M"));
    }

    [Test]
    public void RomanToInt_MultipleDigits_ReturnsCorrectSum()
    {
        Assert.AreEqual(7, roman.RomanToInt("VII"));
        Assert.AreEqual(15, roman.RomanToInt("XV"));
        Assert.AreEqual(66, roman.RomanToInt("LXVI"));
        Assert.AreEqual(1994, roman.RomanToInt("MCMXCIV"));
    }

    [Test]
    public void RomanToInt_SubtractiveNotation_ReturnsCorrectValue()
    {
        Assert.AreEqual(4, roman.RomanToInt("IV"));
        Assert.AreEqual(9, roman.RomanToInt("IX"));
        Assert.AreEqual(40, roman.RomanToInt("XL"));
        Assert.AreEqual(90, roman.RomanToInt("XC"));
        Assert.AreEqual(400, roman.RomanToInt("CD"));
        Assert.AreEqual(900, roman.RomanToInt("CM"));
    }

    [Test]
    public void RomanToInt_LargeNumber_ReturnsCorrectValue()
    {
        Assert.AreEqual(3999, roman.RomanToInt("MMMCMXCIX"));
    }

    [Test]
    public void RomanToInt_EmptyString_ReturnsZero()
    {
        Assert.AreEqual(0, roman.RomanToInt(""));
    }

    [Test]