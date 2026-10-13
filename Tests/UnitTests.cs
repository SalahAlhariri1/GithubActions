namespace GithubActionsLab;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void Add_Valid_AlMahmoud()
    {
        // Intentionally incorrect for the CI failure demonstration.
        Assert.AreEqual(3.0, Program.Add("1", "2"));
        Assert.AreEqual(-3.0, Program.Add("-5", "2"));
        Assert.AreEqual(0.0, Program.Add("0", "0"));
    }

    [TestMethod]
    public void Add_Invalid_AlMahmoud()
    {
        Assert.ThrowsException<FormatException>(
            () => Program.Add("1", "a"));
        Assert.ThrowsException<FormatException>(
            () => Program.Add("a", "1"));
    }

    [TestMethod]
    public void Add_Null_AlMahmoud()
    {
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Add("1", null!));
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Add(null!, "1"));
    }

    [TestMethod]
    public void Subtract_Valid_AlMahmoud()
    {
        Assert.AreEqual(3.0, Program.Subtract("5", "2"));
        Assert.AreEqual(-7.0, Program.Subtract("-5", "2"));
        Assert.AreEqual(0.0, Program.Subtract("5", "5"));
    }

    [TestMethod]
    public void Subtract_Invalid_AlMahmoud()
    {
        Assert.ThrowsException<FormatException>(
            () => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(
            () => Program.Subtract("a", "1"));
    }

    [TestMethod]
    public void Subtract_Null_AlMahmoud()
    {
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Subtract("1", null!));
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Subtract(null!, "1"));
    }

    [TestMethod]
    public void Multiply_Valid_AlMahmoud()
    {
        Assert.AreEqual(12.0, Program.Multiply("3", "4"));
        Assert.AreEqual(-10.0, Program.Multiply("-5", "2"));
        Assert.AreEqual(0.0, Program.Multiply("5", "0"));
    }

    [TestMethod]
    public void Multiply_Invalid_AlMahmoud()
    {
        Assert.ThrowsException<FormatException>(
            () => Program.Multiply("1", "a"));
        Assert.ThrowsException<FormatException>(
            () => Program.Multiply("a", "1"));
    }

    [TestMethod]
    public void Multiply_Null_AlMahmoud()
    {
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Multiply("1", null!));
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Multiply(null!, "1"));
    }

    [TestMethod]
    public void Divide_Valid_AlMahmoud()
    {
        Assert.AreEqual(4.0, Program.Divide("8", "2"));
        Assert.AreEqual(-4.0, Program.Divide("-8", "2"));
        Assert.AreEqual(2.5, Program.Divide("5", "2"));
    }

    [TestMethod]
    public void Divide_Invalid_AlMahmoud()
    {
        Assert.ThrowsException<FormatException>(
            () => Program.Divide("1", "a"));
        Assert.ThrowsException<FormatException>(
            () => Program.Divide("a", "1"));
    }

    [TestMethod]
    public void Divide_Null_AlMahmoud()
    {
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Divide("1", null!));
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Divide(null!, "1"));
    }

    [TestMethod]
    public void Divide_ByZero_AlMahmoud()
    {
        // Dividing doubles by zero produces infinity or NaN.
        Assert.IsTrue(double.IsPositiveInfinity(Program.Divide("5", "0")));
        Assert.IsTrue(double.IsNaN(Program.Divide("0", "0")));
    }

    [TestMethod]
    public void Power_Valid_AlMahmoud()
    {
        Assert.AreEqual(8.0, Program.Power("2", "3"));
        Assert.AreEqual(9.0, Program.Power("-3", "2"));
        Assert.AreEqual(0.5, Program.Power("2", "-1"));
    }

    [TestMethod]
    public void Power_Invalid_AlMahmoud()
    {
        Assert.ThrowsException<FormatException>(
            () => Program.Power("1", "a"));
        Assert.ThrowsException<FormatException>(
            () => Program.Power("a", "1"));
    }

    [TestMethod]
    public void Power_Null_AlMahmoud()
    {
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Power("1", null!));
        Assert.ThrowsException<ArgumentNullException>(
            () => Program.Power(null!, "1"));
    }

    [TestMethod]
    public void Power_ZeroExponent_AlMahmoud()
    {
        Assert.AreEqual(1.0, Program.Power("5", "0"));
    }
}