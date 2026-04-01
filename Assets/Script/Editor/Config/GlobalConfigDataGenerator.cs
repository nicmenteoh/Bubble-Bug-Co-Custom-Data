using Newtonsoft.Json;
using ProjectPestHuntData;
using System.IO;
using UnityEditor;
using UnityEngine;
using ZeroFormatter;

public class GlobalConfigDataGenerator
{

    [MenuItem ("Data Generator/Config/Generate Data (.data)")]
    static void GenerateJsonFromData ()
    {
        GlobalConfig config = new GlobalConfig
        {
            next_hunt_interval = 360,
            max_material_capacity = 999999999,
            royal_bug_chance = 1,
            royal_bug_size_multiplier = 2f,
            royal_bug_coin_multiplier = 5f,
            royal_bug_addition_reward = 5,
            fairy_rarity_experience_per_level = new int[] { 50, 60, 70, 85, 100 },
            fairy_rarity_max_level = new int[] { 100, 100, 100, 100, 100 },
            fairy_experience_per_bug_catch = 1,
            amount_of_fairy_awaken_item_exchange_to_fairy_awaken_core = 3,
            fairy_appear_in_1_over_poll = 1111,
            start_cage_amount = 5,
            max_cage_amount_per_slot = 100,
            cage_crafting_materials = new MaterialData.CraftMaterial[0],
            cage_unlock_cost = new int[] { 1000, 2500, 5000, 8000, 15000, 40000, 100000, 250000, 500000, 1000000, 1000000 },
            rage_experience_cap = new int[] { 100, 200, 300, 400, 500 },
            rage_experience_gain = new int[] { 10, 20, 30, 40, 50 },
            rage_up_message_id = "HRM1",
            rage_down_message_id = "HRM2",
            inverse_rage_up_message_id = "HRM8",
            inverse_rage_down_message_id = "HRM7",
            catch_failed_rage_drop_multiplier = 2f,
            catch_death_coin_reduce_multiplier = 2f,
            catch_death_extra_reputation_earn_multiplier = 0.5f,
            max_reward_per_catch = 6,
            fade_transition_timer = 0.3f,
            fade_transition_move_offset = 288f,
            catch_status_transition_timer = 0.6f,
            profile_update_transition_timer = 1f,
            trap_history_count = 100,
            gallery_fairy_caught_unit_display_per_page = 10,
            dialogue_text_display_speed = 15,
            food_stall_stock_refresh_after_hunt = 70,
            food_stall_sales_chance = 33,
            food_stall_next_event_after_hunt = 50,
            food_stall_min_discount_percentage = 10,
            food_stall_max_discount_percentage = 75,
            food_stall_free_food_percentage = 33,
            food_stall_min_free_food_percentage = 10,
            food_stall_max_free_food_percentage = 50,
            warehouse_full_claim_interval = 1440,
            warehouse_next_claim_interval = 360,
            warehouse_free_claim_max_type = 5,
            warehouse_free_claim_fairy_food_percentage = 45,
            warehouse_free_claim_min_fairy_food_quantity = 40,
            warehouse_free_claim_max_fairy_food_quantity = 60,
            warehouse_free_claim_bait_percentage = 80,
            warehouse_free_claim_min_bait_quantity = 40,
            warehouse_free_claim_max_bait_quantity = 60,
            warehouse_free_claim_flavour_percentage = 70,
            warehouse_free_claim_min_flavour_quantity = 40,
            warehouse_free_claim_max_flavour_quantity = 60,
            warehouse_free_claim_ammo_percentage = 20,
            warehouse_free_claim_min_ammo_quantity = 15,
            warehouse_free_claim_max_ammo_quantity = 25,
            warehouse_free_claim_material_percentage = 35,
            warehouse_free_claim_min_material_quantity = 5,
            warehouse_free_claim_max_material_quantity = 15,
            ammo_dealer_next_event_after_hunt = 250,
            ammo_dealer_free_ammo_percentage = 75,
            ammo_dealer_min_free_ammo_percentage = 10,
            ammo_dealer_max_free_ammo_percentage = 25,
            fairy_bakery_first_meet_free_quantity = 15,
            fairy_bakery_low_food_amount = 5,
            fairy_bakery_low_food_free_quantity = 5,
            fairy_bakery_sales_chance_every_hunt = 50,
            fairy_bakery_min_discount_percentage = 1,
            fairy_bakery_max_discount_percentage = 80,
            camp_hunt_available_highlight_interval = 1f,
            dialogue_sfx_play_next_interval = 0.05f,
            credit_display_speed = 150f,
            new_game_intro = new string[] { "INT1", "INT2", "INT3", "INT4", "INT5", "INT6", "INT7", "INT8", "INT9" },
            starting_trap = new string[] { "FAI3", "100", "", "0", "WEA1", "WEA2", "AMM1", "1", "AMM2", "1", "BAI10", "100", "", "0", "ACC2", "", "", },
            starting_location = "LOC1",
            tutorial_trap_and_catch = new string[] { "FAI1", "567", "CRY1", "44", "WEA4", "AMM9", "4", "BAI4", "237", "FLA1", "102", "ACC1", "", "ACC1", "UNI1", "UNI2", "UNI3", "UNI4" },
            tutorial_location = "LOC11"
        };

        string dataPath = $"{Application.streamingAssetsPath}/Data/Config";
        if (!Directory.Exists (dataPath))
            Directory.CreateDirectory (dataPath);

        ZeroFormatterInitializer.Register ();

        dataPath += $"/{AssetDataFilename.config}";
        File.WriteAllBytes (dataPath, ZeroFormatterSerializer.Serialize (config));
        dataPath = $"{Application.streamingAssetsPath}/Data/Config/Config Data.json";
        File.WriteAllText (dataPath, JsonConvert.SerializeObject (config, Formatting.Indented));

        Debug.Log ($"<color=green>UI panel data file \"{AssetDataFilename.config}\" has generated successful.</color>");
        Debug.Log (dataPath);
    }
}
