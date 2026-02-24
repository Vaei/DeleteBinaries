/*
    MIT License

    Copyright (c) 2022 Jared Taylor

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

string ProjectDir = Directory.GetCurrentDirectory();

if (Directory.Exists(ProjectDir))
{
    string[] ProjectDirectories = Directory.GetDirectories(ProjectDir, "Binaries", SearchOption.AllDirectories);

    List<string> Directories = new List<string>();
    foreach (string d in ProjectDirectories)
    {
        Directories.Add(d);
    }

    int Num = 0;
    foreach (string d in Directories)
    {
        Console.WriteLine(d);
        try
        {
            Num++;
            Directory.Delete(d, true);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occurred when attempting to delete " + d);
            Console.WriteLine(e.Message);
        }
    }
    Console.WriteLine("Deleted " + Num + " directories.");
    if (!args.Contains("-nowait", StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}