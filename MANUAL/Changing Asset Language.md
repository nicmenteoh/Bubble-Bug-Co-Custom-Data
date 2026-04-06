[Before you begin](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Language)

## Unity Game Engine Require

You need to [download my Unity project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Language) in order to generate the language Language file. Any Unity version will do.

## Create CSV File (.csv)

You need to refer to my raw Language file in [Google Sheet](https://docs.google.com/spreadsheets/d/1wpwbEwJvGzeVNe-IJBKUN3Gzr9ZANENQ6jangaL2Yac/edit?usp=sharing) for making the language modification or translation. In the Google Sheet, refer to the bottom for different asset category language.

There are few categories of assets language as listed below:
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
  - Material
  - Region
  - Location
  - Elemental
  - Effect
  - Rank (Level)
  - Hunt Result (At the hunting summary which the image with purple background)

![Hunt Result Message](/Screenshot/Hunt%20Result%20Message.png)

Copy all the data in the Google Sheet to any excel program, including the first row of parameter name. I'm using LibreOffice Calc. You can make the modification or translation to name under `Language` parameter column. Do not change the name in the `ID` parameter column.

After you have made the change, save the file to csv format (.csv). Use the pipe or vertical symbol `|` to separate the Language between column. In LibreOffice Calc, after you save the file as csv, then put `|` symbol in `Field Delimiter` field.

![Save as csv in LibreOffice Calc](/Screenshot/CSV%20Column%20Separator.png)

The example bait language in csv file should look something like this:

![Bait Language csv](/Screenshot/Bait%20Language%20CSV.png)

The other category language in csv file are also look similar.

After you create the csv file, you have to rename the file to the name listed below:
| Category | CSV Filename |
| --- | --- |
| Fairy | Fairy Language.csv |
| Fairy Food | Fairy Food Language.csv |
| Bait | Bait Language.csv |
| Flavour | Flavour Language.csv |
| Weapon | Weapon Language.csv |
| Ammo | Ammo Language.csv |
| Crystal | Crystal Language.csv |
| Accessory | Accessory Language.csv |
| Unit | Unit Language.csv |
| Unit Family | Unit Family Language.csv |
| Material | Material Language.csv |
| Region | Region Language.csv |
| Location | Location Language.csv |
| Elemental | Elemental Language.csv |
| Effect | Effect Language.csv |
| Rank | Rank Language.csv |
| Hunt Result | Hunt Result Language.csv |

Then copy the csv file to the `csv` folder which I have prepared in my [Github project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Language).

> [!NOTE]
> Unity will not read any user files outside `Assets` folder. Therefore you will never find the `csv` folder in Project view.

## Special Character

You can add style such as bold, italic and colour, to the text by adding HTML tags. You can refer to Unity manual [here](https://docs.unity3d.com/Packages/com.unity.textmeshpro@3.2/manual/RichText.html).

`##`, `##1`, `##2`, `##3` and so on are special characters which will replaced by other word such as asset name and value. Do not change these characters. For example, you can translate the following sentence from English to Chinese like this:
| English | Chinese |
| --- | --- |
| Increase strength by `##1` but decrease luck by `##2`%. | 力量增加`##1`点但运气减少`##2`%。 |
| Rage level increase to `<color=#00ff00><b>##</b></color>`. | 暴怒级别上升至`<color=#00ff00><b>##</b></color>`级。 |

## Add Language Name for New Added Asset

If you have add your own data in asset data, then you also need to add the newly created asset ID in the relative language data. If not, your asset will display empty name in the game.

For example, if you add a new bait in bait data with your own ID `MYBAIT102`, then you have to add this ID `MYBAIT102` in a new row under `ID` parameter column in the fairy language. Also add your own bait name under `Language` parameter column.

## Create Language File from CSV File

You need to convert the csv file to language file. To do that, go to Unity menu bar at the top of the program. Navigate to `Data Generator -> Language -> Asset -> <The category language you want to generate>`, then click that option.

![Generate Asset Language File](/Screenshot/Generate%20Asset%20Language%20File.png)

2 files will be generated in `Assets/StreamingAssets/Language/Asset/` folder. You can refer the message in the Unity Console view.

![Bait Language File](/Screenshot/Bait%20Language%20File.png)

> [!NOTE]
> In case if you don't see the newly generated files, you can minimize the Unity program, then maximize it.

First is the json file (.json), readable text format. Open this file in any text editor. You can check if the language is correct. If language is wrong, you can repeat the above steps to generate a new one. The existing files will be replaced. This json file is just a reference, the game will not use it.

The second file is language file (.lang), in binary format. This is the file you need to put inside the mod folder.

> [!NOTE]
> Ignore the meta file (.meta). These files are only used by Unity.

> [!NOTE]
> Although Unity can read text file like csv at runtime, parsing all the string values to other data values such as integer and float take time. This will increase the loading time when you launch the game. Furthermore, there are tons of data need to be parsed if you put more data in the file, which can increase the loading time to few minutes. But in binary format file, no parsing need to be done.

## Mod Data Folder Structure

In your game device, create a new folder and rename it to `Language` in the folder of any name you put. In the `Language` folder, add another folder and rename it to `Asset`. The folder path should look something like this `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Language/Asset/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Language/Asset/`. Copy the language file to the `Asset` folder.

After you do all the steps above, you can launch the game.
