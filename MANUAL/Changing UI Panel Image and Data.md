[Before you begin](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data)

## Get UI Panel Template

There are many UI panels in the game. You can refer to my [Google Sheets](https://docs.google.com/spreadsheets/d/1H0ssBZ87hrlcNWvUHXMg8Yd0KMeTFO7Gn6O1GhPXG4E/edit?usp=sharing) under UI sheet to get the image ID. Unless you know which image is assign to which UI panel, else you are recommended to [download my Unity project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data) to search for the UI panel template. Any Unity version will do.
> [!NOTE]
> Of course you need to have some knowledge to operate Unity game engine especially at UI part. There are tons of tutorial out there and it is not hard to learn.

After you open the project in Unity, go to Project view and search for `Assets/Prefab/UI/` folder. You will see all the panel prefab (templates) in that folder. Double click the prefab file to open it.

![UI Panel Prefab](/Screenshot/Unity%20Project%20View%20Panel.png)

## Look for Image ID

I have opened the `PAN4_Camp Display Panel` prefab and it looks like this:

![Camp Display Panel](/Screenshot/Camp%20Display%20Panel%20Template.png)

All the individual image and text game objects are in the Hierarchy view. Select any image game object and refer to Inspector view. Under `Rect Transform` component, look for `Width` and `Height` field. This is the resolution of the image.

> [!TIP]
> In case you can't identify which game object is image or text. For the image game object, there is an `Image` component in the Inspector view. For the text game object, there is an `TextMesgPro - Text (UI)` component in the Inspector view.

> [!NOTE]
> Under `Image` component, you will see there is different colour in the `Color` field. This is just to make the template easy to see. In the game, all the colour of the image will be in white colour and in 100% opacity. You have to make your own colour and alpha in your image.

I store the image ID in script file. You can open the file using any text editor. Go to Project view and search for `Assets/Script/Editor/Panel/` folder. There are 2 folders inside, Activity and General. All the image ID for activity panels are stored inside Activity folder. You can compare the name of the prefab with the name of the script. For the `PAN4_Camp Display Panel`, the script name is `CampPanelDataGenerator`. If you not sure what you are looking for, you can find the prefab refer to the script info at the bottom of this manual.

The script is in C# programming language. If you familiar with Object Oriented Programming, the script is easy to understand. When you go through the script, you will notice there are a lot of ID with `GUIxxx` and `255,255,255,255`. `GUIxxx` is the image ID and `255,255,255,255` is the colour of the text.

To know which image ID is associated with which image game object in the panel prefab, you just need to compare the name of the game object.

![Game Object Name](/Screenshot/Game%20Object%20Name%20and%20ID.png)

## Supported Image Format

Only support JPG and PNG image.

## Image Filename Format

The filename should be looked something like this: `WEA3A_WeaponName`.

There are 2 sections in the filename. Each section is separated by underscore symbol `_`. The left section is the image ID which you need to follow. The right section is the image name which you can put whatever name for your reference.

> [!WARNING]
> If the underscore symbol `_` is not found in the filename, the whole filename, including the file extension, will be treated as image ID, which can result your image not in use.

## Mod Sprite Folder Structure

In your game device, you need to add a new folder and rename it to `Sprite` in the folder of any name you put. In the `Sprite` folder, add another folder and rename it to `UI`. The folder path should look something like this `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Sprite/UI/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Sprite/UI/`. Then put all your UI image files inside the `UI` folder.

## Modify the Data in Script File

Some images are shared with few panels. Therefore you will see same image ID appear in some scripts, especially the `background_id` and `midground_id`. If you don't want that image ID share with other panel, you can create your own image ID.

For example and refer to the image above, let say you want to change the image ID in `background_id` because you don't want the image share with other panel, you can change the image ID from `GUI31` to whatever ID you want, for example ID change to `IMG1312`. The line in the script will look something like this: `background_id = "IMG1312".ToLower (),`. After that, rename you new image name to something like this `IMG1312_YourImageName` and put inside the `UI` folder.

> [!IMPORTANT]
> Do not use the ID start with the alphabet characters same with mine because it may crash with my ID at future update. It is also not recommended to have a long ID. 6 to 10 characters are suffice.

Changing the text colour is easier. You just need to find out the text game object by compare the name of the game object and inside the script file. Get the colour code in `R,G,B,A` format. The value is between `0 to 255`. For example and refer back to the image above, if you want to change the colour in `camp_title` from white to light green with a little transparency, the line in the script will look something like this: `camp_title = "162,230,178,230",`. You can tweak the colour in Unity then get the colour code.

![Text Colour](/Screenshot/Text%20Colour.png)

## Additional Information

In the game object in some prefab, the names have additional keyword in it. Refer to the table below:
| Keyword | Sample | Description |
| --- | --- | --- |
| `<` `>` | `<`fairy_id`>` | This image will be replaced by asset portrait, thumbnail or silhouette. |
| `--` `--` | `--` Scroll View `--` | Just ignore this game object. |
| `ASH` | discount_id `ASH` | The image will be auto scale horizontally. |
| `ASV` | scroll_view_handler `ASV` | The image will be auto scale vertically. |

There's are some additional parameter in certain script. Refer to the table below:
| Parameter | Description |
| --- | --- |
| intro_id | The dialogue happen when you visit the shop at the first time. Make sure the dialogue ID is exist in [dialogue data](/MANUAL/Changing%20Dialogue%20Data.md). |
| material_sprite | The material icon display in the panel. Refer to the parameter inside. Make sure the material ID is exist in [material data](/MANUAL/Changing%20Asset%20Data.md#changing-material-data). |
| dialogue | The dialogue happen after you purchase items the shop. There are 2 parameters inside. `character_id` is which character to display. If you put your own character ID, make sure your character image has this character ID in the [image mod folder](/MANUAL/Changing%20Asset%20Image.md). `position_LR` is either the character is display at the left or right. Use `L` for left and `R` for right. |

The following parameter only exist in `FairyBakeryPanelDataGenerator` script:
| Parameter | Description |
| --- | --- |
| before_gift_intro_id | The dialogue happen when you visit the shop at the first time and before you receive the fairy food. |
| after_gift_intro_id | The dialogue happen when you visit the shop at the first time and after you receive the fairy food. |
| low_fairy_food_dialogue_id | The dialogue happen when you visit the shop and your fairy food is running low. The quantity you can change in [config data](/MANUAL/Changing%20Config%20Data.md). |

Make sure all the dialogue ID is exist in [dialogue data](/MANUAL/Changing%20Dialogue%20Data.md).

## Location Background Image

In some scripts, you will see `location_background_id` but it is not found in the panel prefab. This is the location image for the background of all the panels. This image is always overridden by each other in an image game object. Therefore it does not need to include in the panel. The default resolution for the location image is 1440 width x 2560 height. You can use any resolution for the image as long as its ratio is 9:16 to prevent image stretching and squeezing.

## Create Data File After Modify ID in Script

Unity cannot compile and run the newly modified script at runtime. Therefore you need to convert the data in the script to a data file. To do that, go to Unity menu bar at the top of the program. Navigate to `Data Generator -> Panel -> General -> Camp`, then click the option.

![Generate Camp Panel Data File](/Screenshot/Generate%20Camp%20Panel%20Data%20File.png)

> [!TIP]
> There are lots of panel there which can make you confuse. You can always refer the name at the associated script, at the attribute above the function name.
![Panel Menu Bar Name](/Screenshot/Panel%20Menu%20Bar%20Name.png)

2 files will be generated in `Assets/StreamingAssets/Data/Panel/` folder. You can refer the message in the Unity Console view.

![Camp Panel Data File](/Screenshot/Camp%20Panel%20Data%20File.png)

> [!NOTE]
> In case if you don't see the newly generated files, you can minimize the Unity program, then maximize it.

First is the json file (.json), readable text format. Open this file in any text editor. You can check if the data is correct. If data is wrong, you can repeat the above steps to generate a new one. The existing files will be replaced. This json file is just a reference, the game will not use it.

The second file is data file (.data), in binary format. This is the file you need to put inside the mod folder.

> [!NOTE]
> Ignore the meta file (.meta). These files are only used by Unity.

> [!NOTE]
> Although Unity can read text file like json at runtime, parsing all the string values to other data values such as integer and float take time. This will increase the loading time when you launch the game. Furthermore, there are tons of data need to be parsed if you put more data in the file, which can increase the loading time to few minutes. But in binary format file, no parsing need to be done.

## Mod Data Folder Structure

In your game device, create a new folder and rename it to `Data` in the folder of any name you put. In the `Data` folder, add another folder and rename it to `Panel`. The folder path should look something like this `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Data/Panel/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Data/Panel/`. Copy the data file to the `Panel` folder. In this example, the data file is `PAN4.data`.

After you do all the steps above, you can launch the game.

## Name and ID of Panel Prefab Associated to the Script

General Panel
| Prefab Name | Script Name |
| --- | --- |
| PAN2_Top Bar Info | TopBarInfoDataGenerator |
| PAN3_Bottom Menu | BottomMenuDataGenerator |
| PAN4_Camp Display Panel | CampPanelDataGenerator |
| PAN5_Transition Loading | TransitionLoadingDataGenerator |
| PAN6_Hunt Result Panel | HuntResultDataGenerator |
| PAN7_Hunt History Panel | HuntHistoryDataGenerator |
| PAN8_Change Trap Setup Panel | ChangeTrapSetupDataGenerator |
| PAN9_Main Menu Panel | MainMenuDataGenerator |
| PAN10_Top Bar Hunt | TopBarHuntDataGenerator |
| PAN11_Gallery Category | GalleryCategoryPanelDataGenerator |
| PAN12_Gallery Unit Location | GalleryUnitLocationPanelDataGenerator |
| PAN13_Gallery Unit | GalleryUnitPanelDataGenerator |
| PAN14_Gallery Unit Statistic | GalleryUnitStatisticDataGenerator |
| PAN15_Gallery Fairy | GalleryFairyPanelDataGenerator |
| PAN16_Gallery Fairy Statistic | GalleryFairyStatisticPanelDataGenerator |
| PAN17_Gallery Weapon | GalleryWeaponPanelDataGenerator |
| PAN18_Gallery Weapon Statistic | GalleryWeaponStatisticPanelDataGenerator |
| PAN19_Gallery Bait | GalleryBaitPanelDataGenerator |
| PAN20_Gallery Bait Statistic | GalleryBaitStatisticPanelDataGenerator |
| PAN21_Gallery Flavour | GalleryFlavourPanelDataGenerator |
| PAN22_Gallery Flavour Statistic | GalleryFlavourStatisticPanelDataGenerator |
| PAN23_Dialogue Panel | DialoguePanelDataGenerator |
| PAN24_Food Stall | FoodStallPanelDataGenerator |
| PAN25_Food Stall Purchase | FoodStallPurchasePanelDataGenerator |
| PAN26_Special Reward | SpecialRewardDataGenerator |
| PAN27_Catch Effectiveness Panel | CatchEffectivenessDataGenerator |
| PAN28_Tutorial_Camp Display Panel | TutorialCampPanelDataGenerator |
| PAN29_Tutorial Hunt Result Panel | TutorialHuntResultDataGenerator |
| PAN30_Tutorial Change Location Panel | TutorialChangeLocationDataGenerator |
| PAN31_Warehouse | WarehouseDataGenerator |
| PAN32_Reward Summary Panel | RewardSummaryDataGenerator |
| PAN33_Rank Level Up | LevelUpDataGenerator |
| PAN34_Smith | SmithPanelDataGenerator |
| PAN35_Smith Purchase | SmithPurchasePanelDataGenerator |
| PAN36_Ammo Dealer Weapon | AmmoDealerWeaponPanelDataGenerator |
| PAN37_Ammo Dealer Ammo | AmmoDealerAmmoPanelDataGenerator |
| PAN38_Ammo Dealer Purchase | AmmoDealerPurchasePanelDataGenerator |
| PAN39_Fairy Bakery | FairyBakeryPanelDataGenerator |
| PAN40_Fairy Bakery Purchase | FairyBakeryPurchasePanelDataGenerator |
| PAN41_Cage Master | CageMasterPanelDataGenerator |
| PAN42_Cage Master Purchase | CageMasterPurchasePanelDataGenerator |
| PAN43_Inventory Category | InventoryCategoryPanelDataGenerator |
| PAN44_Inventory | InventoryPanelDataGenerator |
| PAN45_Material Detail Panel | MaterialDetailDataGenerator |
| PAN46_Craftsman | CraftsmanPanelDataGenerator |
| PAN47_Craftsman Purchase | CraftsmanPurchasePanelDataGenerator |
| PAN48_Crystal Lab | CrystalLabPanelDataGenerator |
| PAN49_Crystal Lab Purchase | CrystalLabPurchasePanelDataGenerator |
| PAN50_Accessory Maker | AccessoryMakerPanelDataGenerator |
| PAN51_Accessory Maker Purchase | AccessoryMakerPurchasePanelDataGenerator |
| PAN52_Gallery Crystal | GalleryCrystalPanelDataGenerator |
| PAN53_Gallery Crystal Statistic | GalleryCrystalStatisticPanelDataGenerator |
| PAN54_Gallery Accessory | GalleryAccessoryPanelDataGenerator |
| PAN55_Gallery Accessory Statistic | GalleryAccessoryStatisticPanelDataGenerator |
| PAN58_Setting | SettingPanelDataGenerator |
| PAN59_Setting Gameplay | SettingGameplayPanelDataGenerator |
| PAN60_Setting Backup Save | SettingBackupSavePanelDataGenerator |
| PAN61_Setting Restore Save | SettingRestoreSavePanelDataGenerator |
| PAN62_Setting Delete Save | SettingDeleteSavePanelDataGenerator |
| PAN63_Setting Audio | SettingAudioPanelDataGenerator |
| PAN64_Statistic | StatisticPanelDataGenerator |
| PAN65_Statistic Gameplay | StatisticGameplayPanelDataGenerator |
| PAN66_Statistic Discovery | StatisticDiscoveryPanelDataGenerator |
| PAN67_Credit | CreditPanelDataGenerator |
| PAN68_Fairy Level Up | FairyLevelUpDataGenerator |

Activity Panel
| Prefab Name | Script Name |
| --- | --- |
| PAN56_Wood Cabin Activity Panel | WoodCabinActivityPanelDataGenerator |
| PAN57_Wood House Activity Panel | WoodHouseActivityPanelDataGenerator |
