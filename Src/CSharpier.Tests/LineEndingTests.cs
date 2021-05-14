using System.IO;
using FluentAssertions;
using NUnit.Framework;

namespace CSharpier.Tests
{
    public class LineEndingTests
    {
        [Test]
        public void LineEndings_Should_Not_Affect_Printed_Output()
        {
            var code =
                @"class ClassName
{
    private string blah = @""one11111111111111111111111111111111
two
three
four"";
}
";
            var codeWithLf = code.Replace("\r\n", "\n");
            var codeWithCrLf = codeWithLf.Replace("\n", "\r\n");

            var formatter = new CodeFormatter();
            var printerOptions = new PrinterOptions { EndOfLine = EndOfLine.Auto, Width = 80 };
            var lfResult = formatter.Format(codeWithLf, printerOptions);
            var crLfResult = formatter.Format(codeWithCrLf, printerOptions);

            File.WriteAllText("c:/temp/lf.cs", lfResult.Code);
            File.WriteAllText("c:/temp/crlf.cs", crLfResult.Code);

            lfResult.Code.Should().Be(crLfResult.Code.Replace("\r\n", "\n"));
        }

        [TestCase("\r\n", EndOfLine.LF)]
        [TestCase("\n", EndOfLine.CRLF)]
        public void LineEndings_In_Verbatim_String_Should_Respect_Options(
            string newLine,
            EndOfLine endOfLine
        ) {
            var code = @$"class ClassName
{{
    string value = @""one{newLine}two"";
}}
";
            var formatter = new CodeFormatter();
            var printerOptions = new PrinterOptions { EndOfLine = endOfLine };
            var result = formatter.Format(code, printerOptions);
            result.Code.Should().NotContain($"one{newLine}two");
        }

        [TestCase("\\r\\n", EndOfLine.LF)]
        [TestCase("\\n", EndOfLine.CRLF)]
        public void Escaped_LineEndings_In_Verbatim_String_Should_Remain(
            string escapedNewLine,
            EndOfLine endOfLine
        ) {
            var code = @$"class ClassName
{{
    string value = @""one{escapedNewLine}two"";
}}
";
            var formatter = new CodeFormatter();
            var printerOptions = new PrinterOptions { EndOfLine = endOfLine };
            var result = formatter.Format(code, printerOptions);
            result.Code.Should().Contain(escapedNewLine);
        }
    }
}
