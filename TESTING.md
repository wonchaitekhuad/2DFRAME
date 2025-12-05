# Testing Guide

## Prerequisites
- Windows OS
- Visual Studio 2019 or later with .NET Framework 4.7.2 support
- Or .NET Framework 4.7.2 SDK

## Building the Application

### Using Visual Studio
1. Open `CoordinateApp.csproj` in Visual Studio
2. Build the solution: `Build > Build Solution` (Ctrl+Shift+B)
3. Run the application: `Debug > Start Debugging` (F5)

### Using MSBuild (Command Line)
```bash
msbuild CoordinateApp.csproj /p:Configuration=Release
```

The executable will be created in `bin/Release/CoordinateApp.exe`

## Manual Testing Steps

### Test 1: Add Valid Coordinates
**Objective**: Verify that valid decimal coordinates can be added

**Steps**:
1. Launch the application
2. Enter `2.5` in the X textbox
3. Enter `3.0` in the Y textbox
4. Click "เพิ่ม (Add)" button

**Expected Results**:
- ✓ The string "2.5, 3.0" appears in the ListBox
- ✓ A red circle with blue crosshair appears on the canvas
- ✓ Coordinate label "(2.5, 3.0)" is displayed near the point
- ✓ Input fields are cleared
- ✓ Focus returns to X textbox

### Test 2: Add Multiple Coordinates
**Objective**: Verify multiple coordinates can be added and displayed

**Steps**:
1. Add coordinate (5, 5)
2. Add coordinate (10, -3)
3. Add coordinate (-7, 8)
4. Add coordinate (0, 0)

**Expected Results**:
- ✓ All four coordinates appear in the ListBox
- ✓ All four points are drawn on the canvas at correct positions
- ✓ Origin point (0, 0) appears at the center where axes intersect

### Test 3: Remove Coordinate
**Objective**: Verify coordinates can be removed

**Steps**:
1. Add several coordinates (e.g., (2, 3), (5, 7), (8, 1))
2. Select the middle coordinate "(5, 7)" in the ListBox
3. Click "ลบ (Remove)" button

**Expected Results**:
- ✓ Selected coordinate is removed from the ListBox
- ✓ Corresponding point disappears from the canvas
- ✓ Other points remain displayed correctly

### Test 4: Invalid Input - Non-Numeric
**Objective**: Verify proper validation for non-numeric input

**Steps**:
1. Enter `abc` in the X textbox
2. Enter `123` in the Y textbox
3. Click "เพิ่ม (Add)" button

**Expected Results**:
- ✓ MessageBox appears with Thai message: "กรุณาใส่ตัวเลขสำหรับ X และ Y"
- ✓ No coordinate is added to the ListBox
- ✓ No point is drawn on the canvas
- ✓ Input fields retain their values

### Test 5: Invalid Input - Empty Fields
**Objective**: Verify handling of empty input fields

**Steps**:
1. Leave both X and Y textboxes empty
2. Click "เพิ่ม (Add)" button

**Expected Results**:
- ✓ MessageBox appears with error message
- ✓ No coordinate is added
- ✓ Application does not crash

### Test 6: Enter Key Support
**Objective**: Verify Enter key functionality in Y textbox

**Steps**:
1. Enter `4.2` in X textbox
2. Tab or click to Y textbox
3. Enter `6.8` in Y textbox
4. Press Enter key (do not click Add button)

**Expected Results**:
- ✓ Coordinate "4.2, 6.8" is added to the ListBox
- ✓ Point is drawn on the canvas
- ✓ Same behavior as clicking the Add button

### Test 7: Decimal Point Formats
**Objective**: Verify InvariantCulture decimal handling

**Steps**:
1. Enter `1.5` (with period) in both X and Y
2. Click Add

**Expected Results**:
- ✓ Coordinate is added successfully
- ✓ Decimal values are parsed correctly regardless of system locale

### Test 8: Negative Coordinates
**Objective**: Verify negative coordinates are handled properly

**Steps**:
1. Add coordinate (-5, 3)
2. Add coordinate (4, -6)
3. Add coordinate (-2, -8)

**Expected Results**:
- ✓ All negative coordinates appear in the ListBox
- ✓ Points are drawn in correct quadrants on the canvas
- ✓ Negative X values appear on the left of center
- ✓ Negative Y values appear below center

### Test 9: Canvas Visualization
**Objective**: Verify proper canvas rendering

**Expected Results**:
- ✓ Gray axes are drawn (horizontal and vertical)
- ✓ Axes intersect at center of the PictureBox
- ✓ Each point is rendered with:
  - Red filled circle (radius 5)
  - Blue crosshair (16 pixels total span)
  - Black text label showing coordinates
- ✓ Anti-aliasing is enabled for smooth graphics

### Test 10: Edit via Double-Click
**Objective**: Verify editing coordinates via double-click

**Steps**:
1. Add coordinates (2.5, 3.0) and (5.0, 7.0)
2. Double-click on the coordinate "(2.5, 3.0)" in the ListBox

