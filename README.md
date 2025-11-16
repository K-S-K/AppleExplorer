# AppleExplorer
The Windows Explorer clone for MacOS

## Features
- Familiar interface similar to Windows Explorer
- File operations: copy, move, delete, rename
- Support for various file formats
- Customizable themes and layouts
- Quick access to frequently used folders
- Integrated search functionality
- Drag and drop support
- File preview for images, documents, and videos
- Context menu with additional options
- Multi-tab browsing

## Build the project on your machine
```bash
dotnet publish -c Release -f net10.0-maccatalyst -r maccatalyst-arm64 -o ./publish
```

## Execution
```bash
open AppleExplorer.Desktop.app
```

## Installation
The installer package can be found in the `./publish` directory after building the project. Simply run the installer to set up AppleExplorer on your MacOS system.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.






dotnet publish -c Release -f net10.0-maccatalyst -o ./publish /p:EnableWindowsTargeting=false

dotnet build -c Debug -f net10.0-windows10.0.22621.0
