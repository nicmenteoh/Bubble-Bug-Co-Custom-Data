using System.Collections.Generic;
using ZeroFormatter;

namespace ProjectPestHuntData
{
	[ZeroFormattable]
	public class GlobalConfig
	{
		[Index (0)] public virtual int next_hunt_interval { get; set; }
		[Index (1)] public virtual int royal_bug_chance { get; set; }
		[Index (2)] public virtual float royal_bug_size_multiplier { get; set; }
		[Index (3)] public virtual float royal_bug_coin_multiplier { get; set; }
		[Index (4)] public virtual int royal_bug_addition_reward { get; set; }
		[Index (5)] public virtual int max_material_capacity { get; set; }
		[Index (6)] public virtual IList<int> fairy_rarity_experience_per_level { get; set; }
		[Index (7)] public virtual IList<int> fairy_rarity_max_level { get; set; }
		[Index (8)] public virtual int fairy_experience_per_bug_catch { get; set; }
		[Index (9)] public virtual int amount_of_fairy_awaken_item_exchange_to_fairy_awaken_core { get; set; }
		[Index (10)] public virtual int fairy_appear_in_1_over_poll { get; set; }
		[Index (11)] public virtual byte start_cage_amount { get; set; }
		[Index (12)] public virtual int max_cage_amount_per_slot { get; set; }
		[Index (13)] public virtual IList<MaterialData.CraftMaterial> cage_crafting_materials { get; set; }
		[Index (14)] public virtual IList<int> cage_unlock_cost { get; set; }
		[Index (15)] public virtual IList<int> rage_experience_cap { get; set; }
		[Index (16)] public virtual IList<int> rage_experience_gain { get; set; }
		[Index (17)] public virtual string rage_up_message_id { get; set; }
		[Index (18)] public virtual string rage_down_message_id { get; set; }
		[Index (19)] public virtual string inverse_rage_up_message_id { get; set; }
		[Index (20)] public virtual string inverse_rage_down_message_id { get; set; }
		[Index (21)] public virtual float catch_failed_rage_drop_multiplier { get; set; }
		[Index (22)] public virtual float catch_death_coin_reduce_multiplier { get; set; }
		[Index (23)] public virtual float catch_death_extra_reputation_earn_multiplier { get; set; }
		[Index (24)] public virtual int max_reward_per_catch { get; set; }
		[Index (25)] public virtual float fade_transition_timer { get; set; }
		[Index (26)] public virtual float fade_transition_move_offset { get; set; }
		[Index (27)] public virtual float catch_status_transition_timer { get; set; }
		[Index (28)] public virtual float profile_update_transition_timer { get; set; }
		[Index (29)] public virtual int trap_history_count { get; set; }
		[Index (30)] public virtual int gallery_fairy_caught_unit_display_per_page { get; set; }
		[Index (31)] public virtual int dialogue_text_display_speed { get; set; }
		[Index (32)] public virtual int food_stall_stock_refresh_after_hunt { get; set; }
		[Index (33)] public virtual int food_stall_sales_chance { get; set; }
		[Index (34)] public virtual int food_stall_next_event_after_hunt { get; set; }
		[Index (35)] public virtual int food_stall_min_discount_percentage { get; set; }
		[Index (36)] public virtual int food_stall_max_discount_percentage { get; set; }
		[Index (37)] public virtual int food_stall_free_food_percentage { get; set; }
		[Index (38)] public virtual int food_stall_min_free_food_percentage { get; set; }
		[Index (39)] public virtual int food_stall_max_free_food_percentage { get; set; }
		[Index (40)] public virtual int warehouse_full_claim_interval { get; set; }
		[Index (41)] public virtual int warehouse_next_claim_interval { get; set; }
		[Index (42)] public virtual int warehouse_free_claim_max_type { get; set; }
		[Index (43)] public virtual int warehouse_free_claim_min_fairy_food_quantity { get; set; }
		[Index (44)] public virtual int warehouse_free_claim_max_fairy_food_quantity { get; set; }
		[Index (45)] public virtual int warehouse_free_claim_fairy_food_percentage { get; set; }
		[Index (46)] public virtual int warehouse_free_claim_min_ammo_quantity { get; set; }
		[Index (47)] public virtual int warehouse_free_claim_max_ammo_quantity { get; set; }
		[Index (48)] public virtual int warehouse_free_claim_ammo_percentage { get; set; }
		[Index (49)] public virtual int warehouse_free_claim_min_bait_quantity { get; set; }
		[Index (50)] public virtual int warehouse_free_claim_max_bait_quantity { get; set; }
		[Index (51)] public virtual int warehouse_free_claim_bait_percentage { get; set; }
		[Index (52)] public virtual int warehouse_free_claim_min_flavour_quantity { get; set; }
		[Index (53)] public virtual int warehouse_free_claim_max_flavour_quantity { get; set; }
		[Index (54)] public virtual int warehouse_free_claim_flavour_percentage { get; set; }
		[Index (55)] public virtual int warehouse_free_claim_min_material_quantity { get; set; }
		[Index (56)] public virtual int warehouse_free_claim_max_material_quantity { get; set; }
		[Index (57)] public virtual int warehouse_free_claim_material_percentage { get; set; }
		[Index (58)] public virtual int ammo_dealer_next_event_after_hunt { get; set; }
		[Index (59)] public virtual int ammo_dealer_free_ammo_percentage { get; set; }
		[Index (60)] public virtual int ammo_dealer_min_free_ammo_percentage { get; set; }
		[Index (61)] public virtual int ammo_dealer_max_free_ammo_percentage { get; set; }
		[Index (62)] public virtual int fairy_bakery_first_meet_free_quantity { get; set; }
		[Index (63)] public virtual int fairy_bakery_low_food_amount { get; set; }
		[Index (64)] public virtual int fairy_bakery_low_food_free_quantity { get; set; }
		[Index (65)] public virtual int fairy_bakery_sales_chance_every_hunt { get; set; }
		[Index (66)] public virtual int fairy_bakery_min_discount_percentage { get; set; }
		[Index (67)] public virtual int fairy_bakery_max_discount_percentage { get; set; }
		[Index (68)] public virtual float camp_hunt_available_highlight_interval { get; set; }
		[Index (69)] public virtual float dialogue_sfx_play_next_interval { get; set; }
		[Index (70)] public virtual float credit_display_speed { get; set; }
		[Index (71)] public virtual IList<string> new_game_intro { get; set; }
		[Index (72)] public virtual IList<string> starting_trap { get; set; }
		[Index (73)] public virtual string starting_location { get; set; }
		[Index (74)] public virtual IList<string> tutorial_trap_and_catch { get; set; }
		[Index (75)] public virtual string tutorial_location { get; set; }
	}
}


