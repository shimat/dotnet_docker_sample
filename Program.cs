using Microsoft.VisualBasic;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

Console.WriteLine("Hello, World!");

try
{
    var narrowDigits = Strings.StrConv("１２３－４５６", VbStrConv.Narrow, 0x0411);
    Console.WriteLine(narrowDigits);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}
