# Installation
## .NET SDK
The installation of `Visual Studio Code` and `.NET SDK` on Linux Ubuntu, and the creating of a simple Console project, are explained in [this tutorial][1].

A .gitignore can be generated with this .NET command:

```
dotnet new gitignore
```

## Avalonia
[Avalonia][2] is a UI framework for .NET that can be set-up following [this tutorial][3].

[1]: https://laroccanicola.medium.com/first-contact-with-net-core-2-and-visual-studio-code-in-linux-ubuntu-6f0d66c67739
[2]: https://github.com/AvaloniaUI/Avalonia
[3]: https://dev.to/carlos487/avalonia-ui-in-ubuntu-getting-started-2fak


# Build
Use dotnet command to build & run the project with:

```
dotnet run
```

Or directly run it from within VS Code (its vim plugin can be configured with [this .vimrc][4]).

[4]: https://github.com/h4k1m0u/dotfiles/blob/master/ubuntu/.vimrc.vscode