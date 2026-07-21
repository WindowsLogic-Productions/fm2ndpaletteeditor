# FM2nd Palette Editor

## ⚠️ DISCLAIMER

Use this software at your own risk.
A backup is automatically created when saving, but you should always keep your own project backups.
The author assumes no responsibility for software usage or for any data loss that may occur.

FM2nd Palette Editor is a desktop tool for editing **Fighter Maker 2002** palettes.

It opens `.player` files and lets you edit the **8 global palettes**.

## What you can do

- View all 8 global palettes
- See both palettes:
  - **Source** palette (original)
  - **Result** palette (after your edits)
- Build a chain of color changes
  - RGB adjustments
  - HLS adjustments
- Apply changes to:
  - the whole palette, or
  - only colors matched by the color filter
- Choose the comparison method used by the color filter
- Browse all character images to preview the applied result on different sprites

## How to use

1. Open a `.player` file.
2. Select one of the 8 palettes.
3. Select a step in the change chain.
4. Set RGB and/or HLS values.
5. (Optional) Enable the color filter and choose a target color.
6. Adjust **Range** to control how many nearby colors are included.
7. Adjust **Blend** to control how soft or sharp the transition is.
8. Choose the comparison method if needed.
9. Check **Source** and **Result** palettes.
10. Browse character images to verify the result across multiple sprites.
11. When satisfied, click **Save**.
12. The edited palette is written to the selected target palette.

## Color filter controls

- **Range**: expands or narrows the set of affected colors.
- **Blend**: controls transition softness between selected and non-selected colors.
- **Comparison method**: defines how color similarity is evaluated.

## Notes

- Only images using the global palette are affected by global palette edits,
  so images that use a private palette are not modified.
- A backup is automatically created when saving.
- You should always keep your own project backups before editing files.
- The author assumes no responsibility for software usage or for any data loss that may occur.
