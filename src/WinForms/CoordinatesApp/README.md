# Coordinates Manager - WinForms Application

A Windows Forms application for managing 2D coordinates with import/export capabilities, validation, and auto-save functionality.

## Requirements

- **.NET 6.0 SDK** (or higher) with Windows Desktop support
- Windows operating system

## Features

- **ListBox Display**: View all coordinates in format `id — (x, y) [label]`
- **Add/Update/Delete**: Full CRUD operations for coordinates
- **Validation**: 
  - ID must be unique and non-empty
  - X and Y must be valid numbers
- **Import/Export**: 
  - Support for JSON and CSV file formats
  - JSON format: Array of objects with `Id`, `X`, `Y`, `Label` properties
  - CSV format: Header line (optional) followed by rows: `Id,X,Y,Label`
- **Auto-save**: All changes automatically saved to `savedata.json` in the application directory
- **Context Menu**: Right-click on list items for quick delete
- **Status Bar**: Real-time feedback on operations

## File Formats

### JSON Format
```json
[
  {
    "Id": "P1",
    "X": 0.0,
    "Y": 0.0,
    "Label": "Origin"
  },
  {
    "Id": "P2",
    "X": 10.5,
    "Y": 20.3,
    "Label": "Node A"
  }
]
```

### CSV Format
```csv
Id,X,Y,Label
P1,0.0,0.0,Origin
P2,10.5,20.3,Node A
```

## How to Build and Run

### Using Command Line

1. Navigate to the project directory:
   ```bash
   cd src/WinForms/CoordinatesApp
   ```

2. Build the project:
   ```bash
   dotnet build
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

### Using Visual Studio 2022

1. Open `CoordinatesApp.csproj` in Visual Studio 2022
2. Press F5 to build and run

## Application Behavior

### On Startup
- The application attempts to load `savedata.json` from the application directory
- If `savedata.json` doesn't exist, it loads sample data from `coordinates.json`
- If neither file exists, it starts with an empty list

### Data Persistence
- All changes (add, update, delete) are automatically saved to `savedata.json`
- The file is located in the same directory as the application executable

### Validation Rules
- **ID**: Must not be empty and must be unique
- **X**: Must be a valid decimal number
- **Y**: Must be a valid decimal number
- **Label**: Optional text field

### Operations
- **Add**: Creates a new coordinate after validation
- **Update**: Modifies the selected coordinate (allows keeping the same ID)
- **Delete**: Removes the selected coordinate after confirmation
- **Import**: Replaces all coordinates with data from JSON or CSV file
- **Export JSON**: Saves all coordinates to a JSON file
- **Export CSV**: Saves all coordinates to a CSV file

## Project Structure

```
src/WinForms/CoordinatesApp/
├── Coordinate.cs              # Data model
├── CoordinatesForm.cs         # Business logic and event handlers
├── CoordinatesForm.Designer.cs # UI layout (auto-generated)
├── Program.cs                 # Application entry point
├── CoordinatesApp.csproj      # Project file
├── coordinates.json           # Sample data
└── README.md                  # This file
```

## Troubleshooting

### Build Errors
- Ensure .NET 6.0 SDK is installed: `dotnet --version`
- Verify Windows Desktop support is installed: `dotnet --list-sdks`

### Runtime Errors
- Check that the application has write permissions to its directory (for savedata.json)
- Ensure JSON/CSV import files are properly formatted

## License

This project is part of the 2DFRAME repository.
