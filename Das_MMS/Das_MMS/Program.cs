using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using Spectre.Console;

namespace Das_MMS
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WindowHeight = 42;
            Console.WindowWidth = 150;
            Console.Title = "Das_MMS";

            var image = new CanvasImage("MMslogo.png");
            image.MaxWidth(64);
            image.BilinearResampler();
            AnsiConsole.Write(image);

            Console.ReadLine();
        }
    }
}
