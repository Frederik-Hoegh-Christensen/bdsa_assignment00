namespace LeapYear.tests;

public class LeapYearTests
{
    
    
    [Fact]
    public void Is4aLeapYear()
    {
        // Given
        var _sut = new LeapYearCalculator();

        // When
        var result = _sut.isLeapYear(4);
        // Then
        result.Should().Be(true);
    }

    [Fact]
    public void Is100aLeapYear()
    {
        // Given
            var _sut = new LeapYearCalculator();
        // When
            var result = _sut.isLeapYear(100);
        // Then
        result.Should().Be(false);
    }  

    [Fact]
    public void testWhetherYay()
    {
        // Given
            using var writer = new StringWriter();
            Console.SetOut(writer);
            
            var textReader = new StringReader("1600");
        // When
            Console.SetIn(textReader);
            var _sut = new LeapYearCalculator();
            _sut.writeYayOrNay();
            var output = writer.GetStringBuilder().ToString().TrimEnd().Split(Environment.
            NewLine,StringSplitOptions.RemoveEmptyEntries);
        // Then
            
            output[1].Should().Be("yay");
            
    }

    [Fact]
    public void testWhetherNay()
    {
        // Given
            using var writer = new StringWriter();
            Console.SetOut(writer);
            
            var textReader = new StringReader("2333");
        // When
            Console.SetIn(textReader);
            var _sut = new LeapYearCalculator();
            _sut.writeYayOrNay();
            var output = writer.GetStringBuilder().ToString().TrimEnd().Split(Environment.
            NewLine,StringSplitOptions.RemoveEmptyEntries);
        // Then
            output[1].Should().Be("nay");
    }

    [Fact]
    public void TestName()
    {
        // Given
        using var writer = new StringWriter();
        Console.SetOut(writer);
        var firstReader = new StringReader("100");
        Console.SetIn(firstReader);
        // When
        var _sut = new LeapYearCalculator();
        _sut.writeYayOrNay();
        
        var output = writer.GetStringBuilder().ToString().TrimEnd().Split(Environment.
            NewLine,StringSplitOptions.RemoveEmptyEntries);
            
        // Then
        output[1].Should().Be("The program can only handle years that a higher than 1581");
        
    }
}