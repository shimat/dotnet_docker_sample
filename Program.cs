using Microsoft.VisualBasic;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

Console.WriteLine("Hello, World!");

var narrowDigits = Strings.StrConv("１２３", VbStrConv.Narrow);
Console.WriteLine(narrowDigits);
