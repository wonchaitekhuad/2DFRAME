# UI Layout Description

## Application Window: "Graphical 2D Frame - Coordinate Input"

### Left Panel (Input and List Controls)

```
┌─────────────────────────────────┐
│ X: [______2.5_______]           │ (Line 12-15)
│                                  │
│ Y: [______3.0_______]           │ (Line 38-41)
│                                  │
│ [ เพิ่ม (Add) / บันทึก (Save) ] │ (Line 64) - Changes text in edit mode
│ [ ยกเลิก (Cancel) ]             │ (Line 64) - Overlays Add, hidden initially
│                                  │
│ [ แก้ไข (Edit) ]                │ (Line 93)
│                                  │
│ [ ลบ (Remove) ]                  │ (Line 122)
│                                  │
│ รายการพิกัด (List)              │ (Line 156)
│ ┌─────────────────────────────┐ │
│ │ 2.5, 3.0                    │ │ (Line 174)
│ │ 5.0, 7.0                    │ │
│ │ -3.0, 4.5                   │ │
│ │ ...                         │ │
│ └─────────────────────────────┘ │
└─────────────────────────────────┘
```

### Right Panel (Canvas)

```
┌─────────────────────────────────────────────────────────────┐
│ พื้นที่แสดงผล (Canvas)                                      │
│                                                               │
│                         Y-axis                                │
│                            │                                  │
│                            │                                  │
│                            │        • (2.5, 3.0)              │
│                            │       ╱│╲                        │
│                            │      ──┼──  ← crosshair          │
│                            │       ╲│╱                        │
│                            │                                  │
│ ─────────────────────────  + ────────────────── X-axis       │
│                       Origin│                                 │
│                            │                                  │
│                  • (-3, 4.5)│                                 │
│                            │                                  │
│                            │                                  │
│                            │           • (5, 7)               │
│                            │                                  │
└─────────────────────────────────────────────────────────────┘
```

## UI States

### Normal Mode (Default)
- Add button shows: "เพิ่ม (Add)"
- Cancel button: Hidden
- Edit button: Enabled
- Remove button: Enabled
- Textboxes: Empty

### Edit Mode (After double-click or clicking Edit)
- Add button shows: "บันทึก (Save)"
- Cancel button: Visible (overlays Add position, so effectively replaces it visually)
- Edit button: Disabled
- Remove button: Disabled
- Textboxes: Populated with selected coordinate values

## Visual Elements on Canvas

Each coordinate point is drawn with:
1. **Red filled circle** (10px diameter, 5px radius)
2. **Blue crosshair** (16px span, 2px thick lines)
3. **Black text label** showing "(x, y)" coordinates positioned 10px right and up from point
4. **Gray axes** (horizontal and vertical, 1px thick)
5. **Anti-aliased rendering** for smooth graphics

## Color Scheme

- Canvas background: White
- Canvas border: Black (FixedSingle)
- Axes: Gray
- Points: Red fill
- Crosshair: Blue
- Labels: Black text (Arial, 8pt)
- Form background: System default

## Coordinate System

- Origin (0, 0) at center of canvas
- X-axis: Left (negative) to Right (positive)
- Y-axis: Down (negative) to Up (positive) - inverted from screen coordinates
- Scale: 10 pixels per unit
- Canvas size: 600 x 405 pixels
