# DeleteBinaries
Deletes a project's binaries folders (including plugins)

The purpose is to have a shortcut that when executed will delete all "Binaries" folders from the project and all plugins.

This is an exceedingly simple C# helper application. Check Program.cs to view the entirety of the tiny code-base.

Helpful for cleaning a project.

[See the sister application here to delete Intermediate folders.](https://github.com/Vaei/DeleteIntermediate)

![example](https://github.com/Vaei/DeleteBinaries/blob/files/helper_example.png)

## How to Use

1. Clone & Build from .sln using Visual Studio 2022
2. Create a shortcut to `DeleteBinaries\DeleteBinaries\bin\Release\net6.0\DeleteBinaries.exe`
3. Place it in your project folder alongside the `.uproject` file
4. Clear the "Start In" field. This is vitally important, it will not work otherwise. This field must be empty.
