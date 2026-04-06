[Before you begin](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data)

## WARNING

If you plan to modify the existing data to the game, please always backup your save first. Some activity data have dependencies from other asset data. If you put the wrong type of data into the game, it may cause your game to crash or not working properly.

## Unity Game Engine Require

You need to [download my Unity project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data) in order to generate the activity data file. Any Unity version will do.

## Create Data File from Script

After you open the project in Unity, go to Project view and search for `Assets/Script/Editor/Activity/` folder. There are a lot of scripts inside the folder. Each location has its own activity. You can compare the default name of the location with the name of the script to find out which script is use for which location. For the `Wood Cabin` location, the script name is `WoodCabinActivityDataGenerator`. You can use any text editor to open the script.

The script is in C# programming language. If you familiar with Object Oriented Programming, the script is easy to understand. I will explain what of the each parameter in each script does to the game at this manual below.

> [!IMPORTANT]
> Do not remove any parameter from the script.

Unity cannot compile and run the newly modified script at runtime. Therefore you need to convert the data in the script to a data file. To do that, go to Unity menu bar at the top of the program. Navigate to `Data Generator -> Activity -> <The activity data you want to generate>`, then click the option.

![Generate Camp Panel Data File](/Screenshot/Generate%20Activity%20Data%20File.png)

2 files will be generated in `Assets/StreamingAssets/Data/Config/` folder. You can refer the message in the Unity Console view.

![Activity Data File](/Screenshot/Activity%20Data%20File.png)

> [!NOTE]
> In case if you don't see the newly generated files, you can minimize the Unity program, then maximize it.

First is the json file (.json), readable text format. Open this file in any text editor. You can check if the data is correct. If data is wrong, you can repeat the above steps to generate a new one. The existing files will be replaced. This json file is just a reference, the game will not use it.

The second file is data file (.data), in binary format. This is the file you need to put inside the mod folder.

> [!NOTE]
> Ignore the meta file (.meta). These files are only used by Unity.

> [!NOTE]
> Although Unity can read text file like json at runtime, parsing all the string values to other data values such as integer and float take time. This will increase the loading time when you launch the game. Furthermore, there are tons of data need to be parsed if you put more data in the file, which can increase the loading time to few minutes. But in binary format file, no parsing need to be done.

## Mod Data Folder Structure

In your game device, create a new folder and rename it to `Data` in the folder of any name you put. In the `Data` folder, add another folder and rename it to `Activity`. The folder path should look something like this `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Data/Activity/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Data/Activity/`. Copy the data file to the `Activity` folder.

After you do all the steps above, you can launch the game.

> [!TIP]
> You are recomended to clear the activity at least once before changing the activity data for better understanding about what the parameters do.

## Changing Common Parameter in Activity Data

To unlock to new location, you need to clear a minimum amount of activity in that location. Therefore all the activity scripts contain `to_new_location` parameter which is a `NewLocation` class.

