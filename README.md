# Graphical 2D Frame - Coordinate Input Application

A Windows Forms application that allows users to input X and Y coordinates through a UI, store them in a ListBox, and visualize them on a 2D canvas.

## Features

- **Coordinate Input**: Enter X and Y coordinates using text boxes
- **Add/Remove Coordinates**: Add new coordinates or remove selected ones from the list
- **Edit Coordinates**: Edit existing coordinates via Edit button or double-click
- **Visual Display**: Automatically draws points on a 2D canvas with coordinate axes
- **Input Validation**: Validates numeric input and displays appropriate error messages
- **Enter Key Support**: Press Enter in the Y field to quickly add/save coordinates
- **InvariantCulture Support**: Handles decimal points correctly regardless of system locale

## Requirements

- .NET Framework 4.7.2 or higher
- Windows operating system
- Visual Studio 2019 or later (for development)

## Usage

### Adding Coordinates
1. Enter X coordinate in the X textbox
2. Enter Y coordinate in the Y textbox
3. Click "เพิ่ม (Add)" button or press Enter to add the coordinate
4. The coordinate will appear in the list and be drawn on the canvas

### Editing Coordinates
1. Double-click a coordinate in the list, OR select it and click "แก้ไข (Edit)"
2. The coordinate values will populate the X and Y textboxes
3. Modify the values as needed
4. Click "บันทึก (Save)" button or press Enter to save changes
5. Click "ยกเลิก (Cancel)" to cancel editing without saving

### Removing Coordinates
1. Select a coordinate from the list
2. Click "ลบ (Remove)" to delete it

## Building

Open the solution in Visual Studio and build the project:
```
dotnet build CoordinateApp.csproj
```

Or use MSBuild:
```
msbuild CoordinateApp.csproj
```

## Testing

### Manual Verification Steps

1. **Add coordinate**: Enter 2.5 for X and 3.0 for Y, then click Add
   - Verify: "2.5, 3.0" appears in the ListBox
   - Verify: A point is drawn on the canvas
   
2. **Edit via double-click**: Double-click a coordinate in the list
   - Verify: The X and Y fields are populated with the coordinate values
   - Verify: The Add button changes to "บันทึก (Save)"
   - Verify: The Cancel button becomes visible
   - Verify: Edit and Remove buttons are disabled
   
3. **Save edited coordinate**: After editing, modify the values and click Save or press Enter
   - Verify: The coordinate is updated in the list
   - Verify: The point is redrawn at the new location
   - Verify: UI returns to normal mode
   
4. **Cancel editing**: Enter edit mode and click Cancel
   - Verify: No changes are saved
   - Verify: UI returns to normal mode
   
5. **Remove coordinate**: Select a coordinate from the list and click Remove
   - Verify: The coordinate is removed from the list
   - Verify: The corresponding point disappears from the canvas
   
6. **Invalid input**: Enter non-numeric text (e.g., "abc") and click Add
   - Verify: A MessageBox appears with error message
   - Verify: No coordinate is added to the list

7. **Enter key**: Enter coordinates and press Enter in the Y field
   - Verify: The coordinate is added (or saved if editing) without clicking the button

## Architecture

- **Form1.cs**: Main form with UI logic and coordinate management
- **coordinates**: `List<PointF>` storing all coordinate points
- **Drawing**: Uses PictureBox Paint event with coordinate transformation
- **Validation**: Uses `float.TryParse` with `InvariantCulture` for proper decimal handling

## License

This project is provided as-is for educational and development purposes.
