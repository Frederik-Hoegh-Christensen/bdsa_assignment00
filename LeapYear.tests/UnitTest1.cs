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
            var output = writer.GetStringBuilder().ToString().TrimEnd().Split("\r\n");
        // Then
            output[1].Should().Be("yay");
    }
}