Parameter inside `NewLocation` class:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| location_id | string (text) | "LOC003" | The location ID to unlock. Make sure the location ID is exist in [location data](/MANUAL/Changing%20Asset%20Data.md#changing-location-data). |
| material_to_unlock_location | string (text) | "MAT022" | The material acquire when unlock this location. |
| min_activity_clear_count_to_unlock | int (number) | 3 | The minimum amount of activity needs to clear to unlock this new location. |

## Changing Wood Cabin Activity Data

Refer to `WoodCabinActivityDataGenerator` script:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| initial_hole_appear_chance | int (number) | 50 | The initial chance to discover a hole when successful catching the unit set in parameter `hole_discover_units`. |
| hole_chance_increase | int (number) | 15 | Add this value to hole discovery chance when successful catching the unit set in parameter `hole_discover_units` but failed to discover a hole. |
| hole_discover_units | array of string (text) | "UNI002", "UNI010" | Successful catching these units will have a chance to discover a hole. Make sure all the unit IDs are exist in [region data](/MANUAL/Changing%20Asset%20Data.md#changing-region-data) `unit` parameter or [location data](/MANUAL/Changing%20Asset%20Data.md#changing-location-data) `unit` parameter. |
| total_hunt_to_fill_hole | int (number) | 100 | Total amount of hunt to completely repair a hole after clear all the units in the hole. The amount can be reduced by adding value in `unit_to_boost_fill_hole` parameter. |
| material_to_lure_unit | string (text) | "MAT011" | The material uses to lure out the units in hole after discover the hole. Make sure the material ID is exist in [material data](/MANUAL/Changing%20Asset%20Data.md#changing-material-data). |
| material_to_repair_hole | string (text) | "MAT012" | The material uses to repair a hole after clearing all the units in the hole. Make sure the material ID is exist in [material data](/MANUAL/Changing%20Asset%20Data.md#changing-material-data). |
| hole_discover_message_id | string (text) | "HRM004" | The message display in hunt summary panel and hunt history panel when discover a hole. Make sure this message ID is exist in [hunt result message language](). |
| next_unit_layer_message_id | string (text) | "HRM004" | The message display in hunt summary panel and hunt history panel when new units in hole appear. Make sure this message ID is exist in [hunt result message language](). |
| layer_unit_clear_message_id | string (text) | "HRM004" | The message display in hunt summary panel and hunt history panel when all the units in the hole have cleared. Make sure this message ID is exist in [hunt result message language](). |
| fully_repair_message_id | string (text) | "HRM004" | The message display in hunt summary panel and hunt history panel when a hole is fully repaired. Make sure this message ID is exist in [hunt result message language](). |
| unit_to_boost_fill_hole | array of `RepairHoleUnit` class | Refer to table below | Successful catching these units can reduce the hunt amount when repair a hole. |
| in_hole_unit_group | array of `LayerUnit` class | Refer to table below | Unit groups in a hole. |
| to_new_location | `NewLocation` class | Refer to [table](#changing-common-parameter-in-activity-data) above | Unlock to new location. Set to `null` if no new location to unlock. |

Parameter inside `LayerUnit` class:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| appear_poll | int (number) | 3 | The higher the value, this group of units will more likely to appear when discover a hole. |
| layer_1_units | `UnitQuantity` class | Refer to table below | The first group of units are available to hunt when discover a hole. |
| layer_2_units | `UnitQuantity` class | Refer to table below | The second group of units are available to hunt after catching a quantity of unit in first group. |
| layer_3_units | `UnitQuantity` class | Refer to table below | The third group of units are available to hunt after catching a quantity of unit in second group. |
| layer_4_units | `UnitQuantity` class | Refer to table below | The fourth group of units are available to hunt after catching a quantity of unit in third group. |
| layer_5_units | `UnitQuantity` class | Refer to table below | The final group of units are available to hunt after catching a quantity of unit in fourth group. |

Parameter inside `UnitQuantity` class:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| units | array of string (text) | "UNI048", "UNI050" | The units in a group, `layer_#_units` in `LayerUnit` class. All units listed here are not common unit therefore no need listed in region data `unit` parameter and location data `unit` parameter. |
| quantity | int (number) | 20 | The quantity of unit in this group need to catch before next group of units are available to hunt. |

Parameter inside `RepairHoleUnit` class:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| unit | string (text) | "UNI005" | Catching this unit to reduce the hunt amount when repair a hole. Make sure the unit IDs are exist in [region data](/MANUAL/Changing%20Asset%20Data.md#changing-region-data) or [location data](/MANUAL/Changing%20Asset%20Data.md#changing-location-data). |
| fill | int (number) | 2 | Hunt amount to reduce when repair a hole. |

## Changing Wood House Activity Data

Refer to `WoodHouseActivityDataGenerator` script:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| initial_party_start_chance | int (number) | 20 | The initial chance to discover a party when successful catching the unit set in parameter `units_to_start_party`. |
| party_chance_increase | int (number) | 25 | Add this value to party discovery chance when successful catching the unit set in parameter `units_to_start_party` but failed to discover a party. |
| units_to_start_party | array of string (text) | "UNI032", "UNI033" | Successful catching these units will have a chance to discover a party. Make sure all the unit IDs are exist in [region data](/MANUAL/Changing%20Asset%20Data.md#changing-region-data) unit parameter or [location data](/MANUAL/Changing%20Asset%20Data.md#changing-location-data) unit parameter. |
| mud_dig_quantity | int (number) | 100 | The total amount of mud in key hole that need to dig. |
| units_to_dig_mud | `UnitMudDig` class | Refer to table below | Successful catching these units will make the units dig the mud in key hole. |
| units_to_drop_key | array of string (text) | "UNI026", "UNI027" | Unit that drop key. Only use to display in wood house activity panel. Make sure all the unit IDs are exist in [region data](/MANUAL/Changing%20Asset%20Data.md#changing-region-data) unit parameter or [location data](/MANUAL/Changing%20Asset%20Data.md#changing-location-data) unit parameter. |
| key_to_unlock_room | string (text) | "MAT021" | Material (Key) to unlock the storage room. Only use to display in wood house activity panel. Make sure the material ID is exist in [material data](/MANUAL/Changing%20Asset%20Data.md#changing-material-data), and also make sure the material ID is exist in [unit data](/MANUAL/Changing%20Asset%20Data.md#changing-unit-data) `reward poll` parameter. |
| key_quantity_to_unlock_room | int (number) | 1 | The quantity of key use to unlock the storage room. |
| start_speed | float (number) | 1000.0 | The party units initial speed after unlock the storage room. |
| final_speed | float (number) | 500.0 | The unit lowest moving speed, making party units more likely to appear and hard to escape if catching failed. |
| material_to_slow_speed | string (text) | "MAT0222" | The material use to slow all the party units moving speed. Make sure the material ID is exist in [material data](/MANUAL/Changing%20Asset%20Data.md#changing-material-data). |
| speed_increase_percentage | int (number) | 5 | When material set in `material_to_slow_speed` parameter is not equipped during hunt, all party units moving speed will increase by this value. |
| speed_decrease_percentage | int (number) | 4 | When material set in `material_to_slow_speed` parameter is equipped during hunt, all party units moving speed will decrease by this value. |
| party_unit_rage_quantity | array of `UnitRageQuantity` class | Refer to table below | Total quantity of each rage of mix unit in party unit group. |
| party_unit_group | array of `UnitSpeed` class | Refer to table below | The units in the party group with a precentage of `start_speed`. |
| to_new_location | `NewLocation` class | Refer to [table](#changing-common-parameter-in-activity-data) above | Unlock to new location. Set to `null` if no new location to unlock. |
| party_start_message_id | string (text) | "HRM009" | The message display in hunt summary panel and hunt history panel when discover a party. Make sure this message ID is exist in [hunt result message language](). |
| mud_clear_message_id | string (text) | "HRM009" | The message display in hunt summary panel and hunt history panel when all the mud inside the key hole is cleared. Make sure this message ID is exist in [hunt result message language](). |
| unit_runaway_message_id | string (text) | "HRM009" | The message display in hunt summary panel and hunt history panel when a party unit has escape due to failed to catch. Make sure this message ID is exist in [hunt result message language](). |
| storage_clear_message_id | string (text) | "HRM009" | The message display in hunt summary panel and hunt history panel when there are no more party units in the storage room. Make sure this message ID is exist in [hunt result message language](). |

Parameter inside `UnitMudDig` class:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| unit | string (text) | "UNI005" | Successful catching this unit wikk make the unit dig the mud in key hole. Make sure the unit IDs are exist in [region data](/MANUAL/Changing%20Asset%20Data.md#changing-region-data) or [location data](/MANUAL/Changing%20Asset%20Data.md#changing-location-data). |
| dig | int (number | 8 | The amount of mud is dig in key hole. |

Parameter inside `UnitRageQuantity` class:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| rage | int (number) | 1 to 5 | The party unit rage. Value only support between 1 to 5. |
| quantity | int (number) | 30 | The quantity of mix party unit in each rage. |

Parameter inside `UnitSpeed` class:
| Parameter | Data Type | Sample | Description |
| --- | --- | --- | --- |
| units | array of string (text) | "UNI048", "UNI050" | The party units with `start_speed` percentage. All units listed here are not common unit therefore no need listed in region data `unit` parameter and location data `unit` parameter. |
| start_speed_percentage | int (number) | 50 | The percentage of `start_speed` in this party unit group. |
