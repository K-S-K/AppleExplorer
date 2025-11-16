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

## Build the project on Mac

```bash
dotnet publish -c Release -f net10.0-maccatalyst -r maccatalyst-arm64 -o ./publish
```

## Execution on Mac

```bash
open AppleExplorer.Desktop.app
```

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
