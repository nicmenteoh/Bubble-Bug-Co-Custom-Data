[Before you begin](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data)

## WARNING

If you plan to modify the config data, please always backup your save first. Some config data have dependencies from other asset data. If you put the wrong type of data into the config data, it may cause your game to crash or not working properly.

## Unity Game Engine Require

You need to [download my Unity project](https://github.com/nicmenteoh/Bubble-Bug-Co-Custom-Data) in order to generate the config data file. Any Unity version will do.

## Create Data File from Script

After you open the project in Unity, go to Project view and search for `Assets/Script/Editor/Config/` folder. Then, open the `GlobalConfigDataGenerator` script. You can use any text editor to open the script.

The script is in C# programming language. If you familiar with Object Oriented Programming, the script is easy to understand. I will explain what of the each parameter does to the game at this manual below.

> [!IMPORTANT]
> Do not remove any parameter from the script.

Unity cannot compile and run the newly modified script at runtime. Therefore you need to convert the data in the script to a data file. To do that, go to Unity menu bar at the top of the program. Navigate to `Data Generator -> Config -> Generate Data (.data)`, then click the option.

![Generate Config Data File](/Screenshot/Generate%20Config%20Data%20File.png)

2 files will be generated in `Assets/StreamingAssets/Data/Config/` folder. You can refer the message in the Unity Console view.

![Config Data File](/Screenshot/Config%20Data%20File.png)

> [!NOTE]
> In case if you don't see the newly generated files, you can minimize the Unity program, then maximize it.

First is the json file (.json), readable text format. Open this file in any text editor. You can check if the data is correct. If data is wrong, you can repeat the above steps to generate a new one. The existing files will be replaced. This json file is just a reference, the game will not use it.

The second file is data file (.data), in binary format. This is the file you need to put inside the mod folder.

> [!NOTE]
> Ignore the meta file (.meta). These files are only used by Unity.

> [!NOTE]
> Although Unity can read text file like json at runtime, parsing all the string values to other data values such as integer and float take time. This will increase the loading time when you launch the game. Furthermore, there are tons of data need to be parsed if you put more data in the file, which can increase the loading time to few minutes. But in binary format file, no parsing need to be done.

## Mod Data Folder Structure

In your game device, create a new folder and rename it to `Data` in the folder of any name you put. In the `Data` folder, add another folder and rename it to `Config`. The folder path should look something like this `.../Android/data/com.roberteoh.bubblebugcodemo/files/Mods/YourFolderName/Data/Config/` or `.../Android/data/com.roberteoh.bubblebugco/files/Mods/YourFolderName/Data/Config/`. Copy the data file to the `Config` folder.

After you do all the steps above, you can launch the game.

## Changing Config Data

| Index | Parameter | Data Type | Default Value | Description |
| --- | --- | --- | --- | --- |
| 0 | next_hunt_interval | int (number) | 360 | The waiting time, in second, for 1 energy to increment. If you are impatient, reduce the value. |
| 1 | new_game_intro | array of string (text) | "INT1", "INT2", "INT3", "INT4", "INT5", "INT6", "INT7", "INT8", "INT9" | The tutorial dialogue sequence when you start the game. You can refer to the manual for changing the dialogue data [here](/MANUAL/Changing%20Dialogue%20Data.md). |
| 2 |starting_trap | array of string (text) | "FAI3", "100", "", "0", "WEA1", "WEA2", "AMM1", "1", "AMM2", "1", "BAI10", "100", "", "0", "ACC2", "", "" | The default trap setup when you start the game. You need to follow the value sequence: fairy ID, fairy food quantity, crystal ID, crystal quantity, first weapon, second weapon, ammo for first weapon, first weapon ammo quantity, ammo for second weapon, second weapon ammo quantity, bait ID, bait quantity, flavour ID, flavour quantity, accessory for first slot, accessory for second slot, accessory for third slot. |
| 3 | starting_location | string (text) | "LOC1" | The first location to hunt when you start the game. |
| 4 | tutorial_trap_and_catch | array of string (text) | "FAI1", "567", "CRY1", "44", "WEA4", "AMM9", "4", "BAI4", "237", "FLA1", "102", "ACC1", "", "ACC1", "UNI1", "UNI2", "UNI3", "UNI4" | The tutorial trap setup. You need to follow the value sequence: fairy ID, fairy food quantity, crystal ID, crystal quantity, weapon ID, ammo ID, ammo quantity, bait ID, bait quantity, flavour ID, flavour quantity, accessory for first slot, accessory for second slot, accessory for third slot, unit to hunt 1, unit to hunt 2, unit to hunt 3, unit to hunt 4. |
| 5 | tutorial_location | string (text) | "LOC11" | The tutorial hunt location. |
| 6 | royal_bug_chance | int (number) | 1 | The chance to get a royal bug when hunting. TThe value is limit between 0 to 100. |
| 7 | royal_bug_size_multiplier | float (number) | 2.0 | The size multiplier when catching a royal bug. |
| 8 | royal_bug_coin_multiplier | float (number) | 5.0 | The coin reward multiplier when catching a royal bug. |
| 9 | royal_bug_addition_reward | int (number) | 5 | The guarantee loot drop quantity when catching a royal bug. |
| 10 | max_material_capacity | int (number) | 999999999 | The maximun quantity you can owned for each fairy food, bait, flavour, ammo, crystal and material. |
| 11 | fairy_rarity_experience_per_level | array of int (number) | 50, 60, 70, 85, 100 | The fairy experience need to gain for leveling up in each rarity. The first value is rarity 1 and the last value is rarity 5. It must have 5 numbers. |
| 12 | fairy_rarity_max_level | array of int (number) | 100, 100, 100, 100, 100 | The maximun level each fairy can reach before it can awaken to another fairy in each rarity. The first value is rarity 1 and the last value is rarity 5. It must have 5 numbers. |
| 13 | fairy_experience_per_bug_catch | int (number) | 1 | The amount of experience gain to fairy when successful catch a bug. |
| 14 |amount_of_fairy_awaken_item_ exchange_to_fairy_awaken_core | int (number) | 3 | The total quantity of mix fairy awaken items to exchange for 1 fairy awaken core material. |
| 15 | fairy_appear_in_1_over_poll | int (number) | 1111 | The chance of a fairy appear in each hunt. In this default chance is i over 1111, or 0.0009%. |
| 16 | start_cage_amount | int (number) | 5 | The starting quantity of cages you acquire in each trap slot. |
| 17 | max_cage_amount_per_slot | int (number) | 100 | The maximun quantity of cages you can owned in each trap slot. |
| 18 | cage_crafting_materials | array of string (text) and int (number | | Materials and quantity use to craft a cage. Put the material ID, then add an equal sign `=`, then quantity of the material. Use and sign `&` to separate multiple material quantity. Make sure the material ID is exist in [material data](/MANUAL/Changing%20Asset%20Data.md#changing-material-data). Whitespace ` ` is not allow. |
| 19 | cage_unlock_cost | array of int (number) | 1000, 2500, 5000, 8000, 15000, 40000, 100000, 250000, 500000, 1000000, 1000000 | The cost for purchasing each cage. The first value is the cost of purchasing first cage, The second value is the cost of purchasing second cage, The last value is the extra cost adding to previos cost. In this example, the cost to purchase tenth cage is 1000000. The cost to purchase eleventh cage is the cost of tenth cage 1000000 + 1000000 = 2000000. The cost to purchase twelveth cage is the cost of eleventh cage, 2000000 + 1000000 = 3000000. |
| 20 | rage_experience_cap | array of int (number) | 100, 200, 300, 400, 500 | The accumulate rage amount for each rage level. In this default value, if rage value is 312, which it is fall between 300 to 399, the rage level is 4. If rage value is 200, then the rage level is 3. Make sure this parameter has 5 values. |
| 21 | rage_experience_gain | array of int (number) | 10, 20, 30, 40, 50 | The rage amount gain when catch a bug successfully for each bug rage level. In this default value, you will get 20 rage amount when success catching a rage 2 bug. Make sure this parameter has 5 values. |
| 22 | rage_up_message_id | string (text) | "HRM1" | The message display in hunt summary panel and hunt history panel when rage level is increased. Make sure this message ID is exist in [hunt result message language](/MANUAL/Changing%20Asset%20Language.md). |
| 23 | rage_down_message_id | string (text) | "HRM2" | The message display in hunt summary panel and hunt history panel when rage level is decreased. Make sure this message ID is exist in [hunt result message language](/MANUAL/Changing%20Asset%20Language.md). |
| 24 | inverse_rage_up_message_id | string (text) | "HRM8" | The message display in hunt summary panel and hunt history panel when rage level is increased with inverse rage effect active. Make sure this message ID is exist in [hunt result message language](/MANUAL/Changing%20Asset%20Language.md). |
| 25 | inverse_rage_down_message_id | string (text) | "HRM7" | The message display in hunt summary panel and hunt history panel when rage level is decreased with inverse rage effect or cold rage effect active. Make sure this message ID is exist in [hunt result message language](/MANUAL/Changing%20Asset%20Language.md). |
| 26 | catch_failed_rage_drop_multiplier | float (number) | 2.0 | The rage amount lose when failed to catch a bug. The rage amount drop is depend on `rage_experience_gain` multiply by this value. In this default value, if failed to catch a rage 2 bug, the rage amount lose is 20 * 2.0 = 40. |
| 27 | catch_death_coin_reduce_multiplier | float (number) | 2.0 | When successful catch a bug but it is death, then the coin reward will be divided by this value. |
| 28 | catch_death_extra_reputation_earn_ multiplier | float (number) | 0.5 | When successful catch a bug but it is death, then the reputation reward will be multiplied by this value, then plus reputation reward. |
| 29 | max_reward_per_catch | int (number) | 6 | The maximun loot drop from bug if catch successful. |
| 30 | fade_transition_timer | float (number) | 0.3 | The fade in or fade out transition time, in second, when changing between 2 panels. |
| 31 | fade_transition_move_offset | float (number) | 288.0 | The panel move distance during fade in or fade out transition. |
| 32 | catch_status_transition_timer | float (number) | 0.6 | The fade in or fade out transition time, in second, when changing between 2 bugs display during review what the bug is caught in hunt result panel. |
| 33 | profile_update_transition_timer | float (number) | 1.0 | The value and bar update transition time, in second, in top bar info panel after loading from loading assets scene, after close from hunt result panel and restore from backup save. |
| 34 | trap_history_count | int (number) | 100 | The quantity of bug caught status and hunt result message display in the hunt history panel. |
| 35 | gallery_fairy_caught_unit_display_ per_page | int (number) | 10 | The quantity of bug caught by fairy display in every page in gallery fairy statistic panel. |
| 36 | dialogue_text_display_speed | int (number) | 15 | The quantity of character dispkay in every second in dialogue panels. |
| 37 | food_stall_stock_refresh_after_hunt | int (number) | 70 | The food in food stall will be refreshed after this value of hunt. |
| 38 | food_stall_sales_chance | int (number) | 33 | The chance of the food in food stall will have discount. The value is limit between 0 to 100. |
| 39 | food_stall_next_event_after_hunt | int (number) | 50 | After this value of hunt, the food stall will end the sales or have a chance to start a sales depend on `food_stall_sales_chance`. |
| 40 | food_stall_min_discount_percentage | int (number) | 10 | The minimum discount percentage for food in fodd stall during sales. |
| 41 | food_stall_max_discount_percentage | int (number) | 75 | The maximum discount percentage for food in fodd stall during sales. |
| 42 | food_stall_free_food_percentage | int (number) | 33 | The chance of getting free food after purchasing in food stall when not in sales. The value is limit between 0 to 100. |
| 43 | food_stall_min_free_food_percentage | int (number) | 10 | The minimum percentage of free food get on top of the food purchased in food stall. |
| 44 | food_stall_max_free_food_percentage | int (number) | 50 | The maximum percentage of free food get on top of the food purchased in food stall. |
| 45 | warehouse_full_claim_interval | int (number) | 1440 | The time, in minute, need to wait before full amount of items in warehouse can be claimed. |
| 46 | warehouse_next_claim_interval | int (number) | 360 | The time, in minute, need to wait before the minimum amount, 1, of items in warehouse can be claimed. |
| 47 | warehouse_free_claim_max_type | int (number) | 5 | The maximum amount of mix items can claim at a time in warehouse. |
| 48 | warehouse_free_claim_min_fairy_ food_quantity | int (number) | 40 | The minimum quantity of fairy food can be claimed at a time in warehouse. |
| 49 | warehouse_free_claim_max_fairy_ food_quantity | int (number) | 60 | The maximum quantity of fairy food can be claimed at a time in warehouse. |
| 50 | warehouse_free_claim_fairy_food_ percentage | int (number) | 45 | The chance of fairy food appear in free claim in warehouse. The value is limit between 0 to 100. |
| 51 | warehouse_free_claim_min_ammo_ quantity | int (number) | 15 | The minimum quantity of ammo can be claimed at a time in warehouse. |
| 52 | warehouse_free_claim_max_ammo_ quantity | int (number) | 25 | The maximum quantity of ammo can be claimed at a time in warehouse. |
| 53 | warehouse_free_claim_ammo_ percentage | int (number) | 20 | The chance of ammo appear in free claim in warehouse. The value is limit between 0 to 100. |
| 54 | warehouse_free_claim_min_bait_ quantity | int (number) | 40 | The minimum quantity of bait can be claimed at a time in warehouse. |
| 55 | warehouse_free_claim_max_bait_ quantity | int (number) | 60 | The maximum quantity of bait can be claimed at a time in warehouse. |
| 56 | warehouse_free_claim_bait_percentage | int (number) | 80 | The chance of bait appear in free claim in warehouse. The value is limit between 0 to 100. |
| 57 | warehouse_free_claim_min_flavour_ quantity | int (number) | 40 | The minimum quantity of flavour can be claimed at a time in warehouse. |
| 58 | warehouse_free_claim_max_flavour_ quantity | int (number) | 60 | The maximum quantity of flavour can be claimed at a time in warehouse. |
| 59 | warehouse_free_claim_flavour_ percentage | int (number) | 70 | The chance of flavour appear in free claim in warehouse. The value is limit between 0 to 100. |
| 60 | warehouse_free_claim_min_material_ quantity | int (number) | 5 | The minimum quantity of material can be claimed at a time in warehouse. |
| 61 | warehouse_free_claim_max_material_ quantity | int (number) | 15 | The maximum quantity of material can be claimed at a time in warehouse. |
| 62 | warehouse_free_claim_material_ percentage | int (number) | 35 | The chance of material appear in free claim in warehouse. The value is limit between 0 to 100. |
| 63 | ammo_dealer_next_event_after_hunt | int (number) | 250 | The chance to get free ammo from ammo dealer after this value of hunt. |
| 64 | ammo_dealer_free_ammo_percentage | int (number) | 75 | The chance to get free ammo from ammo dealer after purchase. The value is limit between 0 to 100. |
| 65 | ammo_dealer_min_free_ammo_ percentage | int (number) | 10 | The minimum percentage of free ammo get on top of the ammo purchased from ammo dealer. |
| 66 | ammo_dealer_max_free_ammo_ percentage | int (number) | 25 | The maximum percentage of free ammo get on top of the ammo purchased from ammo dealer. |
| 67 | fairy_bakery_first_meet_free_quantity | int (number) | 15 | Free fairy food quantity get from fairy bakery during first visit. |
| 68 | fairy_bakery_low_food_amount | int (number) | 5 | When quantity of each owned fairy food reach this value or lower, trigger dialogue and get free fairy food. |
| 69 | fairy_bakery_low_food_free_quantity | int (number) | 5 | The quantity of free fairy food get from fairy bakery when each owned fairy food reach low quantity that set in `fairy_bakery_low_food_amount`. |
| 70 | fairy_bakery_sales_chance_every_hunt | int (number) | 50 | The chance of the fairy food in fairy bakery will have discount after every hunt. The value is limit between 0 to 100. |
| 71 | fairy_bakery_min_discount_percentage | int (number) | 1 | The minimum discount percentage for fairy food in fairy bakery during sales. |
| 72 | fairy_bakery_max_discount_percentage | int (number) | 80 | The maximum discount percentage for fairy food in fairy bakery during sales. |
| 73 | camp_hunt_available_highlight_interval | float (number) | 1.0 | The fade in or fade out time, in second, for the blinking highlight when hunt available in camp panel. |
| 74 | dialogue_sfx_play_next_interval | float (number) | 0.05 | The time, in second, between 2 dialogue sound play in dialogue panels. |
| 75 | credit_display_speed | float (number) | 150.0 | The text move speed in credit panel. |
