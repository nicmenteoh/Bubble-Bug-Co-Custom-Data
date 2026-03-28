[Before you begin](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data)

### WARNING

If you plan to modify the existing data or add new data to the game, please always backup your save first. A lot of asset data have dependencies from other asset data. If you put the wrong type of data into the game, or remove the newly added data from the game without clearing all the dependencies, it may cause your game to crash.

### Unity Game Engine Require

You need to [download my Unity project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data) in order to generate the asset data file. Any Unity version will do.

### Asset Data Category

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
  - Material
  - Region
  - Location
  - Elemental
  - Effect
  - Rank (Level)

You need to refer to my raw data file in [Google Sheet](https://docs.google.com/spreadsheets/d/1jLESi-aXZg1jjIzYeyjZEV-_GvLN5VVQ9HN1Fmt_UM4/edit?usp=sharing) for the data you can change. In the Google Sheet, refer to the bottom for different data catrgory.

### Create CSV File (.csv)

Copy all the data from any category in the Google Sheet to any excel program. I'm using LibreOffice Calc. I'll explain what each parameter in column does to the game in this manual below. You can delete the data in the row which you don't want to change. Make sure there is no blank row between 2 rows of data. And also make sure not to delete the parameter name at the first row.

After you have made the change, save the file to csv format (.csv). Use the pipe or vertical symbol `|` to separate the data between column. In LibreOffice Calc, after you save the file as csv, then put `|` symbol in `Field Delimiter` field.

![Save as csv in LibreOffice Calc]()

The example fairy data in csv file should look something like this:

![Fairy Data csv]()

The other category data in csv file are also look similar.

After you create the csv file, you have to rename the file to name listed below:
| Category | csv Filename |
| --- | --- |
| Fairy | Fairy Data.csv |
| Fairy Food | Fairy Food Data.csv |
| Bait | Bait Data.csv |
| Flavour | Flavour Data.csv |
| Weapon | Weapon Data.csv |
| Ammo | Ammo Data.csv |
| Crystal | Crystal Data.csv |
| Accessory | Accessory Data.csv |
| Unit | Unit Data.csv |
| Material | Material Data.csv |
| Region | Region Data.csv |
| Location | Location Data.csv |
| Elemental | Elemental Data.csv |
| Effect | Effect Data.csv |
| Rank | Rank Data.csv |

Then copy the csv file to the `csv` folder which I have prepared in my [Github project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data).

> [!NOTE]
> Unity will not read any user files outside `Assets` folder. Therefore you will never find the `csv` folder in Project view.

### Add Your Own Data

You can add your own data in new row. Make sure the dependency ID is also available in that asset data. For example, you want to add a new fairy in fairy data. Make sure the ID you put in Fairy Food parameter is available in fairy food data.

> [!IMPORTANT]
> Do not use the ID start with the alphabet characters same with mine because it may crash with my ID at future update. It is also not recommended to have a long ID. 6 to 10 characters are suffice.

### Create Data File from CSV File

You need to convert the csv file to data file. To do that, go to Unity menu bar at the top of the program. Navigate to `Data Generator -> Data -> <The category data you want to generate>`, then click the option.

![Generate Asset Data File]()

2 files will be generated in `Assets/StreamingAssets/Data/Asset/` folder. You can refer the message in the Unity Console view.

![Fairy Data File]()

> [!NOTE]
> In case if you don't see the newly generated files, you can minimize the Unity program, then maximize it.

First is the json file (.json), readable text format. Open this file in any text editor. You can check if the data is correct. If data is wrong, you can repeat the above steps to generate a new one. The existing files will be replaced. This json file is just a reference, the game will not use it.

The second file is data file (.data), in binary format. This is the file you need to put inside the mod folder.

> [!NOTE]
> Ignore the meta file (.meta). These files are only used by Unity.

> [!NOTE]
> Although Unity can read text file like csv at runtime, parsing all the string values to other data values such as integer and float take time. This will increase the loading time when you launch the game. Furthermore, there are tons of data need to be parsed if you put more data in the file, which can increase the loading time to few minutes. But in binary format file, no parsing need to be done.

### Mod Data Folder Structure

In your game device, create a new folder and rename it to `Data` in the folder of any name you put. In the `Data` folder, add another folder and rename it to `Asset`. The folder path should look something like this `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Data/Asset/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Data/Asset/`. Copy the data file to the `Asset` folder.

If you have change the ID in portrait, thumbnail and/or silhouette, make sure you also prepare the images and put the new ID in the image filename and put the image file in your game device mod folder. You can follow the instruction [here](MANUAL/Changing Asset Image.md).

After you do all the steps above, you can launch the game.

### Changing Fairy Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | FAI001 | The unique ID for this fairy asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 2 | Represent the [reward category](#reward-category). Do not channge. |
| Rarity | byte (number) | 1 to 5 | The rarity of this fairy, display as stars in the game. Value only support between 1 to 5. |
| Strength | int (number) | 9999 | The base power of this fairy. The bugs will become easy to catch when the value is higher. |
| Strength Per Level| int (number) | 1111 | The power to increase when this fairy is level up. |
| Luck | int (number) | 0 to 100 | The bugs will drop more loots when the value is higher. The value is limit between 0 to 100. |
| Fairy Food | string (text) | FFO001 | The fairy food used by this fairy when hunting. Make sure this ID is exist in [fairy food data](#changing-fairy-food-data). |
| Effect | array of string (text) | EFF001,EFF003 | Use to manipulate the asset parameter such as strength and luck. Use comma `,` to seperate multiple effects. Make sure this ID is exist in [effect data](#changing-effect-data). Whitespace ` ` is not allow. |
| Awaken To | string (text) | FAI011 | When fairy reach max level, it can evolve to another fairy. Make sure this ID is exist in this fairy data. Leave this field empty if this fairy cannot evolve. |
| Duplicate Drop | string (text) | MAT101 | When you found a duplicate fairy, it will turn to a material that use to evolve the fairy. Make sure the material ID is exist in [material data](#changing-material-data). |
| Awaken Material | array of string (text) and int (number) | MAT101=2&MAT31=1 | Materials and quantity use to evolve this fairy. Put the material ID, then add an equal sign `=`, then quantity of this material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in [material data](#changing-material-data). Whitespace ` ` is not allow. |
| Portrait | string (text) | FAI001A | This fairy portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | FAI001C | This fairy thumbnail image ID. You can put your own ID. |
| Silhouette | string (text) | FAI001B | This fairy silhouette image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Fairy Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Fairy` and select it. Put the newly generated `Fairy.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Fairy Food Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | FFO001 | The unique ID for this fairy food asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 3 | Represent the [reward category](#reward-category). Do not channge. |
| Warehouse Free Claim Poll | int (number) | 101 | The higher the value, this fairy food will more likely appear in the free claim in warehouse. This poll value will be added with other assets which has this parameter. |
| Cost | int (number) | 250 | The coin amount use to purchase this fairy food. |
| Quantity | int (number) | 250 | The batch quantity produced by craft materials. |
| Get At | string (text) | SM | The [shop](#shop-type) which this fairy food is available to purchase. Put the character together if this fairy food is available to purchase from multiple shops. Left empty if this fairy food is not available to purchase. |
| Craft Material | array of string (text) and int (number) | MAT101=2&MAT31=1 | Materials and quantity use to craft this fairy food. Put the material ID, then add an equal sign `=`, then quantity of this material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in [material data](#changing-material-data). Whitespace ` ` is not allow. |
| Portrait | string (text) | FFO001A | This fairy portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | FFO001B | This fairy thumbnail image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Fairy Food Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Fairy Food` and select it. Put the newly generated `Fairy_Food.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Bait Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | BAI001 | The unique ID for this bait asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 7 | Represent the [reward category](#reward-category). Do not channge. |
| Sell Chance | int (number) | 0 to 100 | The higher the value, this bait will more likely available to purchase in food stall when refresh after certain amount of hunt set in food_stall_stock_refresh_after_hunt parameter in [config data](). |
| Cost | int (number) | 250 | The coin amount use to purchase this bait. |
| Warehouse Free Claim Poll | int (number) | 101 | The higher the value, this bait will more likely appear in the free claim in warehouse. This poll value will be added with other assets which has this parameter. |
| Quantity | int (number) | 250 | The batch quantity produced by craft materials. |
| Get At | string (text) | SM | The [shop](#shop-type) which this bait is available to purchase. Put the character together if this bait is available to purchase from multiple shops. Left empty if this bait is not available to purchase. |
| Craft Material | array of string (text) and int (number) | MAT101=2&MAT31=1 | Materials and quantity use to craft this bait. Put the material ID, then add an equal sign `=`, then quantity of this material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in [material data](#changing-material-data). Whitespace ` ` is not allow. |
| Unit Family Attractiveness Poll | array of string (text) and int (number) | FAM001=50&FAM002=99 | The higher the poll value, the higher chance the specific type of unit will appear during hunt. Put the Family ID, then add an equal sign `=`, then attractiveness poll. Use and sign `&` to separate multiple family polls. Make sure the Family ID is exist in [unit family language](). Whitespace ` ` is not allow. |
| Portrait | string (text) | BAI001A | This bait portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | BAI001B | This bait thumbnail image ID. You can put your own ID. |

The other parameter in the foloowing column are just for reference.

Save the file as csv (.csv) and rename the file to `Bait Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Bait` and select it. Put the newly generated `Bait.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Flavour Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | FLA001 | The unique ID for this flsvour asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 8 | Represent the [reward category](#reward-category). Do not channge. |
| Cost | - | - | Not in use. |
| Warehouse Free Claim Poll | int (number) | 101 | The higher the value, this flavour will more likely appear in the free claim in warehouse. This poll value will be added with other assets which has this parameter. |
| Quantity | - | - | Not in use. |
| Get At | - | - | Not in use. |
| Craft Material | - | - | Not in use. |
| Portrait | string (text) | FLA001A | This flavour portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | FLA001B | This flavour thumbnail image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Flavour Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Flavour` and select it. Put the newly generated `Flavour.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Weapon Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | WEA101 | The unique ID for this weapon asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 5 | Represent the [reward category](#reward-category). Do not channge. |
| Elemental | string (text) | ELNT | Use to compare with [unit](#changing-unit-data) elemental to gain bonus strength value or lose the value. Refer to [elemental data](#changing-elemental-data) to get the data which the elemental strong and weak against other elemental. And make sure this ID is exist in the elemental data. |
| Strength | int (number) | 5555 | The power of this weapon. The bugs will become easy to catch when the value is higher. |
| Cost | int (number) | 250 | The coin amount use to purchase this weapon. |
| Quantity | int (number) | 250 | The batch quantity produced by craft materials. |
| Rank | int (number) | 1 | This weapon is avaiable to purchase when you reach this rank value. |
| Get At | string (text) | SM | The [shop](#shop-type) which this weapon is available to purchase. Put the character together if this weapon is available to purchase from multiple shops. Left empty if this weapon is not available to purchase. |
| Base Craft Weapon | string (text) | WEA001 | The weapon treats as a material, use to craft this weapon. Make sure this ID is exist in this weapon data. Leave this field empty if no weapon is use. |
| Craft Material | array of string (text) and int (number) | MAT101=2&MAT31=1 | Materials and quantity use to craft this weapon. Put the material ID, then add an equal sign `=`, then quantity of this material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in [material data](#changing-material-data). Whitespace ` ` is not allow. |
| Ammo | array of string (text) | AMM1010,AMM1011 | The ammo used by this weapon. Use comma `,` to seperate multiple ammo. Make sure this ID is exist in [ammo data](#changing-ammo-data). Whitespace ` ` is not allow. |
| Portrait | string (text) | WEA101A | This weapon portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | WEA101C | This weapon thumbnail image ID. You can put your own ID. |
| Silhouette | string (text) | WEA101B | This weapon silhouette image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Weapon Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Weapon` and select it. Put the newly generated `Weapon.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Ammo Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | AMM001 | The unique ID for this ammo asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 6 | Represent the [reward category](#reward-category). Do not channge. |
| Strength (%) | int (number) | 50 | The power bonus, in percentage, gain to the weapon strength. The bugs will become easy to catch when the value is higher. |
| Lethal (%) | int (number) | 0 to 100 | The higher the value, the bugs will more likely die when caught. The value is limit between 0 to 100. |
| Infinite | bool (true/false) | FALSE | If true, this ammo have unlimited quantity and will not appear in ammo dealer shop. |
| Cost | int (number) | 250 | The coin amount use to purchase this ammo. |
| Warehouse Free Claim Poll | int (number) | 101 | The higher the value, this ammo will more likely appear in the free claim in warehouse. This poll value will be added with other assets which has this parameter. |
| Quantity | int (number) | 250 | The batch quantity produced by craft materials. |
| Get At | string (text) | SM | The [shop](#shop-type) which this ammo is available to purchase. Put the character together if this ammo is available to purchase from multiple shops. Left empty if this ammo is not available to purchase. |
| Craft Material | array of string (text) and int (number) | MAT101=2&MAT31=1 | Materials and quantity use to craft this ammo. Put the material ID, then add an equal sign `=`, then quantity of this material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in [material data](#changing-material-data). Whitespace ` ` is not allow. |
| Portrait | string (text) | AMM001A | This ammo portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | AMM001B | This ammo thumbnail image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Ammo Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Ammo` and select it. Put the newly generated `Ammo.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Crystal Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | CRY001 | The unique ID for this crystal asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 4 | Represent the [reward category](#reward-category). Do not channge. |
| Rarity | int (number) | 14 | Use in arrange order in the shop. The higher the value, this crystal will display on the top of the shop. |
| Rank | int (number) | 2 | This crystal is avaiable to purchase when you reach this rank value. |
| Cost | int (number) | 250 | The coin amount use to purchase this crystal. |
| Quantity | int (number) | 250 | The batch quantity produced by craft materials. |
| Get At | string (text) | SM | The [shop](#shop-type) which this crystal is available to purchase. Put the character together if this crystal is available to purchase from multiple shops. Left empty if this crystal is not available to purchase. |
| Craft Material | array of string (text) and int (number) | MAT101=2&MAT31=1 | Materials and quantity use to craft this crystal. Put the material ID, then add an equal sign `=`, then quantity of this material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in [material data](#changing-material-data). Whitespace ` ` is not allow. |
| Effect | array of string (text) | EFF001,EFF003 | Use to manipulate the asset parameter such as strength and luck. Use comma `,` to seperate multiple effects. Make sure this ID is exist in [effect data](#changing-effect-data). Whitespace ` ` is not allow. |
| Portrait | string (text) | CRY001A | This crystal portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | CRY001C | This crystal thumbnail image ID. You can put your own ID. |
| Silhouette | string (text) | CRY001B | This crystal silhouette image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Crystal Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Crystal` and select it. Put the newly generated `Crystal.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Accessory Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | ACC101 | The unique ID for this accessory asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 9 | Represent the [reward category](#reward-category). Do not channge. |
| Rarity | int (number) | 14 | Use in arrange order in the shop. The higher the value, this accessory will display on the top of the shop. |
| Rank | int (number) | 2 | This accessory is avaiable to purchase when you reach this rank value. |
| Cost | int (number) | 250 | The coin amount use to purchase this accessory. |
| Quantity | int (number) | 250 | The batch quantity produced by craft materials. |
| Get At | string (text) | SM | The [shop](#shop-type) which this accessory is available to purchase. Put the character together if this accessory is available to purchase from multiple shops. Left empty if this bait is not available to purchase. |
| Base Craft Accessory | string (text) | ACC001 | The accessory treats as a material, use to craft this accessory. Make sure this ID is exist in this accessory data. Leave this field empty if no accessory is use. |
| Craft Material | array of string (text) and int (number) | MAT101=2&MAT31=1 | Materials and quantity use to craft this accessory. Put the material ID, then add an equal sign `=`, then quantity of this material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in [material data](#changing-material-data). Whitespace ` ` is not allow. |
| Effect | array of string (text) | EFF001,EFF003 | Use to manipulate the asset parameter such as strength and luck. Use comma `,` to seperate multiple effects. Make sure this ID is exist in [effect data](#changing-effect-data). Whitespace ` ` is not allow. |
| Portrait | string (text) | ACC101A | This accessory portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | ACC101C | This accessory thumbnail image ID. You can put your own ID. |
| Silhouette | string (text) | ACC101B | This accessory silhouette image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Accessory Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Accessory` and select it. Put the newly generated `Accessory.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Unit Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | UNI001 | The unique ID for this unit asset. |
| Name | - | - | For reference only. Not use in the game. |
| Family | string (text) | FAM001 | The unit type. Attract to certain [bait](#changing-bait-data). |
| Elemental | string (text) | ELFI | Use to compare with [weapon](#changing-weapon-data) elemental to gain bonus strength value or lose the value. Refer to [elemental data](#changing-elemental-data) to get the data which the elemental strong and weak against to other elemental. And make sure this ID is exist in the elemental data. |
| Strength | int (number) | 5555 | The power of this unit. This unit will become hard to catch when the value is higher. |
| Rage | int (number) | 1 to 5 | This unit is avaiable to catch when reach this rage value. The value is limit between 1 to 5. |
| Size | int (number) | 67 | The size of this unit. For display only. |
| Coin | int (number) | 1122 | The coin reward when this unit is caaught success. |
| Reputation | int (number) | 3344 | The reputation reward when this unit is caaught success. Use for rank level up. |
| Flavour Poll | array of string (text) and int (number) | FLA6=100&FLA7=25 | Use to attract specific unit if flavour is equipped. The higher the poll value, the more likely this unit will appear when you hunt. Put the flavour ID, then add an equal sign `=`, then poll value of this flavour. Use and sign `&` to separate multiple flavour poll. Make sure the flavour ID is exist in [flavour data](#changing-material-data). Whitespace ` ` is not allow. |
| Reward Poll | array of string (text) and int (number) | MAT101=2&MAT31=1 | The loot drop when this unit is caught successful. This poll value will be added with other assets which has this parameter. Put the asset ID, then add an equal sign `=`, then poll value of this asset. Use and sign `&` to separate multiple loot drop poll. Make sure the asset ID is exist in the [fairy food](#changing-fairy-food-data), [bait](#changing-bait-data), [flavour](#changing-flavour-data), [ammo](#changing-ammo-data), [crystal](#changing-crystal-data) and [material](#changing-material-data) data. Whitespace ` ` is not allow. |
| Portrait | string (text) | UNI001A | This unit portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | UNI001C | This unit thumbnail image ID. You can put your own ID. |
| Silhouette | string (text) | UNI001B | This unit silhouette image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Unit Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Unit` and select it. Put the newly generated `Unit.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Unit Family Data

There is no parameter for unit family, but it is use in [bait data](#changing-bait-data) and [unit data](#changing-unit-data). Make sure the new unit family ID you put in unit data exist in bait data. Else the unit will never appear. You can add new unit family by adding new image into your game device [mod folder](MANUAL/Changing Asset Image.md).

### Changing Material Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | UNI001 | The unique ID for this material asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 0 | Represent the [reward category](#reward-category). Only value 0, 1, 11, 12, 13, 14 are supported. |
| Cost | int (number) | 10 | The coin amount use to purchase this material. |
| Warehouse Free Claim Poll | int (number) | 101 | The higher the value, this material will more likely appear in the free claim in warehouse. This poll value will be added with other assets which has this parameter. |
| Quantity | int (number) | 5 | The batch quantity produced by craft materials. |
| Get At | string (text) | ML | The [shop](#shop-type) which this bait is available to purchase. Put the character together if this material is available to purchase from multiple shops. Left empty if this material is not available to purchase. |
| Craft Material | array of string (text) and int (number) | MAT101=2&MAT31=1 | Materials and quantity use to craft this material. Put the material ID, then add an equal sign `=`, then quantity of this material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in this material data. Whitespace ` ` is not allow. |

Save the file as csv (.csv) and rename the file to `Material Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Material` and select it. Put the newly generated `Material.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

> [!IMPORTANT]
> Do not change the first 2 material, `MAT1` and `MAT2` unless you know what you are doing.

### Changing Region Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | UNI001 | The unique ID for this region asset. |
| Name | - | - | For reference only. Not use in the game. |
| Location | array of string (text) | LOC001,LOC002 | The location under this region. Use comma `,` to seperate multiple locations. Make sure this ID is exist in [location data](#changing-location-data). Whitespace ` ` is not allow. |
| Fairy Appear ID | string (text) | FAI101 | The fairy which will appear as special reward during your hunt in this region. Make sure this ID is exist in [fairy data](#changing-fairy-data). |
| Unit | array of string (text) | UNI001,UNI002 | The unit appear to hunt in this region. This unit will be combine with unit in location data and activity data. Use comma `,` to seperate multiple units. Make sure this ID is exist in [unit data](#changing-unit-data). Whitespace ` ` is not allow. |
| Reward Poll | array of string (text) and int (number) | MAT101=2&MAT31=1 | The loot drop when unit in this region caught successful. This poll value will be added with other assets which has this parameter. Put the asset ID, then add an equal sign `=`, then poll value of this asset. Use and sign `&` to separate multiple loot drop poll. Make sure the asset ID is exist in the [fairy food](#changing-fairy-food-data), [bait](#changing-bait-data), [flavour](#changing-flavour-data), [ammo](#changing-ammo-data), [crystal](#changing-crystal-data) and [material](#changing-material-data) data. Whitespace ` ` is not allow. |

Save the file as csv (.csv) and rename the file to `Region Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Region` and select it. Put the newly generated `Region.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

> [!TIP]
> In the game, you can find the information about which locations are under which region in the `Menu -> Gallery -> Bug`. 

### Changing Location Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | UNI001 | The unique ID for this location asset. |
| Name | - | - | For reference only. Not use in the game. |
| Unit | array of string (text) | UNI001,UNI002 | The unit appear to hunt in this location. This unit will be combine with unit in region data and activity data. Use comma `,` to seperate multiple units. Make sure this ID is exist in [unit data](#changing-unit-data). Whitespace ` ` is not allow. |
| Reward Poll | array of string (text) and int (number) | MAT101=2&MAT31=1 | The loot drop when unit in this location caught successful. This poll value will be added with other assets which has this parameter. Put the asset ID, then add an equal sign `=`, then poll value of this asset. Use and sign `&` to separate multiple loot drop poll. Make sure the asset ID is exist in the [fairy food](#changing-fairy-food-data), [bait](#changing-bait-data), [flavour](#changing-flavour-data), [ammo](#changing-ammo-data), [crystal](#changing-crystal-data) and [material](#changing-material-data) data. Whitespace ` ` is not allow. |
| Activity | string (text) | ACT001 | The activity held in this location. Refer to [activity data](). |
| Intro | string (text) | INT001 | The dialogue happen when you move to this location at the first time. Make sure the dialogue ID is exist in [dialogue data](). |
| Portrait | string (text) | UNI001A | This location portrait image ID. You can put your own ID. |
| Thumbnail | string (text) | UNI001C | This location thumbnail image ID. You can put your own ID. |

Save the file as csv (.csv) and rename the file to `Location Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Location` and select it. Put the newly generated `Location.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Elemental Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | ELLI | The unique ID for this elemental asset. |
| Name | - | - | For reference only. Not use in the game. |
| Against | array of string (text) and int (number) | ELFI=50&ELWT=150 | This element against to other elements. For example, you put 200 to fire element. When you equip weapon with this elemnt and encounter a fire element unit, your fairy and weaponn strength combine will be double. |

The default data can be represented in this chart:
![Elemental Chart](#Screenshot/Elemental Chart.png)

Save the file as csv (.csv) and rename the file to `Elemental Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Elemental` and select it. Put the newly generated `Elemental.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Effect Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | ELLI | The unique ID for this effect asset. |
| Name | - | - | For reference only. Not use in the game. |
| Type | int (number) | 0 | Different type has different functionality. Make sure the number is exist in [effect type](#effect-type). |
| Parameter | array of int (number) | 100,0 | The value use to manipulate the equipment stats. Refer to [effect type](#effect-type) below for quantity of value you need to put for different type of effect. Use comma `,` to seperate multiple values. Whitespace ` ` is not allow. |

The other parameter in the foloowing column are just for reference.

Save the file as csv (.csv) and rename the file to `Effect Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Effect` and select it. Put the newly generated `Effect.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Changing Rank Data

| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| ID | string (text) | RAN001 | The unique ID for this rank asset. |
| Level | int (number) | 1 | The rank level. |
| Name | - | - | For reference only. Not use in the game. |
| Rank Up Experience | int (number) | 99999 | The reputation quantity to reach next rank. |
| Accumulate Experience | int (number) | 9999999 | The total reputation gather before jump to next rank. |

Save the file as csv (.csv) and rename the file to `Rank Data`. Move the csv file to csv folder. Then go to Unity menu bar and navigate to `Data Generator -> Data -> Rank` and select it. Put the newly generated `Rank.data` in `Assets/StreamingAssets/Data/Asset/` folder to your game device [mod folder](#mod-data-folder-structure).

### Reward Category
| Type | Name |
| --- | --- |
| 0 | General material |
| 1 | Currency |
| 2 | Fairy |
| 3 | Fairy Food |
| 4 | Crystal |
| 5 | Weapon |
| 6 | Ammo |
| 7 | Bait |
| 8 | Flavour |
| 9 | Accessory |
| 10 | Location |
| 11 | Key Item |
| 12 | Fairy Awaken Item |
| 13 | Resources |
| 14 | Activity Item |

### Shop Type
| Type | Shop |
| --- | --- |
| L | Sell at Craftsman but item only available when location has unlocked |
| M | Sell at Black Market |
| S | Fairy Food sells at Fairy Bakery, Bait sells at Food Stall, Weapon sells at Smith, Ammo sells at Ammo Dealer, Crystal sells at Crystal Lab, Accessory sells at Accessory Maker, Material sells at Craftsman |

### Effect Type
| Type | Name | Parameter Quantity | Description |
| --- | --- | --- | --- |
| 1 | Strength Value | 1 | Add or deduct a fixed number to total strength. |
| 2 | Strength Multiplier | 1 | Add or deduct a percentage number to total strength. |
| 3 | Luck Value | 1 | Add or deduct a fixed number to total luck. Luck value is in between 0 to 100. |
| 4 | Lethal Value | 1 | Add or deduct a fixed number to total lethal. Lethal value is in between 0 to 100. |
| 5 | Strength Multiplier and Lethal Value | 2 | Combination of type 2 and 4. |
| 6 | Reward Plus with Luck Penalty | 1 | Guarantee a fixed number of loot drop but luck become 0. |
| 7 | Royal Value | 1 | Add or deduct a fixed number to chance for encoubtering a royal unit. |
| 8 | Catch Effective Value | 1 | Add or deduct a fixed number to unit catch effectiveness. |
| 9 | Luck Value and Attractiveness Value | 2 | Combination of type 3 and 13. |
| 10 | Inverse Rage | 0 | Success catching a bug will decrease rage. Failed to catch a bug will increase rage. |
| 11 | Cold Rage | 0 | Success catching a bug will decrease rage. Failed to catch a bug will do nothing to rage. |
| 12 | Reward Plus Even Catch Failed | 1 | Guarantee a fixed number of loot drop even the bug is failed to catch. |
| 13 | Attractiveness Value | 1 | Add or deduct a fixed number to bait attractiveness. Attractiveness value is in between 0 to 100. |


