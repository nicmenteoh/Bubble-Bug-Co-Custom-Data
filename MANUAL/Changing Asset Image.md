[Before you begin](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data)

## Asset Image Category

There are few categories of assets as listed below:
  - Fairy
  - Fairy Food
  - Bait
  - Flavour
  - Weapon
  - Ammo
  - Crystal
  - Accessory
  - Unit (Bugs)
  - Unit Family (Type of bugs)
  - Character (NPC)
  - Material
  - Location
  - Elemental
  - Effect
  - Rank (Level)
  - Hunt Result (At the hunting summary which the image with purple background)

![Hunt Result Message](/Screenshot/Hunt%20Result%20Message.png)

I will not include changing UI panel images in this manual but you can find the instruction in manual [here](MANUAL/Changing UI Panel Image and Data.md).

## Supported Image Format

Only support JPG and PNG image.

## Image Filename Format

Each image has its own image ID. The filename should be looked something like this: `WEA3A_WeaponName`.

There are 2 sections in the filename. Each section is separated by underscore symbol `_`. The left section is the image ID which you need to follow. The right section is the image name which you can put whatever name for your reference.

> [!WARNING]
> If the underscore symbol `_` is not found in the filename, the whole filename, including the file extension, will be treated as image ID, which can result your image not in use.

All the images ID reference can be found in this [Google Sheets](https://docs.google.com/spreadsheets/d/1H0ssBZ87hrlcNWvUHXMg8Yd0KMeTFO7Gn6O1GhPXG4E/edit?usp=sharing).

> [!NOTE]
> All the ID in the Google Sheets are default. The image ID can be modified in the data file.

## Mod Sprite Folder Structure

In your game device, you need to add a new folder and rename it to `Sprite` in the folder of any name you put. The folder path should look something like this `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Sprite/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Sprite/`.

To increase the loading time, I have separate the images into few categories as listed above. In the `Sprite` folder, you need to create a new folder and rename to appropriate category name as listed below:
| Category | Folder Name |
| --- | --- |
| Fairy | Fairy |
| Fairy Food | Fairy_Food |
| Bait | Bait |
| Flavour | Flavour |
| Weapon | Weapon |
| Ammo | Ammo |
| Crystal | Crystal |
| Accessory | Accessory |
| Unit | Unit |
| Unit Family | Unit_Family |
| Character | Character |
| Material | Material |
| Location | Location |
| Elemental | Elemental |
| Effect | Effect |
| Rank | Rank |
| Hunt Result | Hunt_Result |

Refer to the [Google Sheets](https://docs.google.com/spreadsheets/d/1H0ssBZ87hrlcNWvUHXMg8Yd0KMeTFO7Gn6O1GhPXG4E/edit?usp=sharing), you will notice some categories have portrait and thumbnail column, some categories have silhouette column, and some categories have none. Portrait, thumbnail and silhouette have its own image ID. If none, it means the Code/Image ID column is used for portrait and thumbnail, and there will have no silhouette for these categories.

## Example

If you want to change the unit image, you need to prepare 3 images: portrait, thumbnail and silhouette. Let say you want to change images for unit with code ID `UNI11`, you need to rename the portrait image to `UNI11A_YourImageName.png`, silhouette image to `UNI11B_YourImageName.png` and thumbnail image to `UNI11C_YourImageName.png`. Then copy these images into the folder `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Sprite/Unit/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Sprite/Unit/` in your game device.

Similar with changing unit family image. Since there are no separate images for portrait, thumbnail and silhouette, you just need to prepare 1 image. Let say you want to change image for unit family with code ID `FAM2`, then rename the image to `FAM2_YourImageName.png`. Copy the image into the folder `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Sprite/Unit_Family/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Sprite/Unit_Family/` in your game device.