**Expected Results**:
- ✓ X textbox is populated with "2.5"
- ✓ Y textbox is populated with "3.0"
- ✓ Add button text changes to "บันทึก (Save)"
- ✓ Cancel button becomes visible at same position as Add button
- ✓ Edit button is disabled
- ✓ Remove button is disabled
- ✓ Focus is on X textbox with text selected

### Test 11: Edit via Edit Button
**Objective**: Verify editing coordinates via Edit button

**Steps**:
1. Add several coordinates
2. Select a coordinate from the ListBox
3. Click "แก้ไข (Edit)" button

**Expected Results**:
- ✓ Same behavior as double-click test above
- ✓ UI enters edit mode correctly

### Test 12: Save Edited Coordinate
**Objective**: Verify saving edited coordinates

**Steps**:
1. Add coordinate (10.0, 15.0)
2. Double-click the coordinate to edit
3. Change X to "12.5"
4. Change Y to "18.0"
5. Click "บันทึก (Save)" button

**Expected Results**:
- ✓ ListBox item updates to "12.5, 18.0"
- ✓ Point on canvas moves to new location
- ✓ UI returns to normal mode (Add button shows "เพิ่ม (Add)")
- ✓ Cancel button becomes hidden
- ✓ Edit and Remove buttons are re-enabled
- ✓ Input fields are cleared

### Test 13: Save with Enter Key in Edit Mode
**Objective**: Verify Enter key saves changes in edit mode

**Steps**:
1. Add and edit a coordinate
2. Modify the values
3. Press Enter while in Y textbox

**Expected Results**:
- ✓ Changes are saved
- ✓ Same behavior as clicking Save button
- ✓ UI exits edit mode

### Test 14: Cancel Editing
**Objective**: Verify canceling edit operation

**Steps**:
1. Add coordinate (5.0, 7.0)
2. Double-click to edit
3. Change values to (99.0, 88.0)
4. Click "ยกเลิก (Cancel)" button

**Expected Results**:
- ✓ Original coordinate "(5.0, 7.0)" remains unchanged in ListBox
- ✓ Point on canvas stays at original location
- ✓ UI returns to normal mode
- ✓ Input fields are cleared

### Test 15: Edit Button Without Selection
**Objective**: Verify Edit button behavior without selection

**Steps**:
1. Add some coordinates
2. Ensure nothing is selected in ListBox
3. Click "แก้ไข (Edit)" button

**Expected Results**:
- ✓ MessageBox appears with message: "กรุณาเลือกพิกัดที่ต้องการแก้ไข"
- ✓ UI remains in normal mode
- ✓ No editing occurs

### Test 16: Invalid Input During Edit
**Objective**: Verify validation works in edit mode

**Steps**:
1. Add and edit a coordinate
2. Enter "abc" in X field
3. Enter "5.0" in Y field
4. Click Save

**Expected Results**:
- ✓ MessageBox appears with validation error
- ✓ Coordinate is not updated
- ✓ UI remains in edit mode
- ✓ User can correct the input or cancel

### Test 17: Edit and Remove Disabled in Edit Mode
**Objective**: Verify Edit and Remove buttons are disabled during editing

**Steps**:
1. Add multiple coordinates
2. Enter edit mode by double-clicking a coordinate

**Expected Results**:
- ✓ Edit button is disabled (grayed out)
- ✓ Remove button is disabled (grayed out)
- ✓ User cannot edit or remove other items while in edit mode

### Test 18: Remove Without Selection
**Objective**: Verify behavior when Remove is clicked without selection

**Steps**:
1. Add some coordinates
2. Click anywhere outside the ListBox to deselect
3. Click "ลบ (Remove)" button

**Expected Results**:
- ✓ Nothing happens (or no error occurs)
- ✓ Application remains stable

## Known Limitations
- Canvas uses fixed scale (10 pixels per unit)
- Very large coordinate values may draw outside visible canvas area
- No zoom or pan functionality
- ListBox and coordinate list indices are synchronized

## UI Layout Description

```
┌─────────────────────────────────────────────────────────┐
│  Graphical 2D Frame - Coordinate Input                  │
├─────────────────────────────────────────────────────────┤
│  X: [________]           พื้นที่แสดงผล (Canvas)        │
│  Y: [________]          ┌────────────────────────┐      │
│                         │         │              │      │
│  [เพิ่ม (Add)]          │         │              │      │
│  [ลบ (Remove)]          │─────────┼──────────────│      │
│                         │         │      ●       │      │
│  รายการพิกัด (List)     │         │   (2.5, 3.0) │      │
│  ┌──────────────┐       │         │              │      │
│  │ 2.5, 3.0     │       └────────────────────────┘      │
│  │ 5.0, 7.0     │                                       │
│  │              │                                       │
│  └──────────────┘                                       │
└─────────────────────────────────────────────────────────┘
```

## Performance Testing
- Add 100+ coordinates and verify UI remains responsive
- Rapidly add/remove coordinates to test memory management
- Verify no memory leaks after extended use

## Security Testing
✓ CodeQL analysis completed with 0 vulnerabilities
✓ Proper resource disposal (Pen, Font objects)
✓ Exception handling prevents crashes
✓ Input validation prevents invalid data entry
