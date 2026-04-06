[Before you begin](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data)

## Unity Game Engine Require

You need to [download my Unity project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data) in order to generate the asset data file. Any Unity version will do.

## Create CSV File (.csv)

You need to refer to my raw data file in [Google Sheet](https://docs.google.com/spreadsheets/d/1KRZlh-iYcwuQnRf7ehRWOs63r7CGIzJ9ogay1_m13K0/edit?usp=sharing) for the data you can change. 

Copy all the dialogue data in the Google Sheet to any excel program, including the first row of parameter name. I'm using LibreOffice Calc. I'll explain what the parameter in each column does to the game in this manual below.

After you have made the change, save the file to csv format (.csv). Use the pipe or vertical symbol `|` to separate the data between column. In LibreOffice Calc, after you save the file as csv, then put `|` symbol in `Field Delimiter` field.

![Save as csv in LibreOffice Calc](/Screenshot/CSV%20Column%20Separator.png)

The example Dialogue data in csv file should look something like this:

![Dialogue Data csv](/Screenshot/Dialogue%20Data%20CSV.png)

After you create the csv file, you have to rename the file to `Dialogue Data.csv`, then copy the csv file to the `csv` folder which I have prepared in my [Github project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data).

> [!NOTE]
> Unity will not read any user files outside `Assets` folder. Therefore you will never find the `csv` folder in Project view.

## Add Your Own Dialogue

You can add extra dialogue in between the existing dialogues. Just insert a new row in between the 2 dialogues. Copy all the data except the data in `dialogue` parameter from the above or below the row. Then add your own dialogue under the `dialogue` parameter column.

If you want to modify the existing dialogue or change the dialogue language, just change the data under `dialogue` parameter column.

You can remove any row if you do not want that dialogue.

Make sure there is no blank row between 2 rows of data.

## Create Data File from CSV File

You need to convert the csv file to data file. To do that, go to Unity menu bar at the top of the program. Navigate to `Data Generator -> Data -> Dialogue`, then click that option.

![Generate Dialogue Data File](/Screenshot/Generate%20Dialogue%20Data%20File.png)

2 files will be generated in `Assets/StreamingAssets/Data/Asset/` folder. You can refer the message in the Unity Console view.

![Dialogue Data File](/Screenshot/Dialogue%20Data%20File.png)

> [!NOTE]
> In case if you don't see the newly generated files, you can minimize the Unity program, then maximize it.

First is the json file (.json), readable text format. Open this file in any text editor. You can check if the data is correct. If data is wrong, you can repeat the above steps to generate a new one. The existing files will be replaced. This json file is just a reference, the game will not use it.

The second file is data file (.data), in binary format. This is the file you need to put inside the mod folder.

> [!NOTE]
> Ignore the meta file (.meta). These files are only used by Unity.

> [!NOTE]
> Although Unity can read text file like csv at runtime, parsing all the string values to other data values such as integer and float take time. This will increase the loading time when you launch the game. Furthermore, there are tons of data need to be parsed if you put more data in the file, which can increase the loading time to few minutes. But in binary format file, no parsing need to be done.

## Mod Data Folder Structure

In your game device, create a new folder and rename it to `Data` in the folder of any name you put. In the `Data` folder, add another folder and rename it to `Asset`. The folder path should look something like this `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Data/Asset/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Data/Asset/`. Copy the data file to the `Asset` folder.

After you do all the steps above, you can launch the game.

## Changing Dialogue Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| Intro ID | string (text) | INT001 | The unique ID for a dialogue. No need to change unless you know what you are doing. |
| Segment | int (number) | INT001 | The segment in this dialogue. Do not change this value. |
| Character ID | string (text) | CHA001 | The character who is talking in this dialogue. If you put a your own character ID, make sure you prepare a character sprite and rename it according, then put it into image mod folder. Refer to manual [here](/MANUAL/Changing%20Asset%20Image.md). |
| Character Position | vector2 (number, x and y) | -300,250 | The anchor position of the character image. Refer to manual below. |
| Dialogue Position | vector2 (number, x and y) | 300,-250 | The anchor position of the dialogue image. Refer to manual below. |
| Dialogue | string (text) | This is a dialogue. | The conversation talked by this character. |

## Changing Character and Dialogue Position

In my Unity project, go to Project view and search for `Assets/Prefab/UI/` folder. Search for `PAN23_Dialogue Panel` prefab, then double click the prefab file to open it.

![Dialogue Panel Prefab](/Screenshot/Dialogue%20Panel%20Template.png)

Refer to image above, The 2 game objects you need to look for are `<character_icon>`, highlight in red colour, and `dialogue_background_id ASV`, highlight in blue colour, Then go to inspector view and look for `Pos X` and `Pos Y` under `Rect Transform` component, highlight in purple colour.

After you satisfy the position of `<character_icon>` and `dialogue_background_id ASV` game objects, then you need to copy the value in `Pos X` and `Pos Y` to `Character Position` and `Dialogue Position` parameter column respectively. Use comma `,` to seperate the value of `Pos X` and `Pos Y`. Whitespace ` ` is not allow.

For example, if the position of `<character_icon>` is -320 for `Pos X` and -410 for `Pos Y`, then you need to put `-320,-410` in `Character Position` parameter column.

