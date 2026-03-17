using System;
using UnityEngine;
using ZeroFormatter;

namespace ProjectPestHuntData
{
    #region PAN2 - Top Bar Info Panel Data
    [ZeroFormattable]
    public class TopBarInfoPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
            [Index (1)] public virtual string reputation_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string foreground_id { get; set; }
            [Index (2)] public virtual string rank_bar_background_id { get; set; }
            [Index (3)] public virtual string rank_bar_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string rank { get; set; }
            [Index (1)] public virtual string coin { get; set; }
            [Index (2)] public virtual string reputation { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual UiSprite ui_sprite { get; set; }
        [Index (3)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN3 - Bottom Menu Panel Data
    [ZeroFormattable]
    public class BottomMenuPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string menu_button_background_id { get; set; }
            [Index (1)] public virtual string menu_icon_id { get; set; }
            [Index (2)] public virtual string camp_display_background_id { get; set; }
            [Index (3)] public virtual string camp_icon_id { get; set; }
            [Index (4)] public virtual string warehouse_background_id { get; set; }
            [Index (5)] public virtual string warehouse_icon_id { get; set; }
            [Index (6)] public virtual string food_stall_background_id { get; set; }
            [Index (7)] public virtual string food_stall_icon_id { get; set; }
            [Index (8)] public virtual string smith_background_id { get; set; }
            [Index (9)] public virtual string smith_icon_id { get; set; }
            [Index (10)] public virtual string ammo_dealer_background_id { get; set; }
            [Index (11)] public virtual string ammo_dealer_icon_id { get; set; }
            [Index (12)] public virtual string fairy_bakery_background_id { get; set; }
            [Index (13)] public virtual string fairy_bakery_icon_id { get; set; }
            [Index (14)] public virtual string crystal_lab_background_id { get; set; }
            [Index (15)] public virtual string crystal_lab_icon_id { get; set; }
            [Index (16)] public virtual string accessory_maker_background_id { get; set; }
            [Index (17)] public virtual string accessory_maker_icon_id { get; set; }
            [Index (18)] public virtual string craftsman_background_id { get; set; }
            [Index (19)] public virtual string craftsman_icon_id { get; set; }
            [Index (20)] public virtual string cage_master_background_id { get; set; }
            [Index (21)] public virtual string cage_master_icon_id { get; set; }
            [Index (22)] public virtual string inventory_background_id { get; set; }
            [Index (23)] public virtual string inventory_icon_id { get; set; }
            [Index (24)] public virtual string gallery_background_id { get; set; }
            [Index (25)] public virtual string gallery_icon_id { get; set; }
            [Index (26)] public virtual string statistic_background_id { get; set; }
            [Index (27)] public virtual string statistic_icon_id { get; set; }
            [Index (28)] public virtual string setting_background_id { get; set; }
            [Index (29)] public virtual string setting_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string menu_button { get; set; }
            [Index (1)] public virtual string camp { get; set; }
            [Index (2)] public virtual string warehouse { get; set; }
            [Index (3)] public virtual string food_stall { get; set; }
            [Index (4)] public virtual string smith { get; set; }
            [Index (5)] public virtual string ammo_dealer { get; set; }
            [Index (6)] public virtual string fairy_bakery { get; set; }
            [Index (7)] public virtual string crystal_lab { get; set; }
            [Index (8)] public virtual string accessory_maker { get; set; }
            [Index (9)] public virtual string craftsman { get; set; }
            [Index (10)] public virtual string cage_master { get; set; }
            [Index (11)] public virtual string inventory { get; set; }
            [Index (12)] public virtual string gallery { get; set; }
            [Index (13)] public virtual string statistic { get; set; }
            [Index (14)] public virtual string setting { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN4 - Camp Panel Data
    [ZeroFormattable]
    public class CampPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string activity_button_background_id { get; set; }
            [Index (2)] public virtual string activity_icon_id { get; set; }
            [Index (3)] public virtual string change_location_button_background_id { get; set; }
            [Index (4)] public virtual string change_location_icon_id { get; set; }
            [Index (5)] public virtual string hunt_button_background_id { get; set; }
            [Index (6)] public virtual string hunt_icon_id { get; set; }
            [Index (7)] public virtual string effectiveness_button_background_id { get; set; }
            [Index (8)] public virtual string effectiveness_icon_id { get; set; }
            [Index (9)] public virtual string history_button_background_id { get; set; }
            [Index (10)] public virtual string history_icon_id { get; set; }
            [Index (11)] public virtual string slot_1_background_id { get; set; }
            [Index (12)] public virtual string slot_1_notification_id { get; set; }
            [Index (13)] public virtual string slot_2_background_id { get; set; }
            [Index (14)] public virtual string slot_2_notification_id { get; set; }
            [Index (15)] public virtual string slot_3_background_id { get; set; }
            [Index (16)] public virtual string slot_3_notification_id { get; set; }
            [Index (17)] public virtual string slot_4_background_id { get; set; }
            [Index (18)] public virtual string slot_4_notification_id { get; set; }
            [Index (19)] public virtual string slot_5_background_id { get; set; }
            [Index (20)] public virtual string slot_5_notification_id { get; set; }
            [Index (21)] public virtual string slot_6_background_id { get; set; }
            [Index (22)] public virtual string slot_6_notification_id { get; set; }
            [Index (23)] public virtual string lethal_icon_id { get; set; }
            [Index (24)] public virtual string extra_lethal_icon_id { get; set; }
            [Index (25)] public virtual string fairy_button_background_id { get; set; }
            [Index (26)] public virtual string fairy_food_button_background_id { get; set; }
            [Index (27)] public virtual string crystal_button_background_id { get; set; }
            [Index (28)] public virtual string bait_button_background_id { get; set; }
            [Index (29)] public virtual string flavour_button_background_id { get; set; }
            [Index (30)] public virtual string weapon_button_background_id { get; set; }
            [Index (31)] public virtual string ammo_button_background_id { get; set; }
            [Index (32)] public virtual string accessory_1_button_background_id { get; set; }
            [Index (33)] public virtual string accessory_2_button_background_id { get; set; }
            [Index (34)] public virtual string accessory_3_button_background_id { get; set; }
            [Index (35)] public virtual string quantity_background_id { get; set; }
            [Index (36)] public virtual string trap_stats_background_id { get; set; }
            [Index (37)] public virtual string strength_icon_id { get; set; }
            [Index (38)] public virtual string luck_icon_id { get; set; }
            [Index (39)] public virtual string cage_icon_id { get; set; }
            [Index (40)] public virtual string energy_icon_id { get; set; }
            [Index (41)] public virtual string energy_bar_background_id { get; set; }
            [Index (42)] public virtual string energy_bar_id { get; set; }
            [Index (43)] public virtual string rage_icon_id { get; set; }
            [Index (44)] public virtual string rage_bar_background_id { get; set; }
            [Index (45)] public virtual string rage_bar_id { get; set; }
            [Index (46)] public virtual string fairy_level_background_id { get; set; }
            [Index (47)] public virtual string fairy_level_bar_background_id { get; set; }
            [Index (48)] public virtual string fairy_level_bar_id { get; set; }
            [Index (49)] public virtual string fairy_rarity_id { get; set; }
            [Index (50)] public virtual string selected_slot_highlight { get; set; }
            [Index (51)] public virtual string hunt_button_highlight { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string camp_title { get; set; }
            [Index (1)] public virtual string activity_button { get; set; }
            [Index (2)] public virtual string change_location_button { get; set; }
            [Index (3)] public virtual string hunt_button { get; set; }
            [Index (4)] public virtual string effectiveness_button { get; set; }
            [Index (5)] public virtual string history_button { get; set; }
            [Index (6)] public virtual string slot { get; set; }
            [Index (7)] public virtual string slot_1_button { get; set; }
            [Index (8)] public virtual string slot_2_button { get; set; }
            [Index (9)] public virtual string slot_3_button { get; set; }
            [Index (10)] public virtual string slot_4_button { get; set; }
            [Index (11)] public virtual string slot_5_button { get; set; }
            [Index (12)] public virtual string slot_6_button { get; set; }
            [Index (13)] public virtual string no_fairy { get; set; }
            [Index (14)] public virtual string no_fairy_food { get; set; }
            [Index (15)] public virtual string fairy_food_quantity { get; set; }
            [Index (16)] public virtual string no_crystal { get; set; }
            [Index (17)] public virtual string crystal_quantity { get; set; }
            [Index (18)] public virtual string no_bait { get; set; }
            [Index (19)] public virtual string bait_quantity { get; set; }
            [Index (20)] public virtual string no_flavour { get; set; }
            [Index (21)] public virtual string flavour_quantity { get; set; }
            [Index (22)] public virtual string no_weapon { get; set; }
            [Index (23)] public virtual string no_ammo { get; set; }
            [Index (24)] public virtual string ammo_quantity { get; set; }
            [Index (25)] public virtual string quantity_low { get; set; }
            [Index (26)] public virtual string no_accessory_1 { get; set; }
            [Index (27)] public virtual string no_accessory_2 { get; set; }
            [Index (28)] public virtual string no_accessory_3 { get; set; }
            [Index (29)] public virtual string strength { get; set; }
            [Index (30)] public virtual string luck { get; set; }
            [Index (31)] public virtual string cage { get; set; }
            [Index (32)] public virtual string energy { get; set; }
            [Index (33)] public virtual string rage { get; set; }
            [Index (34)] public virtual string fairy_level { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN5 - Transition Loading Panel
    [ZeroFormattable]
    public class TransitionLoadingPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string bubble_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string message { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN6 - Hunt Result Panel Data
    [ZeroFormattable]
    public class HuntResultPanelData : BaseData
    {
        [ZeroFormattable]
        public class RewardMaterial
        {
            [Index (0)] public virtual string coin_id { get; set; }
            [Index (1)] public virtual string reputation_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string inactive_midground_id { get; set; }
            [Index (3)] public virtual string detail_background_id { get; set; }
            [Index (4)] public virtual string detail_foreground_id { get; set; }
            [Index (5)] public virtual string skip_button_background_id { get; set; }
            [Index (6)] public virtual string skip_icon_id { get; set; }
            [Index (7)] public virtual string skip_all_button_background_id { get; set; }
            [Index (8)] public virtual string skip_all_icon_id { get; set; }
            [Index (9)] public virtual string lethal_icon_id { get; set; }
            [Index (10)] public virtual string attract_failed_icon_id { get; set; }
            [Index (11)] public virtual string catch_success_icon_id { get; set; }
            [Index (12)] public virtual string location_background_id { get; set; }
            [Index (13)] public virtual string hunt_bug_background_id { get; set; }
            [Index (14)] public virtual string fairy_background_id { get; set; }
            [Index (15)] public virtual string fairy_food_background_id { get; set; }
            [Index (16)] public virtual string crystal_background_id { get; set; }
            [Index (17)] public virtual string bait_background_id { get; set; }
            [Index (18)] public virtual string flavour_background_id { get; set; }
            [Index (19)] public virtual string weapon_background_id { get; set; }
            [Index (20)] public virtual string ammo_background_id { get; set; }
            [Index (21)] public virtual string accessory_1_background_id { get; set; }
            [Index (22)] public virtual string accessory_2_background_id { get; set; }
            [Index (23)] public virtual string accessory_3_background_id { get; set; }
            [Index (24)] public virtual string rage_icon_id { get; set; }
            [Index (25)] public virtual string rage_bar_background_id { get; set; }
            [Index (26)] public virtual string rage_bar_id { get; set; }
            [Index (27)] public virtual string loot_summary_button_background_id { get; set; }
            [Index (28)] public virtual string loot_summary_icon_id { get; set; }
            [Index (29)] public virtual string trade_button_background_id { get; set; }
            [Index (30)] public virtual string trade_icon_id { get; set; }
            [Index (31)] public virtual string size_icon_id { get; set; }
            [Index (32)] public virtual string royal_icon_id { get; set; }
            [Index (33)] public virtual string summary_bug_background_id { get; set; }
            [Index (34)] public virtual string scroll_view_background_id { get; set; }
            [Index (35)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (36)] public virtual string scroll_view_handler_id { get; set; }
            [Index (37)] public virtual string bug_portrait_background_id { get; set; }
            [Index (38)] public virtual string bug_portrait_bug_background_id { get; set; }
            [Index (39)] public virtual string summary_slot_background_id { get; set; }
            [Index (40)] public virtual string summary_message_background_id { get; set; }
            [Index (41)] public virtual string summary_message_bottom_seperator_id { get; set; }
            [Index (42)] public virtual string catch_alive_background_id { get; set; }
            [Index (43)] public virtual string catch_alive_bottom_seperator_id { get; set; }
            [Index (44)] public virtual string catch_death_background_id { get; set; }
            [Index (45)] public virtual string catch_death_bottom_seperator_id { get; set; }
            [Index (46)] public virtual string catch_failed_background_id { get; set; }
            [Index (47)] public virtual string catch_failed_bottom_seperator_id { get; set; }
            [Index (48)] public virtual string attract_failed_background_id { get; set; }
            [Index (49)] public virtual string attract_failed_bottom_seperator_id { get; set; }
            [Index (50)] public virtual string not_equip_icon { get; set; }
            [Index (51)] public virtual string slot_1_background_id { get; set; }
            [Index (52)] public virtual string slot_2_background_id { get; set; }
            [Index (53)] public virtual string slot_3_background_id { get; set; }
            [Index (54)] public virtual string slot_4_background_id { get; set; }
            [Index (55)] public virtual string slot_5_background_id { get; set; }
            [Index (56)] public virtual string slot_6_background_id { get; set; }
            [Index (57)] public virtual string selected_slot_highlight { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string hunt_slot { get; set; }
            [Index (1)] public virtual string skip_button { get; set; }
            [Index (2)] public virtual string skip_all_button { get; set; }
            [Index (3)] public virtual string summary { get; set; }
            [Index (4)] public virtual string rage { get; set; }
            [Index (5)] public virtual string loot_summary_button { get; set; }
            [Index (6)] public virtual string trade_button { get; set; }
            [Index (7)] public virtual string summary_slot { get; set; }
            [Index (8)] public virtual string summary_bug_name { get; set; }
            [Index (9)] public virtual string size { get; set; }
            [Index (10)] public virtual string reward { get; set; }
            [Index (11)] public virtual string reward_name { get; set; }
            [Index (12)] public virtual string date { get; set; }
            [Index (13)] public virtual string message { get; set; }
            [Index (14)] public virtual string bug_portrait_bug_name { get; set; }
            [Index (15)] public virtual string slot_1_button { get; set; }
            [Index (16)] public virtual string slot_2_button { get; set; }
            [Index (17)] public virtual string slot_3_button { get; set; }
            [Index (18)] public virtual string slot_4_button { get; set; }
            [Index (19)] public virtual string slot_5_button { get; set; }
            [Index (20)] public virtual string slot_6_button { get; set; }
            [Index (21)] public virtual string no_action { get; set; }
        }
        [Index (1)] public virtual RewardMaterial reward_material { get; set; }
        [Index (2)] public virtual UiSprite ui_sprite { get; set; }
        [Index (3)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN7 - Hunt History Panel Data
    [ZeroFormattable]
    public class HuntHistoryPanelData : BaseData
    {
        [ZeroFormattable]
        public class RewardMaterial
        {
            [Index (0)] public virtual string coin_id { get; set; }
            [Index (1)] public virtual string reputation_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string order_button_background_id { get; set; }
            [Index (5)] public virtual string order_icon_id { get; set; }
            [Index (6)] public virtual string lethal_icon_id { get; set; }
            [Index (7)] public virtual string attract_failed_icon_id { get; set; }
            [Index (8)] public virtual string catch_success_icon_id { get; set; }
            [Index (9)] public virtual string size_icon_id { get; set; }
            [Index (10)] public virtual string royal_icon_id { get; set; }
            [Index (11)] public virtual string scroll_view_background_id { get; set; }
            [Index (12)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (13)] public virtual string scroll_view_handler_id { get; set; }
            [Index (14)] public virtual string bug_portrait_background_id { get; set; }
            [Index (15)] public virtual string bug_portrait_bug_background_id { get; set; }
            [Index (16)] public virtual string slot_background_id { get; set; }
            [Index (17)] public virtual string message_background_id { get; set; }
            [Index (18)] public virtual string message_bottom_seperator_id { get; set; }
            [Index (19)] public virtual string catch_alive_background_id { get; set; }
            [Index (20)] public virtual string catch_alive_bottom_seperator_id { get; set; }
            [Index (21)] public virtual string catch_death_background_id { get; set; }
            [Index (22)] public virtual string catch_death_bottom_seperator_id { get; set; }
            [Index (23)] public virtual string catch_failed_background_id { get; set; }
            [Index (24)] public virtual string catch_failed_bottom_seperator_id { get; set; }
            [Index (25)] public virtual string attract_failed_background_id { get; set; }
            [Index (26)] public virtual string attract_failed_bottom_seperator_id { get; set; }
            [Index (27)] public virtual string bug_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string slot { get; set; }
            [Index (1)] public virtual string close_button { get; set; }
            [Index (2)] public virtual string order_button { get; set; }
            [Index (3)] public virtual string history { get; set; }
            [Index (4)] public virtual string bug_name { get; set; }
            [Index (5)] public virtual string size { get; set; }
            [Index (6)] public virtual string reward { get; set; }
            [Index (7)] public virtual string reward_name { get; set; }
            [Index (8)] public virtual string date { get; set; }
            [Index (9)] public virtual string message { get; set; }
            [Index (10)] public virtual string bug_portrait_bug_name { get; set; }
        }
        [Index (1)] public virtual RewardMaterial reward_material { get; set; }
        [Index (2)] public virtual UiSprite ui_sprite { get; set; }
        [Index (3)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN8 - Change Trap Setup Panel Data
    [ZeroFormattable]
    public class ChangeTrapSetupPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string strength_icon_id { get; set; }
            [Index (3)] public virtual string luck_icon_id { get; set; }
            [Index (4)] public virtual string lethal_icon_id { get; set; }
            [Index (5)] public virtual string extra_lethal_icon_id { get; set; }
            [Index (6)] public virtual string scroll_view_background_id { get; set; }
            [Index (7)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (8)] public virtual string scroll_view_handler_id { get; set; }
            [Index (9)] public virtual string select_icon_id { get; set; }
            [Index (10)] public virtual string swap_icon_id { get; set; }
            [Index (11)] public virtual string search_input_background_id { get; set; }
            [Index (12)] public virtual string search_button_background_id { get; set; }
            [Index (13)] public virtual string search_icon_id { get; set; }
            [Index (14)] public virtual string search_elemental_background_id { get; set; }
            [Index (15)] public virtual string selected_search_elemental_icon_id { get; set; }
            [Index (16)] public virtual string remove_button_background_id { get; set; }
            [Index (17)] public virtual string remove_icon_id { get; set; }
            [Index (18)] public virtual string close_button_background_id { get; set; }
            [Index (19)] public virtual string close_icon_id { get; set; }
            [Index (20)] public virtual string fairy_selection_background_id { get; set; }
            [Index (21)] public virtual string fairy_selection_seperator_id { get; set; }
            [Index (22)] public virtual string fairy_selection_fairy_background_id { get; set; }
            [Index (23)] public virtual string fairy_selection_level_bar_background_id { get; set; }
            [Index (24)] public virtual string fairy_selection_level_bar_id { get; set; }
            [Index (25)] public virtual string fairy_selection_select_button_background_id { get; set; }
            [Index (26)] public virtual string fairy_selection_swap_button_background_id { get; set; }
            [Index (27)] public virtual string weapon_selection_background_id { get; set; }
            [Index (28)] public virtual string weapon_selection_search_background_id { get; set; }
            [Index (29)] public virtual string weapon_selection_seperator_id { get; set; }
            [Index (30)] public virtual string weapon_selection_weapon_background_id { get; set; }
            [Index (31)] public virtual string weapon_selection_element_background_id { get; set; }
            [Index (32)] public virtual string weapon_selection_addition_ammo_id { get; set; }
            [Index (33)] public virtual string weapon_selection_select_button_background_id { get; set; }
            [Index (34)] public virtual string weapon_selection_swap_button_background_id { get; set; }
            [Index (35)] public virtual string ammo_selection_background_id { get; set; }
            [Index (36)] public virtual string ammo_selection_seperator_id { get; set; }
            [Index (37)] public virtual string ammo_selection_ammo_background_id { get; set; }
            [Index (38)] public virtual string ammo_selection_select_button_background_id { get; set; }
            [Index (39)] public virtual string bait_selection_background_id { get; set; }
            [Index (40)] public virtual string bait_selection_seperator_id { get; set; }
            [Index (41)] public virtual string bait_selection_bait_background_id { get; set; }
            [Index (42)] public virtual string bait_selection_select_button_background_id { get; set; }
            [Index (43)] public virtual string flavour_selection_background_id { get; set; }
            [Index (44)] public virtual string flavour_selection_seperator_id { get; set; }
            [Index (45)] public virtual string flavour_selection_flavour_background_id { get; set; }
            [Index (46)] public virtual string flavour_selection_select_button_background_id { get; set; }
            [Index (47)] public virtual string location_selection_background_id { get; set; }
            [Index (48)] public virtual string location_selection_seperator_id { get; set; }
            [Index (49)] public virtual string location_selection_location_background_id { get; set; }
            [Index (50)] public virtual string location_selection_select_button_background_id { get; set; }
            [Index (51)] public virtual string crystal_selection_background_id { get; set; }
            [Index (52)] public virtual string crystal_selection_seperator_id { get; set; }
            [Index (53)] public virtual string crystal_selection_crystal_background_id { get; set; }
            [Index (54)] public virtual string crystal_selection_select_button_background_id { get; set; }
            [Index (55)] public virtual string accessory_selection_background_id { get; set; }
            [Index (56)] public virtual string accessory_selection_seperator_id { get; set; }
            [Index (57)] public virtual string accessory_selection_accessory_background_id { get; set; }
            [Index (58)] public virtual string accessory_selection_select_button_background_id { get; set; }
            [Index (59)] public virtual string accessory_selection_swap_button_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string title { get; set; }
            [Index (1)] public virtual string search_prompt { get; set; }
            [Index (2)] public virtual string search_input { get; set; }
            [Index (3)] public virtual string search_button { get; set; }
            [Index (4)] public virtual string select_button { get; set; }
            [Index (5)] public virtual string swap_button { get; set; }
            [Index (6)] public virtual string remove_button { get; set; }
            [Index (7)] public virtual string close_button { get; set; }
            [Index (8)] public virtual string fairy_selection_fairy { get; set; }
            [Index (9)] public virtual string fairy_selection_level { get; set; }
            [Index (10)] public virtual string fairy_selection_strength { get; set; }
            [Index (11)] public virtual string fairy_selection_luck { get; set; }
            [Index (12)] public virtual string fairy_selection_location { get; set; }
            [Index (13)] public virtual string fairy_selection_fairy_food_quantity { get; set; }
            [Index (14)] public virtual string fairy_selection_effect { get; set; }
            [Index (15)] public virtual string fairy_selection_effect_description { get; set; }
            [Index (16)] public virtual string fairy_selection_hunt_at { get; set; }
            [Index (17)] public virtual string weapon_selection_weapon { get; set; }
            [Index (18)] public virtual string weapon_selection_strength { get; set; }
            [Index (19)] public virtual string weapon_selection_ammo { get; set; }
            [Index (20)] public virtual string weapon_selection_ammo_quantity { get; set; }
            [Index (21)] public virtual string weapon_selection_used_by { get; set; }
            [Index (22)] public virtual string ammo_selection_ammo { get; set; }
            [Index (23)] public virtual string ammo_selection_strength_bonus { get; set; }
            [Index (24)] public virtual string ammo_selection_ammo_quantity { get; set; }
            [Index (25)] public virtual string bait_selection_bait { get; set; }
            [Index (26)] public virtual string bait_selection_bait_quantity { get; set; }
            [Index (27)] public virtual string flavour_selection_flavour { get; set; }
            [Index (28)] public virtual string flavour_selection_flavour_quantity { get; set; }
            [Index (29)] public virtual string location_selection_location { get; set; }
            [Index (30)] public virtual string location_selection_occupy_by { get; set; }
            [Index (31)] public virtual string crystal_selection_crystal { get; set; }
            [Index (32)] public virtual string crystal_selection_effect_description { get; set; }
            [Index (33)] public virtual string crystal_selection_crystal_quantity { get; set; }
            [Index (34)] public virtual string accessory_selection_accessory { get; set; }
            [Index (35)] public virtual string accessory_selection_effect_description { get; set; }
            [Index (36)] public virtual string accessory_selection_used_by { get; set; }
            [Index (37)] public virtual string quantity_low { get; set; }
            [Index (38)] public virtual string in_use { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN9 - Main Menu Panel Data
    [ZeroFormattable]
    public class MainMenuPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string foreground_id { get; set; }
            [Index (2)] public virtual string camp_button_background_id { get; set; }
            [Index (3)] public virtual string camp_icon_id { get; set; }
            [Index (4)] public virtual string warehouse_button_background_id { get; set; }
            [Index (5)] public virtual string warehouse_icon_id { get; set; }
            [Index (6)] public virtual string food_stall_button_background_id { get; set; }
            [Index (7)] public virtual string food_stall_icon_id { get; set; }
            [Index (8)] public virtual string smith_button_background_id { get; set; }
            [Index (9)] public virtual string smith_icon_id { get; set; }
            [Index (10)] public virtual string ammo_dealer_button_background_id { get; set; }
            [Index (11)] public virtual string ammo_dealer_icon_id { get; set; }
            [Index (12)] public virtual string fairy_bakery_button_background_id { get; set; }
            [Index (13)] public virtual string fairy_bakery_icon_id { get; set; }
            [Index (14)] public virtual string crystal_lab_button_background_id { get; set; }
            [Index (15)] public virtual string crystal_lab_icon_id { get; set; }
            [Index (16)] public virtual string accessory_maker_button_background_id { get; set; }
            [Index (17)] public virtual string accessory_maker_icon_id { get; set; }
            [Index (18)] public virtual string craftsman_button_background_id { get; set; }
            [Index (19)] public virtual string craftsman_icon_id { get; set; }
            [Index (20)] public virtual string cage_master_button_background_id { get; set; }
            [Index (21)] public virtual string cage_master_icon_id { get; set; }
            [Index (22)] public virtual string inventory_button_background_id { get; set; }
            [Index (23)] public virtual string inventory_icon_id { get; set; }
            [Index (24)] public virtual string gallery_button_background_id { get; set; }
            [Index (25)] public virtual string gallery_icon_id { get; set; }
            [Index (26)] public virtual string statistic_button_background_id { get; set; }
            [Index (27)] public virtual string statistic_icon_id { get; set; }
            [Index (28)] public virtual string setting_button_background_id { get; set; }
            [Index (29)] public virtual string setting_icon_id { get; set; }
            [Index (30)] public virtual string credit_button_background_id { get; set; }
            [Index (31)] public virtual string credit_icon_id { get; set; }
            [Index (32)] public virtual string close_button_background_id { get; set; }
            [Index (33)] public virtual string close_icon_id { get; set; }
            [Index (34)] public virtual string quit_button_background_id { get; set; }
            [Index (35)] public virtual string quit_icon_id { get; set; }
            [Index (36)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (37)] public virtual string scroll_view_handler_id { get; set; }
            [Index (38)] public virtual string quit_panel_background_id { get; set; }
            [Index (39)] public virtual string quit_panel_foreground_id { get; set; }
            [Index (40)] public virtual string quit_panel_quit_icon_id { get; set; }
            [Index (41)] public virtual string quit_panel_yes_button_background_id { get; set; }
            [Index (42)] public virtual string quit_panel_yes_icon_id { get; set; }
            [Index (43)] public virtual string quit_panel_no_button_background_id { get; set; }
            [Index (44)] public virtual string quit_panel_no_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string menu { get; set; }
            [Index (1)] public virtual string camp_button { get; set; }
            [Index (2)] public virtual string warehouse_button { get; set; }
            [Index (3)] public virtual string food_stall_button { get; set; }
            [Index (4)] public virtual string smith_button { get; set; }
            [Index (5)] public virtual string ammo_dealer_button { get; set; }
            [Index (6)] public virtual string fairy_bakery_button { get; set; }
            [Index (7)] public virtual string crystal_lab_button { get; set; }
            [Index (8)] public virtual string accessory_maker_button { get; set; }
            [Index (9)] public virtual string craftsman_button { get; set; }
            [Index (10)] public virtual string cage_master_button { get; set; }
            [Index (11)] public virtual string inventory_button { get; set; }
            [Index (12)] public virtual string gallery_button { get; set; }
            [Index (13)] public virtual string statistic_button { get; set; }
            [Index (14)] public virtual string setting_button { get; set; }
            [Index (15)] public virtual string credit_button { get; set; }
            [Index (16)] public virtual string close_button { get; set; }
            [Index (17)] public virtual string quit_button { get; set; }
            [Index (18)] public virtual string quit_message { get; set; }
            [Index (19)] public virtual string yes_button { get; set; }
            [Index (20)] public virtual string no_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN10 - Top Bar Hunt Panel Data
    [ZeroFormattable]
    public class TopBarHuntPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string foreground_id { get; set; }
            [Index (2)] public virtual string hunt_button_background_id { get; set; }
            [Index (3)] public virtual string hunt_icon_id { get; set; }
            [Index (4)] public virtual string slot_1_notification_id { get; set; }
            [Index (5)] public virtual string slot_2_notification_id { get; set; }
            [Index (6)] public virtual string slot_3_notification_id { get; set; }
            [Index (7)] public virtual string slot_4_notification_id { get; set; }
            [Index (8)] public virtual string slot_5_notification_id { get; set; }
            [Index (9)] public virtual string slot_6_notification_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string hunt_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN11 - Gallery Category Panel Data
    [ZeroFormattable]
    public class GalleryCategoryPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string fairy_background_id { get; set; }
            [Index (3)] public virtual string fairy_icon_id { get; set; }
            [Index (4)] public virtual string weapon_background_id { get; set; }
            [Index (5)] public virtual string weapon_icon_id { get; set; }
            [Index (6)] public virtual string bait_background_id { get; set; }
            [Index (7)] public virtual string bait_icon_id { get; set; }
            [Index (8)] public virtual string flavour_background_id { get; set; }
            [Index (9)] public virtual string flavour_icon_id { get; set; }
            [Index (10)] public virtual string crystal_background_id { get; set; }
            [Index (11)] public virtual string crystal_icon_id { get; set; }
            [Index (12)] public virtual string accessory_background_id { get; set; }
            [Index (13)] public virtual string accessory_icon_id { get; set; }
            [Index (14)] public virtual string unit_background_id { get; set; }
            [Index (15)] public virtual string unit_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string gallery { get; set; }
            [Index (1)] public virtual string fairy { get; set; }
            [Index (2)] public virtual string weapon { get; set; }
            [Index (3)] public virtual string bait { get; set; }
            [Index (4)] public virtual string flavour { get; set; }
            [Index (5)] public virtual string crystal { get; set; }
            [Index (6)] public virtual string accessory { get; set; }
            [Index (7)] public virtual string unit { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN12 - Gallery Unit Location Panel Data
    [ZeroFormattable]
    public class GalleryUnitLocationPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string location_button_background_id { get; set; }
            [Index (5)] public virtual string region_background_id { get; set; }
            [Index (6)] public virtual string back_button_background_id { get; set; }
            [Index (7)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string select_location { get; set; }
            [Index (1)] public virtual string region { get; set; }
            [Index (2)] public virtual string location_button { get; set; }
            [Index (3)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN13 - Gallery Unit Panel Data
    [ZeroFormattable]
    public class GalleryUnitPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string royal_icon_id { get; set; }
            [Index (5)] public virtual string unit_button_background_id { get; set; }
            [Index (6)] public virtual string back_button_background_id { get; set; }
            [Index (7)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string select_unit { get; set; }
            [Index (1)] public virtual string unit_button { get; set; }
            [Index (2)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN14 - Gallery Unit Statistic Panel Data
    [ZeroFormattable]
    public class GalleryUnitStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string reputation_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string thumbnail_background_id { get; set; }
            [Index (8)] public virtual string portrait_background_id { get; set; }
            [Index (9)] public virtual string elemental_icon_id { get; set; }
            [Index (10)] public virtual string strength_icon_id { get; set; }
            [Index (11)] public virtual string rage_icon_id { get; set; }
            [Index (12)] public virtual string first_seperator_id { get; set; }
            [Index (13)] public virtual string size_icon_id { get; set; }
            [Index (14)] public virtual string encounter_icon_id { get; set; }
            [Index (15)] public virtual string catch_rate_icon_id { get; set; }
            [Index (16)] public virtual string catch_rate_bar_background_id { get; set; }
            [Index (17)] public virtual string catch_rate_bar_id { get; set; }
            [Index (18)] public virtual string death_rate_icon_id { get; set; }
            [Index (19)] public virtual string death_rate_bar_background_id { get; set; }
            [Index (20)] public virtual string death_rate_bar_id { get; set; }
            [Index (21)] public virtual string coin_reward_icon_id { get; set; }
            [Index (22)] public virtual string reputation_reward_icon_id { get; set; }
            [Index (23)] public virtual string material_gather_icon_id { get; set; }
            [Index (24)] public virtual string royal_encounter_icon_id { get; set; }
            [Index (25)] public virtual string royal_catch_rate_icon_id { get; set; }
            [Index (26)] public virtual string royal_catch_rate_bar_background_id { get; set; }
            [Index (27)] public virtual string royal_catch_rate_bar_id { get; set; }
            [Index (28)] public virtual string second_seperator_id { get; set; }
            [Index (29)] public virtual string third_seperator_id { get; set; }
            [Index (30)] public virtual string loot_poll_bar_background_id { get; set; }
            [Index (31)] public virtual string loot_poll_bar_id { get; set; }
            [Index (32)] public virtual string fourth_seperator_id { get; set; }
            [Index (33)] public virtual string unknown_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string unit_name { get; set; }
            [Index (1)] public virtual string elemental { get; set; }
            [Index (2)] public virtual string strength { get; set; }
            [Index (3)] public virtual string reputation { get; set; }
            [Index (4)] public virtual string rage { get; set; }
            [Index (5)] public virtual string size { get; set; }
            [Index (6)] public virtual string encounter { get; set; }
            [Index (7)] public virtual string catch_rate { get; set; }
            [Index (8)] public virtual string death_rate { get; set; }
            [Index (9)] public virtual string coin_reward { get; set; }
            [Index (10)] public virtual string reputation_reward { get; set; }
            [Index (11)] public virtual string material_gather { get; set; }
            [Index (12)] public virtual string royal_encounter { get; set; }
            [Index (13)] public virtual string royal_catch_rate { get; set; }
            [Index (14)] public virtual string loot { get; set; }
            [Index (15)] public virtual string loot_material { get; set; }
            [Index (16)] public virtual string no_loot { get; set; }
            [Index (17)] public virtual string locate_at { get; set; }
            [Index (18)] public virtual string locate_at_location { get; set; }
            [Index (19)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual UiSprite ui_sprite { get; set; }
        [Index (3)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN15 - Gallery Fairy Panel Data
    [ZeroFormattable]
    public class GalleryFairyPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string fairy_button_background_id { get; set; }
            [Index (5)] public virtual string back_button_background_id { get; set; }
            [Index (6)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string select_fairy { get; set; }
            [Index (1)] public virtual string fairy_button { get; set; }
            [Index (2)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN16 - Gallery Fairy Statistic Panel Data
    [ZeroFormattable]
    public class GalleryFairyStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string next_button_background_id { get; set; }
            [Index (3)] public virtual string next_icon_id { get; set; }
            [Index (4)] public virtual string close_button_background_id { get; set; }
            [Index (5)] public virtual string close_icon_id { get; set; }
            [Index (6)] public virtual string fairy_scroll_view_background_id { get; set; }
            [Index (7)] public virtual string fairy_scroll_view_handler_background_id { get; set; }
            [Index (8)] public virtual string fairy_scroll_view_handler_id { get; set; }
            [Index (9)] public virtual string fairy_thumbnail_background_id { get; set; }
            [Index (10)] public virtual string fairy_portrait_background_id { get; set; }
            [Index (11)] public virtual string fairy_rarity_id { get; set; }
            [Index (12)] public virtual string fairy_food_icon_id { get; set; }
            [Index (13)] public virtual string strength_icon_id { get; set; }
            [Index (14)] public virtual string strength_per_level_icon_id { get; set; }
            [Index (15)] public virtual string max_level_icon_id { get; set; }
            [Index (16)] public virtual string luck_icon_id { get; set; }
            [Index (17)] public virtual string first_seperator_id { get; set; }
            [Index (18)] public virtual string encounter_icon_id { get; set; }
            [Index (19)] public virtual string catch_rate_icon_id { get; set; }
            [Index (20)] public virtual string catch_rate_bar_background_id { get; set; }
            [Index (21)] public virtual string catch_rate_bar_id { get; set; }
            [Index (22)] public virtual string death_rate_icon_id { get; set; }
            [Index (23)] public virtual string death_rate_bar_background_id { get; set; }
            [Index (24)] public virtual string death_rate_bar_id { get; set; }
            [Index (25)] public virtual string coin_reward_icon_id { get; set; }
            [Index (26)] public virtual string reputation_reward_icon_id { get; set; }
            [Index (27)] public virtual string material_gather_icon_id { get; set; }
            [Index (28)] public virtual string royal_encounter_icon_id { get; set; }
            [Index (29)] public virtual string royal_catch_rate_icon_id { get; set; }
            [Index (30)] public virtual string royal_catch_rate_bar_background_id { get; set; }
            [Index (31)] public virtual string royal_catch_rate_bar_id { get; set; }
            [Index (32)] public virtual string second_seperator_id { get; set; }
            [Index (33)] public virtual string unknown_icon_id { get; set; }
            [Index (34)] public virtual string pest_scroll_view_background_id { get; set; }
            [Index (35)] public virtual string pest_scroll_view_handler_background_id { get; set; }
            [Index (36)] public virtual string pest_scroll_view_handler_id { get; set; }
            [Index (37)] public virtual string pest_seperator_id { get; set; }
            [Index (38)] public virtual string pest_thumbnail_background_id { get; set; }
            [Index (39)] public virtual string first_page_background_id { get; set; }
            [Index (40)] public virtual string last_page_background_id { get; set; }
            [Index (41)] public virtual string normal_page_background_id { get; set; }
            [Index (42)] public virtual string selected_page_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string fairy_name { get; set; }
            [Index (1)] public virtual string fairy_food { get; set; }
            [Index (2)] public virtual string strength { get; set; }
            [Index (3)] public virtual string strength_per_level { get; set; }
            [Index (4)] public virtual string max_level { get; set; }
            [Index (5)] public virtual string luck { get; set; }
            [Index (6)] public virtual string effect { get; set; }
            [Index (7)] public virtual string effect_description { get; set; }
            [Index (8)] public virtual string pest_encounter { get; set; }
            [Index (9)] public virtual string pest_catch_rate { get; set; }
            [Index (10)] public virtual string pest_death_rate { get; set; }
            [Index (11)] public virtual string coin_reward { get; set; }
            [Index (12)] public virtual string reputation_reward { get; set; }
            [Index (13)] public virtual string material_gather { get; set; }
            [Index (14)] public virtual string royal_pest_encounter { get; set; }
            [Index (15)] public virtual string royal_pest_catch_rate { get; set; }
            [Index (16)] public virtual string next_button { get; set; }
            [Index (17)] public virtual string close_button { get; set; }
            [Index (18)] public virtual string no_pest_encounter { get; set; }
            [Index (19)] public virtual string pest_name { get; set; }
            [Index (20)] public virtual string first_page { get; set; }
            [Index (21)] public virtual string last_page { get; set; }
            [Index (22)] public virtual string normal_page { get; set; }
            [Index (23)] public virtual string selected_page { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN17 - Gallery Weapon Panel Data
    [ZeroFormattable]
    public class GalleryWeaponPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string weapon_button_background_id { get; set; }
            [Index (5)] public virtual string back_button_background_id { get; set; }
            [Index (6)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string select_weapon { get; set; }
            [Index (1)] public virtual string weapon_button { get; set; }
            [Index (2)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN18 - Gallery Weapon Statistic Panel Data
    [ZeroFormattable]
    public class GalleryWeaponStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string next_button_background_id { get; set; }
            [Index (3)] public virtual string next_icon_id { get; set; }
            [Index (4)] public virtual string close_button_background_id { get; set; }
            [Index (5)] public virtual string close_icon_id { get; set; }
            [Index (6)] public virtual string weapon_scroll_view_background_id { get; set; }
            [Index (7)] public virtual string weapon_scroll_view_handler_background_id { get; set; }
            [Index (8)] public virtual string weapon_scroll_view_handler_id { get; set; }
            [Index (9)] public virtual string weapon_thumbnail_background_id { get; set; }
            [Index (10)] public virtual string weapon_portrait_background_id { get; set; }
            [Index (11)] public virtual string elemental_icon_id { get; set; }
            [Index (12)] public virtual string strength_icon_id { get; set; }
            [Index (13)] public virtual string weapon_first_seperator_id { get; set; }
            [Index (14)] public virtual string encounter_icon_id { get; set; }
            [Index (15)] public virtual string catch_rate_icon_id { get; set; }
            [Index (16)] public virtual string catch_rate_bar_background_id { get; set; }
            [Index (17)] public virtual string catch_rate_bar_id { get; set; }
            [Index (18)] public virtual string weapon_second_seperator_id { get; set; }
            [Index (19)] public virtual string unknown_icon_id { get; set; }
            [Index (20)] public virtual string ammo_scroll_view_background_id { get; set; }
            [Index (21)] public virtual string ammo_scroll_view_handler_background_id { get; set; }
            [Index (22)] public virtual string ammo_scroll_view_handler_id { get; set; }
            [Index (23)] public virtual string ammo_thumbnail_background_id { get; set; }
            [Index (24)] public virtual string ammo_portrait_background_id { get; set; }
            [Index (25)] public virtual string lethal_icon_id { get; set; }
            [Index (26)] public virtual string extra_lethal_icon_id { get; set; }
            [Index (27)] public virtual string strength_bonus_icon_id { get; set; }
            [Index (28)] public virtual string death_icon_id { get; set; }
            [Index (29)] public virtual string ammo_first_seperator_id { get; set; }
            [Index (30)] public virtual string used_icon_id { get; set; }
            [Index (31)] public virtual string death_rate_icon_id { get; set; }
            [Index (32)] public virtual string death_rate_bar_background_id { get; set; }
            [Index (33)] public virtual string death_rate_bar_id { get; set; }
            [Index (34)] public virtual string ammo_second_seperator_id { get; set; }
            [Index (35)] public virtual string first_page_background_id { get; set; }
            [Index (36)] public virtual string last_page_background_id { get; set; }
            [Index (37)] public virtual string normal_page_background_id { get; set; }
            [Index (38)] public virtual string selected_page_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string weapon_name { get; set; }
            [Index (1)] public virtual string elemental { get; set; }
            [Index (2)] public virtual string strength { get; set; }
            [Index (3)] public virtual string encounter { get; set; }
            [Index (4)] public virtual string catch_rate { get; set; }
            [Index (5)] public virtual string ammo_name { get; set; }
            [Index (6)] public virtual string strength_bonus { get; set; }
            [Index (7)] public virtual string lethal { get; set; }
            [Index (8)] public virtual string used { get; set; }
            [Index (9)] public virtual string death_rate { get; set; }
            [Index (10)] public virtual string next_button { get; set; }
            [Index (11)] public virtual string close_button { get; set; }
            [Index (12)] public virtual string first_page { get; set; }
            [Index (13)] public virtual string last_page { get; set; }
            [Index (14)] public virtual string normal_page { get; set; }
            [Index (15)] public virtual string selected_page { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN19 - Gallery Bait Panel Data
    [ZeroFormattable]
    public class GalleryBaitPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string bait_button_background_id { get; set; }
            [Index (5)] public virtual string back_button_background_id { get; set; }
            [Index (6)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string select_bait { get; set; }
            [Index (1)] public virtual string bait_button { get; set; }
            [Index (2)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN20 - Gallery Bait Statistic Panel Data
    [ZeroFormattable]
    public class GalleryBaitStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string thumbnail_background_id { get; set; }
            [Index (8)] public virtual string portrait_background_id { get; set; }
            [Index (9)] public virtual string first_seperator_id { get; set; }
            [Index (10)] public virtual string used_icon_id { get; set; }
            [Index (11)] public virtual string attractive_rate_icon_id { get; set; }
            [Index (12)] public virtual string attractive_rate_bar_background_id { get; set; }
            [Index (13)] public virtual string attractive_rate_bar_id { get; set; }
            [Index (14)] public virtual string expected_attractive_rate_point_id { get; set; }
            [Index (15)] public virtual string second_seperator_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string bait_name { get; set; }
            [Index (1)] public virtual string used { get; set; }
            [Index (2)] public virtual string attractive_rate { get; set; }
            [Index (3)] public virtual string unit_family_attractive_rate { get; set; }
            [Index (4)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN21 - Gallery Flavour Panel Data
    [ZeroFormattable]
    public class GalleryFlavourPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string flavour_button_background_id { get; set; }
            [Index (5)] public virtual string back_button_background_id { get; set; }
            [Index (6)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string select_flavour { get; set; }
            [Index (1)] public virtual string flavour_button { get; set; }
            [Index (2)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN22 - Gallery Flavour Statistic Panel Data
    [ZeroFormattable]
    public class GalleryFlavourStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string thumbnail_background_id { get; set; }
            [Index (8)] public virtual string portrait_background_id { get; set; }
            [Index (9)] public virtual string first_seperator_id { get; set; }
            [Index (10)] public virtual string used_icon_id { get; set; }
            [Index (11)] public virtual string second_seperator_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string flavour_name { get; set; }
            [Index (1)] public virtual string used { get; set; }
            [Index (2)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN23 - Dialogue Panel Data
    [ZeroFormattable]
    public class DialoguePanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string dialogue_background_id { get; set; }
            [Index (2)] public virtual string end_of_text_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string dialogye { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN24 - Food Stall Panel Data
    [ZeroFormattable]
    public class FoodStallPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string bait_button_background_id { get; set; }
            [Index (6)] public virtual string discount_background_id { get; set; }
            [Index (7)] public virtual string discount_slash_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string food_stall { get; set; }
            [Index (1)] public virtual string bait_name { get; set; }
            [Index (2)] public virtual string origin_cost { get; set; }
            [Index (3)] public virtual string discount_value { get; set; }
            [Index (4)] public virtual string discounted_cost { get; set; }
            [Index (5)] public virtual string no_bait { get; set; }
        }
        [Index (1)] public virtual string intro_id { get; set; }
        [Index (2)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN25 - Food Stall Purchase Panel Data
    [ZeroFormattable]
    public class FoodStallPurchasePanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual string position_LR { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string purchase_button_background_id { get; set; }
            [Index (3)] public virtual string purchase_icon_id { get; set; }
            [Index (4)] public virtual string quantity_switch_button_background_id { get; set; }
            [Index (5)] public virtual string quantity_switch_icon_id { get; set; }
            [Index (6)] public virtual string close_button_background_id { get; set; }
            [Index (7)] public virtual string close_icon_id { get; set; }
            [Index (8)] public virtual string info_button_background_id { get; set; }
            [Index (9)] public virtual string scroll_view_background_id { get; set; }
            [Index (10)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (11)] public virtual string scroll_view_handler_id { get; set; }
            [Index (12)] public virtual string thumbnail_background_id { get; set; }
            [Index (13)] public virtual string owned_icon_id { get; set; }
            [Index (14)] public virtual string quantity_slide_bar_background_id { get; set; }
            [Index (15)] public virtual string quantity_slide_bar_id { get; set; }
            [Index (16)] public virtual string quantity_slide_bar_handler_id { get; set; }
            [Index (17)] public virtual string quantity_input_background_id { get; set; }
            [Index (18)] public virtual string purchase_success_background_id { get; set; }
            [Index (19)] public virtual string purchase_success_midground_id { get; set; }
            [Index (20)] public virtual string purchase_success_dialogue_background_id { get; set; }
            [Index (21)] public virtual string purchase_success_bait_thumbnail_background_id { get; set; }
            [Index (22)] public virtual string purchase_success_owned_quantity_to_id { get; set; }
            [Index (23)] public virtual string purchase_success_free_bait_icon_id { get; set; }
            [Index (24)] public virtual string purchase_success_close_button_background_id { get; set; }
            [Index (25)] public virtual string purchase_success_close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string bait_name { get; set; }
            [Index (1)] public virtual string owned { get; set; }
            [Index (2)] public virtual string material_require { get; set; }
            [Index (3)] public virtual string no_material_require { get; set; }
            [Index (4)] public virtual string material_name { get; set; }
            [Index (5)] public virtual string material_quantity { get; set; }
            [Index (6)] public virtual string material_sufficient { get; set; }
            [Index (7)] public virtual string material_insufficient { get; set; }
            [Index (8)] public virtual string quantity { get; set; }
            [Index (9)] public virtual string quantity_prompt { get; set; }
            [Index (10)] public virtual string quantity_input { get; set; }
            [Index (11)] public virtual string quantity_available { get; set; }
            [Index (12)] public virtual string slide_bar_quantity { get; set; }
            [Index (13)] public virtual string coin_name { get; set; }
            [Index (14)] public virtual string coin_available { get; set; }
            [Index (15)] public virtual string purchase_quantity { get; set; }
            [Index (16)] public virtual string cannot_purchase_message { get; set; }
            [Index (17)] public virtual string purchase_button { get; set; }
            [Index (18)] public virtual string close_button { get; set; }
            [Index (19)] public virtual string purchase_success { get; set; }
            [Index (20)] public virtual string dialogue { get; set; }
            [Index (21)] public virtual string purchase_success_bait_name { get; set; }
            [Index (22)] public virtual string purchase_success_owned { get; set; }
            [Index (23)] public virtual string purchase_success_owned_old_quantity { get; set; }
            [Index (24)] public virtual string purchase_success_owned_new_quantity { get; set; }
            [Index (25)] public virtual string purchase_success_purchase_quantity { get; set; }
            [Index (26)] public virtual string purchase_success_free_quantity { get; set; }
            [Index (27)] public virtual string purchase_success_close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual Dialogue dialogue { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN26 - Special Reward Panel
    [ZeroFormattable]
    public class SpecialRewardPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string reward_effect_id { get; set; }
            [Index (2)] public virtual string reward_background_id { get; set; }
            [Index (3)] public virtual string close_button_background_id { get; set; }
            [Index (4)] public virtual string close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string congrat { get; set; }
            [Index (1)] public virtual string receive { get; set; }
            [Index (2)] public virtual string reward_name { get; set; }
            [Index (3)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN27 - Catch Effectiveness Panel
    [ZeroFormattable]
    public class CatchEffectivenessPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string close_button_background_id { get; set; }
            [Index (6)] public virtual string close_icon_id { get; set; }
            [Index (7)] public virtual string unit_background_id { get; set; }
            [Index (8)] public virtual string unit_thumbnail_background_id { get; set; }
            [Index (9)] public virtual string unit_effective_bar_background_id { get; set; }
            [Index (10)] public virtual string unit_effective_bar_id { get; set; }
            [Index (11)] public virtual string unit_effective_positive_value_bar_id { get; set; }
            [Index (12)] public virtual string unit_effective_negative_value_bar_id { get; set; }
            [Index (13)] public virtual string unknown_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string catch_effectiveness { get; set; }
            [Index (1)] public virtual string unit_name { get; set; }
            [Index (2)] public virtual string effective_value { get; set; }
            [Index (3)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN28 - Tutorial Camp Panel Data
    [ZeroFormattable]
    public class TutorialCampPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string activity_button_background_id { get; set; }
            [Index (2)] public virtual string activity_icon_id { get; set; }
            [Index (3)] public virtual string change_location_button_background_id { get; set; }
            [Index (4)] public virtual string change_location_icon_id { get; set; }
            [Index (5)] public virtual string hunt_button_background_id { get; set; }
            [Index (6)] public virtual string hunt_icon_id { get; set; }
            [Index (7)] public virtual string effectiveness_button_background_id { get; set; }
            [Index (8)] public virtual string effectiveness_icon_id { get; set; }
            [Index (9)] public virtual string history_button_background_id { get; set; }
            [Index (10)] public virtual string history_icon_id { get; set; }
            [Index (11)] public virtual string slot_1_background_id { get; set; }
            [Index (12)] public virtual string slot_1_notification_id { get; set; }
            [Index (13)] public virtual string lethal_icon_id { get; set; }
            [Index (14)] public virtual string extra_lethal_icon_id { get; set; }
            [Index (15)] public virtual string fairy_button_background_id { get; set; }
            [Index (16)] public virtual string fairy_food_button_background_id { get; set; }
            [Index (17)] public virtual string crystal_button_background_id { get; set; }
            [Index (18)] public virtual string bait_button_background_id { get; set; }
            [Index (19)] public virtual string flavour_button_background_id { get; set; }
            [Index (20)] public virtual string weapon_button_background_id { get; set; }
            [Index (21)] public virtual string ammo_button_background_id { get; set; }
            [Index (22)] public virtual string accessory_1_button_background_id { get; set; }
            [Index (23)] public virtual string accessory_2_button_background_id { get; set; }
            [Index (24)] public virtual string accessory_3_button_background_id { get; set; }
            [Index (25)] public virtual string quantity_background_id { get; set; }
            [Index (26)] public virtual string trap_stats_background_id { get; set; }
            [Index (27)] public virtual string strength_icon_id { get; set; }
            [Index (28)] public virtual string luck_icon_id { get; set; }
            [Index (29)] public virtual string cage_icon_id { get; set; }
            [Index (30)] public virtual string energy_icon_id { get; set; }
            [Index (31)] public virtual string energy_bar_background_id { get; set; }
            [Index (32)] public virtual string energy_bar_id { get; set; }
            [Index (33)] public virtual string rage_icon_id { get; set; }
            [Index (34)] public virtual string rage_bar_background_id { get; set; }
            [Index (35)] public virtual string rage_bar_id { get; set; }
            [Index (36)] public virtual string fairy_level_background_id { get; set; }
            [Index (37)] public virtual string fairy_level_bar_background_id { get; set; }
            [Index (38)] public virtual string fairy_level_bar_id { get; set; }
            [Index (39)] public virtual string fairy_rarity_id { get; set; }
            [Index (40)] public virtual string selected_slot_highlight { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string camp_title { get; set; }
            [Index (1)] public virtual string activity_button { get; set; }
            [Index (2)] public virtual string change_location_button { get; set; }
            [Index (3)] public virtual string hunt_button { get; set; }
            [Index (4)] public virtual string effectiveness_button { get; set; }
            [Index (5)] public virtual string history_button { get; set; }
            [Index (6)] public virtual string slot { get; set; }
            [Index (7)] public virtual string slot_1_button { get; set; }
            [Index (8)] public virtual string no_fairy { get; set; }
            [Index (9)] public virtual string no_fairy_food { get; set; }
            [Index (10)] public virtual string fairy_food_quantity { get; set; }
            [Index (11)] public virtual string no_crystal { get; set; }
            [Index (12)] public virtual string crystal_quantity { get; set; }
            [Index (13)] public virtual string no_bait { get; set; }
            [Index (14)] public virtual string bait_quantity { get; set; }
            [Index (15)] public virtual string no_flavour { get; set; }
            [Index (16)] public virtual string flavour_quantity { get; set; }
            [Index (17)] public virtual string no_weapon { get; set; }
            [Index (18)] public virtual string no_ammo { get; set; }
            [Index (19)] public virtual string ammo_quantity { get; set; }
            [Index (20)] public virtual string quantity_low { get; set; }
            [Index (21)] public virtual string no_accessory_1 { get; set; }
            [Index (22)] public virtual string no_accessory_2 { get; set; }
            [Index (23)] public virtual string no_accessory_3 { get; set; }
            [Index (24)] public virtual string strength { get; set; }
            [Index (25)] public virtual string luck { get; set; }
            [Index (26)] public virtual string cage { get; set; }
            [Index (27)] public virtual string energy { get; set; }
            [Index (28)] public virtual string rage { get; set; }
            [Index (29)] public virtual string fairy_level { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN29 - Tutorial Hunt Result Panel Data
    [ZeroFormattable]
    public class TutorialHuntResultPanelData : BaseData
    {
        [ZeroFormattable]
        public class RewardMaterial
        {
            [Index (0)] public virtual string coin_id { get; set; }
            [Index (1)] public virtual string reputation_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string inactive_midground_id { get; set; }
            [Index (3)] public virtual string detail_background_id { get; set; }
            [Index (4)] public virtual string detail_foreground_id { get; set; }
            [Index (5)] public virtual string lethal_icon_id { get; set; }
            [Index (6)] public virtual string attract_failed_icon_id { get; set; }
            [Index (7)] public virtual string catch_success_icon_id { get; set; }
            [Index (8)] public virtual string location_background_id { get; set; }
            [Index (9)] public virtual string hunt_bug_background_id { get; set; }
            [Index (10)] public virtual string fairy_background_id { get; set; }
            [Index (11)] public virtual string fairy_food_background_id { get; set; }
            [Index (12)] public virtual string crystal_background_id { get; set; }
            [Index (13)] public virtual string bait_background_id { get; set; }
            [Index (14)] public virtual string flavour_background_id { get; set; }
            [Index (15)] public virtual string weapon_background_id { get; set; }
            [Index (16)] public virtual string ammo_background_id { get; set; }
            [Index (17)] public virtual string accessory_1_background_id { get; set; }
            [Index (18)] public virtual string accessory_2_background_id { get; set; }
            [Index (19)] public virtual string accessory_3_background_id { get; set; }
            [Index (20)] public virtual string rage_icon_id { get; set; }
            [Index (21)] public virtual string rage_bar_background_id { get; set; }
            [Index (22)] public virtual string rage_bar_id { get; set; }
            [Index (23)] public virtual string trade_button_background_id { get; set; }
            [Index (24)] public virtual string trade_icon_id { get; set; }
            [Index (25)] public virtual string size_icon_id { get; set; }
            [Index (26)] public virtual string royal_icon_id { get; set; }
            [Index (27)] public virtual string summary_bug_background_id { get; set; }
            [Index (28)] public virtual string scroll_view_background_id { get; set; }
            [Index (29)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (30)] public virtual string scroll_view_handler_id { get; set; }
            [Index (31)] public virtual string summary_slot_background_id { get; set; }
            [Index (32)] public virtual string summary_next_slot_gap_id { get; set; }
            [Index (33)] public virtual string summary_message_background_id { get; set; }
            [Index (34)] public virtual string summary_message_bottom_seperator_id { get; set; }
            [Index (35)] public virtual string catch_alive_background_id { get; set; }
            [Index (36)] public virtual string catch_alive_bottom_seperator_id { get; set; }
            [Index (37)] public virtual string catch_death_background_id { get; set; }
            [Index (38)] public virtual string catch_death_bottom_seperator_id { get; set; }
            [Index (39)] public virtual string catch_failed_background_id { get; set; }
            [Index (40)] public virtual string catch_failed_bottom_seperator_id { get; set; }
            [Index (41)] public virtual string attract_failed_background_id { get; set; }
            [Index (42)] public virtual string attract_failed_bottom_seperator_id { get; set; }
            [Index (43)] public virtual string not_equip_icon { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string hunt_slot { get; set; }
            [Index (1)] public virtual string summary { get; set; }
            [Index (2)] public virtual string rage { get; set; }
            [Index (3)] public virtual string trade_button { get; set; }
            [Index (4)] public virtual string summary_slot { get; set; }
            [Index (5)] public virtual string summary_bug_name { get; set; }
            [Index (6)] public virtual string size { get; set; }
            [Index (7)] public virtual string reward { get; set; }
            [Index (8)] public virtual string reward_name { get; set; }
            [Index (9)] public virtual string date { get; set; }
            [Index (10)] public virtual string message { get; set; }
            [Index (11)] public virtual string bug_portrait_bug_name { get; set; }
        }
        [Index (1)] public virtual RewardMaterial reward_material { get; set; }
        [Index (2)] public virtual UiSprite ui_sprite { get; set; }
        [Index (3)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN30 - Tutorial Change Location Panel Data
    [ZeroFormattable]
    public class TutorialChangeLocationPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string select_icon_id { get; set; }
            [Index (6)] public virtual string location_selection_background_id { get; set; }
            [Index (7)] public virtual string location_selection_seperator_id { get; set; }
            [Index (8)] public virtual string location_selection_location_background_id { get; set; }
            [Index (9)] public virtual string location_selection_select_button_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string title { get; set; }
            [Index (1)] public virtual string location_selection_location { get; set; }
            [Index (2)] public virtual string location_selection_occupy_by { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN31 - Warehouse Panel Data
    [ZeroFormattable]
    public class WarehousePanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string material_claim_background_id { get; set; }
            [Index (6)] public virtual string claim_timer_bar_background_id { get; set; }
            [Index (7)] public virtual string next_claim_timer_bar_id { get; set; }
            [Index (8)] public virtual string full_claim_timer_bar_id { get; set; }
            [Index (9)] public virtual string container_back_id { get; set; }
            [Index (10)] public virtual string container_front_id { get; set; }
            [Index (11)] public virtual string first_separator_id { get; set; }
            [Index (12)] public virtual string info_button_background_id { get; set; }
            [Index (13)] public virtual string claim_button_background_id { get; set; }
            [Index (14)] public virtual string claim_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string warehouse { get; set; }
            [Index (1)] public virtual string free_claim { get; set; }
            [Index (2)] public virtual string material_claim_quantity { get; set; }
            [Index (3)] public virtual string claim_timer { get; set; }
            [Index (4)] public virtual string claim_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN32 - Reward Summary Panel Data
    [ZeroFormattable]
    public class RewardSummaryPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string close_button_background_id { get; set; }
            [Index (6)] public virtual string close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string title { get; set; }
            [Index (1)] public virtual string fairy_food { get; set; }
            [Index (2)] public virtual string bait { get; set; }
            [Index (3)] public virtual string flavour { get; set; }
            [Index (4)] public virtual string ammo { get; set; }
            [Index (5)] public virtual string material { get; set; }
            [Index (6)] public virtual string item_name { get; set; }
            [Index (7)] public virtual string quantity { get; set; }
            [Index (8)] public virtual string close_button { get; set; }
            [Index (9)] public virtual string no_info { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN33 - Level Up Panel
    [ZeroFormattable]
    public class LevelUpPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string new_rank_effect_id { get; set; }
            [Index (2)] public virtual string rank_to_id { get; set; }
            [Index (3)] public virtual string scroll_view_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_id { get; set; }
            [Index (6)] public virtual string close_button_background_id { get; set; }
            [Index (7)] public virtual string close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string congrat { get; set; }
            [Index (1)] public virtual string message { get; set; }
            [Index (2)] public virtual string old_rank { get; set; }
            [Index (3)] public virtual string new_rank { get; set; }
            [Index (4)] public virtual string item_unlock { get; set; }
            [Index (5)] public virtual string weapon { get; set; }
            [Index (6)] public virtual string crystal { get; set; }
            [Index (7)] public virtual string accessory { get; set; }
            [Index (8)] public virtual string item_name { get; set; }
            [Index (9)] public virtual string close_button { get; set; }
            [Index (10)] public virtual string no_info { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN34 - Smith Panel Data
    [ZeroFormattable]
    public class SmithPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string weapon_button_background_id { get; set; }
            [Index (6)] public virtual string elemental_button_background_id { get; set; }
            [Index (7)] public virtual string selected_search_elemental_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string smith { get; set; }
            [Index (1)] public virtual string weapon_name { get; set; }
            [Index (2)] public virtual string cost { get; set; }
            [Index (3)] public virtual string no_weapon { get; set; }
        }
        [Index (1)] public virtual string intro_id { get; set; }
        [Index (2)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN35 - Smith Purchase Panel Data
    [ZeroFormattable]
    public class SmithPurchasePanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual string position_LR { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string purchase_button_background_id { get; set; }
            [Index (3)] public virtual string purchase_icon_id { get; set; }
            [Index (4)] public virtual string close_button_background_id { get; set; }
            [Index (5)] public virtual string close_icon_id { get; set; }
            [Index (6)] public virtual string next_weapon_button_background_id { get; set; }
            [Index (7)] public virtual string next_weapon_icon_id { get; set; }
            [Index (8)] public virtual string previous_weapon_button_background_id { get; set; }
            [Index (9)] public virtual string previous_weapon_icon_id { get; set; }
            [Index (10)] public virtual string info_button_background_id { get; set; }
            [Index (11)] public virtual string scroll_view_background_id { get; set; }
            [Index (12)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (13)] public virtual string scroll_view_handler_id { get; set; }
            [Index (14)] public virtual string thumbnail_background_id { get; set; }
            [Index (15)] public virtual string elemental_icon_id { get; set; }
            [Index (16)] public virtual string strength_icon_id { get; set; }
            [Index (17)] public virtual string owned_icon_id { get; set; }
            [Index (18)] public virtual string purchase_success_background_id { get; set; }
            [Index (19)] public virtual string purchase_success_midground_id { get; set; }
            [Index (20)] public virtual string purchase_success_dialogue_background_id { get; set; }
            [Index (21)] public virtual string purchase_success_weapon_thumbnail_background_id { get; set; }
            [Index (22)] public virtual string purchase_success_close_button_background_id { get; set; }
            [Index (23)] public virtual string purchase_success_close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string weapon_name { get; set; }
            [Index (1)] public virtual string elemental { get; set; }
            [Index (2)] public virtual string strength { get; set; }
            [Index (3)] public virtual string owned { get; set; }
            [Index (4)] public virtual string base_weapon_require { get; set; }
            [Index (5)] public virtual string base_weapon_name { get; set; }
            [Index (6)] public virtual string used_by { get; set; }
            [Index (7)] public virtual string no_base_weapon_require { get; set; }
            [Index (8)] public virtual string material_require { get; set; }
            [Index (9)] public virtual string no_material_require { get; set; }
            [Index (10)] public virtual string material_name { get; set; }
            [Index (11)] public virtual string material_quantity { get; set; }
            [Index (12)] public virtual string material_sufficient { get; set; }
            [Index (13)] public virtual string material_insufficient { get; set; }
            [Index (14)] public virtual string coin_name { get; set; }
            [Index (15)] public virtual string coin_available { get; set; }
            [Index (16)] public virtual string cannot_purchase_message { get; set; }
            [Index (17)] public virtual string purchase_button { get; set; }
            [Index (18)] public virtual string close_button { get; set; }
            [Index (19)] public virtual string purchase_success { get; set; }
            [Index (20)] public virtual string dialogue { get; set; }
            [Index (21)] public virtual string purchase_success_weapon_name { get; set; }
            [Index (22)] public virtual string purchase_success_close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual Dialogue dialogue { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN36 - Ammo Dealer Weapon Panel Data
    [ZeroFormattable]
    public class AmmoDealerWeaponPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string weapon_button_background_id { get; set; }
            [Index (6)] public virtual string addition_ammo_id { get; set; }
            [Index (7)] public virtual string elemental_button_background_id { get; set; }
            [Index (8)] public virtual string selected_search_elemental_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string ammo_dealer { get; set; }
            [Index (1)] public virtual string weapon_name { get; set; }
            [Index (2)] public virtual string no_weapon { get; set; }
        }
        [Index (1)] public virtual string intro_id { get; set; }
        [Index (2)] public virtual UiSprite ui_sprite { get; set; }
        [Index (3)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN37 - Ammo Dealer Ammo Panel Data
    [ZeroFormattable]
    public class AmmoDealerAmmoPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string ammo_button_background_id { get; set; }
            [Index (5)] public virtual string back_button_background_id { get; set; }
            [Index (6)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string ammo_dealer { get; set; }
            [Index (1)] public virtual string ammo_name { get; set; }
            [Index (2)] public virtual string cost { get; set; }
            [Index (3)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual UiSprite ui_sprite { get; set; }
        [Index (3)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN38 - Ammo Dealer Purchase Panel Data
    [ZeroFormattable]
    public class AmmoDealerPurchasePanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual string position_LR { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string purchase_button_background_id { get; set; }
            [Index (3)] public virtual string purchase_icon_id { get; set; }
            [Index (4)] public virtual string quantity_switch_button_background_id { get; set; }
            [Index (5)] public virtual string quantity_switch_icon_id { get; set; }
            [Index (6)] public virtual string close_button_background_id { get; set; }
            [Index (7)] public virtual string close_icon_id { get; set; }
            [Index (8)] public virtual string info_button_background_id { get; set; }
            [Index (9)] public virtual string scroll_view_background_id { get; set; }
            [Index (10)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (11)] public virtual string scroll_view_handler_id { get; set; }
            [Index (12)] public virtual string thumbnail_background_id { get; set; }
            [Index (13)] public virtual string lethal_icon_id { get; set; }
            [Index (14)] public virtual string extra_lethal_icon_id { get; set; }
            [Index (15)] public virtual string strength_bonus_icon_id { get; set; }
            [Index (16)] public virtual string death_icon_id { get; set; }
            [Index (17)] public virtual string owned_icon_id { get; set; }
            [Index (18)] public virtual string quantity_slide_bar_background_id { get; set; }
            [Index (19)] public virtual string quantity_slide_bar_id { get; set; }
            [Index (20)] public virtual string quantity_slide_bar_handler_id { get; set; }
            [Index (21)] public virtual string quantity_input_background_id { get; set; }
            [Index (22)] public virtual string purchase_success_background_id { get; set; }
            [Index (23)] public virtual string purchase_success_midground_id { get; set; }
            [Index (24)] public virtual string purchase_success_dialogue_background_id { get; set; }
            [Index (25)] public virtual string purchase_success_ammo_thumbnail_background_id { get; set; }
            [Index (26)] public virtual string purchase_success_owned_quantity_to_id { get; set; }
            [Index (27)] public virtual string purchase_success_free_ammo_icon_id { get; set; }
            [Index (28)] public virtual string purchase_success_close_button_background_id { get; set; }
            [Index (29)] public virtual string purchase_success_close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string ammo_name { get; set; }
            [Index (1)] public virtual string strength_bonus { get; set; }
            [Index (2)] public virtual string lethal { get; set; }
            [Index (3)] public virtual string owned { get; set; }
            [Index (4)] public virtual string material_require { get; set; }
            [Index (5)] public virtual string no_material_require { get; set; }
            [Index (6)] public virtual string material_name { get; set; }
            [Index (7)] public virtual string material_quantity { get; set; }
            [Index (8)] public virtual string material_sufficient { get; set; }
            [Index (9)] public virtual string material_insufficient { get; set; }
            [Index (10)] public virtual string quantity { get; set; }
            [Index (11)] public virtual string quantity_prompt { get; set; }
            [Index (12)] public virtual string quantity_input { get; set; }
            [Index (13)] public virtual string quantity_available { get; set; }
            [Index (14)] public virtual string slide_bar_quantity { get; set; }
            [Index (15)] public virtual string coin_name { get; set; }
            [Index (16)] public virtual string coin_available { get; set; }
            [Index (17)] public virtual string purchase_quantity { get; set; }
            [Index (18)] public virtual string cannot_purchase_message { get; set; }
            [Index (19)] public virtual string purchase_button { get; set; }
            [Index (20)] public virtual string close_button { get; set; }
            [Index (21)] public virtual string purchase_success { get; set; }
            [Index (22)] public virtual string dialogue { get; set; }
            [Index (23)] public virtual string purchase_success_ammo_name { get; set; }
            [Index (24)] public virtual string purchase_success_owned { get; set; }
            [Index (25)] public virtual string purchase_success_owned_old_quantity { get; set; }
            [Index (26)] public virtual string purchase_success_owned_new_quantity { get; set; }
            [Index (27)] public virtual string purchase_success_purchase_quantity { get; set; }
            [Index (28)] public virtual string purchase_success_free_quantity { get; set; }
            [Index (29)] public virtual string purchase_success_close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual Dialogue dialogue { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN39 - Fairy Bakery Panel Data
    [ZeroFormattable]
    public class FairyBakeryPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string fairy_food_button_background_id { get; set; }
            [Index (6)] public virtual string discount_background_id { get; set; }
            [Index (7)] public virtual string discount_slash_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string fairy_bakery { get; set; }
            [Index (1)] public virtual string fairy_food_name { get; set; }
            [Index (2)] public virtual string origin_cost { get; set; }
            [Index (3)] public virtual string discount_value { get; set; }
            [Index (4)] public virtual string discounted_cost { get; set; }
        }
        [Index (1)] public virtual string before_gift_intro_id { get; set; }
        [Index (2)] public virtual string after_gift_intro_id { get; set; }
        [Index (3)] public virtual string low_fairy_food_dialogue_id { get; set; }
        [Index (4)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (5)] public virtual UiSprite ui_sprite { get; set; }
        [Index (6)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN40 - Fairy Bakery Purchase Panel Data
    [ZeroFormattable]
    public class FairyBakeryPurchasePanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual string position_LR { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string purchase_button_background_id { get; set; }
            [Index (3)] public virtual string purchase_icon_id { get; set; }
            [Index (4)] public virtual string quantity_switch_button_background_id { get; set; }
            [Index (5)] public virtual string quantity_switch_icon_id { get; set; }
            [Index (6)] public virtual string close_button_background_id { get; set; }
            [Index (7)] public virtual string close_icon_id { get; set; }
            [Index (8)] public virtual string info_button_background_id { get; set; }
            [Index (9)] public virtual string scroll_view_background_id { get; set; }
            [Index (10)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (11)] public virtual string scroll_view_handler_id { get; set; }
            [Index (12)] public virtual string thumbnail_background_id { get; set; }
            [Index (13)] public virtual string owned_icon_id { get; set; }
            [Index (14)] public virtual string quantity_slide_bar_background_id { get; set; }
            [Index (15)] public virtual string quantity_slide_bar_id { get; set; }
            [Index (16)] public virtual string quantity_slide_bar_handler_id { get; set; }
            [Index (17)] public virtual string quantity_input_background_id { get; set; }
            [Index (18)] public virtual string purchase_success_background_id { get; set; }
            [Index (19)] public virtual string purchase_success_midground_id { get; set; }
            [Index (20)] public virtual string purchase_success_dialogue_background_id { get; set; }
            [Index (21)] public virtual string purchase_success_fairy_food_thumbnail_background_id { get; set; }
            [Index (22)] public virtual string purchase_success_owned_quantity_to_id { get; set; }
            [Index (23)] public virtual string purchase_success_close_button_background_id { get; set; }
            [Index (24)] public virtual string purchase_success_close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string fairy_food_name { get; set; }
            [Index (1)] public virtual string owned { get; set; }
            [Index (2)] public virtual string material_require { get; set; }
            [Index (3)] public virtual string no_material_require { get; set; }
            [Index (4)] public virtual string material_name { get; set; }
            [Index (5)] public virtual string material_quantity { get; set; }
            [Index (6)] public virtual string material_sufficient { get; set; }
            [Index (7)] public virtual string material_insufficient { get; set; }
            [Index (8)] public virtual string quantity { get; set; }
            [Index (9)] public virtual string quantity_prompt { get; set; }
            [Index (10)] public virtual string quantity_input { get; set; }
            [Index (11)] public virtual string quantity_available { get; set; }
            [Index (12)] public virtual string slide_bar_quantity { get; set; }
            [Index (13)] public virtual string coin_name { get; set; }
            [Index (14)] public virtual string coin_available { get; set; }
            [Index (15)] public virtual string purchase_quantity { get; set; }
            [Index (16)] public virtual string cannot_purchase_message { get; set; }
            [Index (17)] public virtual string purchase_button { get; set; }
            [Index (18)] public virtual string close_button { get; set; }
            [Index (19)] public virtual string purchase_success { get; set; }
            [Index (20)] public virtual string dialogue { get; set; }
            [Index (21)] public virtual string purchase_success_fairy_food_name { get; set; }
            [Index (22)] public virtual string purchase_success_owned { get; set; }
            [Index (23)] public virtual string purchase_success_owned_old_quantity { get; set; }
            [Index (24)] public virtual string purchase_success_owned_new_quantity { get; set; }
            [Index (25)] public virtual string purchase_success_purchase_quantity { get; set; }
            [Index (26)] public virtual string purchase_success_close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual Dialogue dialogue { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN41 - Cage Master Panel Data
    [ZeroFormattable]
    public class CageMasterPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string slot_1_button_background_id { get; set; }
            [Index (6)] public virtual string slot_2_button_background_id { get; set; }
            [Index (7)] public virtual string slot_3_button_background_id { get; set; }
            [Index (8)] public virtual string slot_4_button_background_id { get; set; }
            [Index (9)] public virtual string slot_5_button_background_id { get; set; }
            [Index (10)] public virtual string slot_6_button_background_id { get; set; }
            [Index (11)] public virtual string cage_icon_id { get; set; }
            [Index (12)] public virtual string slot_select_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string cage_master { get; set; }
            [Index (1)] public virtual string slot { get; set; }
            [Index (2)] public virtual string cage { get; set; }
        }
        [Index (1)] public virtual string intro_id { get; set; }
        [Index (2)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN42 - Cage Master Purchase Panel Data
    [ZeroFormattable]
    public class CageMasterPurchasePanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual string position_LR { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string purchase_button_background_id { get; set; }
            [Index (3)] public virtual string purchase_icon_id { get; set; }
            [Index (4)] public virtual string close_button_background_id { get; set; }
            [Index (5)] public virtual string close_icon_id { get; set; }
            [Index (6)] public virtual string info_button_background_id { get; set; }
            [Index (7)] public virtual string scroll_view_background_id { get; set; }
            [Index (8)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (9)] public virtual string scroll_view_handler_id { get; set; }
            [Index (10)] public virtual string thumbnail_background_id { get; set; }
            [Index (11)] public virtual string cage_icon_id { get; set; }
            [Index (12)] public virtual string owned_icon_id { get; set; }
            [Index (13)] public virtual string purchase_success_background_id { get; set; }
            [Index (14)] public virtual string purchase_success_midground_id { get; set; }
            [Index (15)] public virtual string purchase_success_dialogue_background_id { get; set; }
            [Index (16)] public virtual string purchase_success_cage_thumbnail_background_id { get; set; }
            [Index (17)] public virtual string purchase_success_owned_quantity_to_id { get; set; }
            [Index (18)] public virtual string purchase_success_close_button_background_id { get; set; }
            [Index (19)] public virtual string purchase_success_close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string cage_name { get; set; }
            [Index (1)] public virtual string owned { get; set; }
            [Index (2)] public virtual string material_require { get; set; }
            [Index (3)] public virtual string no_material_require { get; set; }
            [Index (4)] public virtual string material_name { get; set; }
            [Index (5)] public virtual string material_quantity { get; set; }
            [Index (6)] public virtual string material_sufficient { get; set; }
            [Index (7)] public virtual string material_insufficient { get; set; }
            [Index (8)] public virtual string coin_name { get; set; }
            [Index (9)] public virtual string coin_available { get; set; }
            [Index (10)] public virtual string cannot_purchase_message { get; set; }
            [Index (11)] public virtual string purchase_button { get; set; }
            [Index (12)] public virtual string close_button { get; set; }
            [Index (13)] public virtual string purchase_success { get; set; }
            [Index (14)] public virtual string dialogue { get; set; }
            [Index (15)] public virtual string purchase_success_cage_name { get; set; }
            [Index (16)] public virtual string purchase_success_owned { get; set; }
            [Index (17)] public virtual string purchase_success_owned_old_quantity { get; set; }
            [Index (18)] public virtual string purchase_success_owned_new_quantity { get; set; }
            [Index (19)] public virtual string purchase_success_close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual Dialogue dialogue { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN43 - Inventory Category Panel Data
    [ZeroFormattable]
    public class InventoryCategoryPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string fairy_food_background_id { get; set; }
            [Index (3)] public virtual string fairy_food_icon_id { get; set; }
            [Index (4)] public virtual string weapon_background_id { get; set; }
            [Index (5)] public virtual string weapon_icon_id { get; set; }
            [Index (6)] public virtual string ammo_background_id { get; set; }
            [Index (7)] public virtual string ammo_icon_id { get; set; }
            [Index (8)] public virtual string bait_background_id { get; set; }
            [Index (9)] public virtual string bait_icon_id { get; set; }
            [Index (10)] public virtual string flavour_background_id { get; set; }
            [Index (11)] public virtual string flavour_icon_id { get; set; }
            [Index (12)] public virtual string crystal_background_id { get; set; }
            [Index (13)] public virtual string crystal_icon_id { get; set; }
            [Index (14)] public virtual string accessory_background_id { get; set; }
            [Index (15)] public virtual string accessory_icon_id { get; set; }
            [Index (16)] public virtual string material_background_id { get; set; }
            [Index (17)] public virtual string material_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string inventory { get; set; }
            [Index (1)] public virtual string fairy_food { get; set; }
            [Index (2)] public virtual string weapon { get; set; }
            [Index (3)] public virtual string ammo { get; set; }
            [Index (4)] public virtual string bait { get; set; }
            [Index (5)] public virtual string flavour { get; set; }
            [Index (6)] public virtual string crystal { get; set; }
            [Index (7)] public virtual string accessory { get; set; }
            [Index (8)] public virtual string material { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN44 - Inventory Panel Data
    [ZeroFormattable]
    public class InventoryPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string search_input_background_id { get; set; }
            [Index (6)] public virtual string search_button_background_id { get; set; }
            [Index (7)] public virtual string search_icon_id { get; set; }
            [Index (8)] public virtual string filter_type_background_id { get; set; }
            [Index (9)] public virtual string filter_all_icon_id { get; set; }
            [Index (10)] public virtual string filter_general_icon_id { get; set; }
            [Index (11)] public virtual string filter_currency_icon_id { get; set; }
            [Index (12)] public virtual string filter_key_item_icon_id { get; set; }
            [Index (13)] public virtual string filter_fairy_awaken_item_icon_id { get; set; }
            [Index (14)] public virtual string filter_resources_icon_id { get; set; }
            [Index (15)] public virtual string filter_activity_item_icon_id { get; set; }
            [Index (16)] public virtual string selected_filter_type_icon_id { get; set; }
            [Index (17)] public virtual string search_seperator_id { get; set; }
            [Index (18)] public virtual string sort_button_background_id { get; set; }
            [Index (19)] public virtual string sort_icon_id { get; set; }
            [Index (20)] public virtual string close_button_background_id { get; set; }
            [Index (21)] public virtual string close_icon_id { get; set; }
            [Index (22)] public virtual string info_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string title { get; set; }
            [Index (1)] public virtual string search_prompt { get; set; }
            [Index (2)] public virtual string search_input { get; set; }
            [Index (3)] public virtual string search_button { get; set; }
            [Index (4)] public virtual string filter { get; set; }
            [Index (5)] public virtual string close_button { get; set; }
            [Index (6)] public virtual string sort_button { get; set; }
            [Index (7)] public virtual string type_header { get; set; }
            [Index (8)] public virtual string material { get; set; }
            [Index (9)] public virtual string quantity { get; set; }
            [Index (10)] public virtual string no_info { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN45 - Material Detail Panel Data
    [ZeroFormattable]
    public class MaterialDetailPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string info_icon_id { get; set; }
            [Index (6)] public virtual string close_button_background_id { get; set; }
            [Index (7)] public virtual string close_icon_id { get; set; }
            [Index (8)] public virtual string food_stall_icon_id { get; set; }
            [Index (9)] public virtual string smith_icon_id { get; set; }
            [Index (10)] public virtual string ammo_dealer_icon_id { get; set; }
            [Index (11)] public virtual string fairy_bakery_icon_id { get; set; }
            [Index (12)] public virtual string material_craft_icon_id { get; set; }
            [Index (13)] public virtual string crystal_lab_icon_id { get; set; }
            [Index (14)] public virtual string accessory_maker_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string title { get; set; }
            [Index (1)] public virtual string purchase_craft_at { get; set; }
            [Index (2)] public virtual string craft_material { get; set; }
            [Index (3)] public virtual string use_to_craft { get; set; }
            [Index (4)] public virtual string fairy_awaken { get; set; }
            [Index (5)] public virtual string loot_at { get; set; }
            [Index (6)] public virtual string item_name { get; set; }
            [Index (7)] public virtual string quantity { get; set; }
            [Index (8)] public virtual string no_info { get; set; }
            [Index (9)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN46 - Craftsman Panel Data
    [ZeroFormattable]
    public class CraftsmanPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string search_input_background_id { get; set; }
            [Index (6)] public virtual string search_button_background_id { get; set; }
            [Index (7)] public virtual string search_icon_id { get; set; }
            [Index (8)] public virtual string material_button_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string craftsman { get; set; }
            [Index (1)] public virtual string material { get; set; }
            [Index (2)] public virtual string cost { get; set; }
            [Index (3)] public virtual string search_prompt { get; set; }
            [Index (4)] public virtual string search_input { get; set; }
            [Index (5)] public virtual string search_button { get; set; }
            [Index (6)] public virtual string no_material { get; set; }
        }
        [Index (1)] public virtual string intro_id { get; set; }
        [Index (2)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN47 - Craftsman Purchase Panel Data
    [ZeroFormattable]
    public class CraftsmanPurchasePanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual string position_LR { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string purchase_button_background_id { get; set; }
            [Index (3)] public virtual string purchase_icon_id { get; set; }
            [Index (4)] public virtual string quantity_switch_button_background_id { get; set; }
            [Index (5)] public virtual string quantity_switch_icon_id { get; set; }
            [Index (6)] public virtual string close_button_background_id { get; set; }
            [Index (7)] public virtual string close_icon_id { get; set; }
            [Index (8)] public virtual string info_button_background_id { get; set; }
            [Index (9)] public virtual string scroll_view_background_id { get; set; }
            [Index (10)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (11)] public virtual string scroll_view_handler_id { get; set; }
            [Index (12)] public virtual string thumbnail_background_id { get; set; }
            [Index (13)] public virtual string owned_icon_id { get; set; }
            [Index (14)] public virtual string quantity_slide_bar_background_id { get; set; }
            [Index (15)] public virtual string quantity_slide_bar_id { get; set; }
            [Index (16)] public virtual string quantity_slide_bar_handler_id { get; set; }
            [Index (17)] public virtual string quantity_input_background_id { get; set; }
            [Index (18)] public virtual string purchase_success_background_id { get; set; }
            [Index (19)] public virtual string purchase_success_midground_id { get; set; }
            [Index (20)] public virtual string purchase_success_dialogue_background_id { get; set; }
            [Index (21)] public virtual string purchase_success_material_thumbnail_background_id { get; set; }
            [Index (22)] public virtual string purchase_success_owned_quantity_to_id { get; set; }
            [Index (23)] public virtual string purchase_success_close_button_background_id { get; set; }
            [Index (24)] public virtual string purchase_success_close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string material_name { get; set; }
            [Index (1)] public virtual string owned { get; set; }
            [Index (2)] public virtual string material_require { get; set; }
            [Index (3)] public virtual string no_material_require { get; set; }
            [Index (4)] public virtual string craft_material_name { get; set; }
            [Index (5)] public virtual string craft_material_quantity { get; set; }
            [Index (6)] public virtual string craft_material_sufficient { get; set; }
            [Index (7)] public virtual string craft_material_insufficient { get; set; }
            [Index (8)] public virtual string quantity { get; set; }
            [Index (9)] public virtual string quantity_prompt { get; set; }
            [Index (10)] public virtual string quantity_input { get; set; }
            [Index (11)] public virtual string quantity_available { get; set; }
            [Index (12)] public virtual string slide_bar_quantity { get; set; }
            [Index (13)] public virtual string coin_name { get; set; }
            [Index (14)] public virtual string coin_available { get; set; }
            [Index (15)] public virtual string purchase_quantity { get; set; }
            [Index (16)] public virtual string cannot_purchase_message { get; set; }
            [Index (17)] public virtual string purchase_button { get; set; }
            [Index (18)] public virtual string close_button { get; set; }
            [Index (19)] public virtual string purchase_success { get; set; }
            [Index (20)] public virtual string dialogue { get; set; }
            [Index (21)] public virtual string purchase_success_material_name { get; set; }
            [Index (22)] public virtual string purchase_success_owned { get; set; }
            [Index (23)] public virtual string purchase_success_owned_old_quantity { get; set; }
            [Index (24)] public virtual string purchase_success_owned_new_quantity { get; set; }
            [Index (25)] public virtual string purchase_success_purchase_quantity { get; set; }
            [Index (26)] public virtual string purchase_success_close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual Dialogue dialogue { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN48 - Crystal Lab Panel Data
    [ZeroFormattable]
    public class CrystalLabPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string search_input_background_id { get; set; }
            [Index (6)] public virtual string search_button_background_id { get; set; }
            [Index (7)] public virtual string search_icon_id { get; set; }
            [Index (8)] public virtual string material_button_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string crystal_lab { get; set; }
            [Index (1)] public virtual string crystal { get; set; }
            [Index (2)] public virtual string cost { get; set; }
            [Index (3)] public virtual string search_prompt { get; set; }
            [Index (4)] public virtual string search_input { get; set; }
            [Index (5)] public virtual string search_button { get; set; }
            [Index (6)] public virtual string no_crystal { get; set; }
        }
        [Index (1)] public virtual string intro_id { get; set; }
        [Index (2)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN49 - Crystal Lab Purchase Panel Data
    [ZeroFormattable]
    public class CrystalLabPurchasePanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual string position_LR { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string purchase_button_background_id { get; set; }
            [Index (3)] public virtual string purchase_icon_id { get; set; }
            [Index (4)] public virtual string quantity_switch_button_background_id { get; set; }
            [Index (5)] public virtual string quantity_switch_icon_id { get; set; }
            [Index (6)] public virtual string next_effect_button_background_id { get; set; }
            [Index (7)] public virtual string next_effect_icon_id { get; set; }
            [Index (8)] public virtual string previous_effect_button_background_id { get; set; }
            [Index (9)] public virtual string previous_effect_icon_id { get; set; }
            [Index (10)] public virtual string close_button_background_id { get; set; }
            [Index (11)] public virtual string close_icon_id { get; set; }
            [Index (12)] public virtual string info_button_background_id { get; set; }
            [Index (13)] public virtual string scroll_view_background_id { get; set; }
            [Index (14)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (15)] public virtual string scroll_view_handler_id { get; set; }
            [Index (16)] public virtual string thumbnail_background_id { get; set; }
            [Index (17)] public virtual string owned_icon_id { get; set; }
            [Index (18)] public virtual string quantity_slide_bar_background_id { get; set; }
            [Index (19)] public virtual string quantity_slide_bar_id { get; set; }
            [Index (20)] public virtual string quantity_slide_bar_handler_id { get; set; }
            [Index (21)] public virtual string quantity_input_background_id { get; set; }
            [Index (22)] public virtual string purchase_success_background_id { get; set; }
            [Index (23)] public virtual string purchase_success_midground_id { get; set; }
            [Index (24)] public virtual string purchase_success_dialogue_background_id { get; set; }
            [Index (25)] public virtual string purchase_success_crystal_thumbnail_background_id { get; set; }
            [Index (26)] public virtual string purchase_success_owned_quantity_to_id { get; set; }
            [Index (27)] public virtual string purchase_success_close_button_background_id { get; set; }
            [Index (28)] public virtual string purchase_success_close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string crystal_name { get; set; }
            [Index (1)] public virtual string owned { get; set; }
            [Index (2)] public virtual string effect { get; set; }
            [Index (3)] public virtual string material_require { get; set; }
            [Index (4)] public virtual string no_material_require { get; set; }
            [Index (5)] public virtual string material_name { get; set; }
            [Index (6)] public virtual string material_quantity { get; set; }
            [Index (7)] public virtual string material_sufficient { get; set; }
            [Index (8)] public virtual string material_insufficient { get; set; }
            [Index (9)] public virtual string quantity { get; set; }
            [Index (10)] public virtual string quantity_prompt { get; set; }
            [Index (11)] public virtual string quantity_input { get; set; }
            [Index (12)] public virtual string quantity_available { get; set; }
            [Index (13)] public virtual string slide_bar_quantity { get; set; }
            [Index (14)] public virtual string coin_name { get; set; }
            [Index (15)] public virtual string coin_available { get; set; }
            [Index (16)] public virtual string purchase_quantity { get; set; }
            [Index (17)] public virtual string cannot_purchase_message { get; set; }
            [Index (18)] public virtual string purchase_button { get; set; }
            [Index (19)] public virtual string close_button { get; set; }
            [Index (20)] public virtual string purchase_success { get; set; }
            [Index (21)] public virtual string dialogue { get; set; }
            [Index (22)] public virtual string purchase_success_crystal_name { get; set; }
            [Index (23)] public virtual string purchase_success_owned { get; set; }
            [Index (24)] public virtual string purchase_success_owned_old_quantity { get; set; }
            [Index (25)] public virtual string purchase_success_owned_new_quantity { get; set; }
            [Index (26)] public virtual string purchase_success_purchase_quantity { get; set; }
            [Index (27)] public virtual string purchase_success_close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual Dialogue dialogue { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN50 - Accessory Maker Panel Data
    [ZeroFormattable]
    public class AccessoryMakerPanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string search_input_background_id { get; set; }
            [Index (6)] public virtual string search_button_background_id { get; set; }
            [Index (7)] public virtual string search_icon_id { get; set; }
            [Index (8)] public virtual string accessory_button_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string accessory_maker { get; set; }
            [Index (1)] public virtual string accessory { get; set; }
            [Index (2)] public virtual string cost { get; set; }
            [Index (3)] public virtual string search_prompt { get; set; }
            [Index (4)] public virtual string search_input { get; set; }
            [Index (5)] public virtual string search_button { get; set; }
            [Index (6)] public virtual string no_accessory { get; set; }
        }
        [Index (1)] public virtual string intro_id { get; set; }
        [Index (2)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN51 - Accessory Maker Purchase Panel Data
    [ZeroFormattable]
    public class AccessoryMakerPurchasePanelData : BaseData
    {
        [ZeroFormattable]
        public class MaterialSprite
        {
            [Index (0)] public virtual string coin_id { get; set; }
        }
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual string position_LR { get; set; }
        }
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string purchase_button_background_id { get; set; }
            [Index (3)] public virtual string purchase_icon_id { get; set; }
            [Index (4)] public virtual string close_button_background_id { get; set; }
            [Index (5)] public virtual string close_icon_id { get; set; }
            [Index (6)] public virtual string next_effect_button_background_id { get; set; }
            [Index (7)] public virtual string next_effect_icon_id { get; set; }
            [Index (8)] public virtual string previous_effect_button_background_id { get; set; }
            [Index (9)] public virtual string previous_effect_icon_id { get; set; }
            [Index (10)] public virtual string next_accessory_button_background_id { get; set; }
            [Index (11)] public virtual string next_accessory_icon_id { get; set; }
            [Index (12)] public virtual string previous_accessory_button_background_id { get; set; }
            [Index (13)] public virtual string previous_accessory_icon_id { get; set; }
            [Index (14)] public virtual string info_button_background_id { get; set; }
            [Index (15)] public virtual string scroll_view_background_id { get; set; }
            [Index (16)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (17)] public virtual string scroll_view_handler_id { get; set; }
            [Index (18)] public virtual string thumbnail_background_id { get; set; }
            [Index (19)] public virtual string owned_icon_id { get; set; }
            [Index (20)] public virtual string purchase_success_background_id { get; set; }
            [Index (21)] public virtual string purchase_success_midground_id { get; set; }
            [Index (22)] public virtual string purchase_success_dialogue_background_id { get; set; }
            [Index (23)] public virtual string purchase_success_accessory_thumbnail_background_id { get; set; }
            [Index (24)] public virtual string purchase_success_close_button_background_id { get; set; }
            [Index (25)] public virtual string purchase_success_close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string accessory_name { get; set; }
            [Index (1)] public virtual string owned { get; set; }
            [Index (2)] public virtual string effect { get; set; }
            [Index (3)] public virtual string base_accessory_require { get; set; }
            [Index (4)] public virtual string base_accessory_name { get; set; }
            [Index (5)] public virtual string used_by { get; set; }
            [Index (6)] public virtual string no_base_accessory_require { get; set; }
            [Index (7)] public virtual string material_require { get; set; }
            [Index (8)] public virtual string no_material_require { get; set; }
            [Index (9)] public virtual string material_name { get; set; }
            [Index (10)] public virtual string material_quantity { get; set; }
            [Index (11)] public virtual string material_sufficient { get; set; }
            [Index (12)] public virtual string material_insufficient { get; set; }
            [Index (13)] public virtual string coin_name { get; set; }
            [Index (14)] public virtual string coin_available { get; set; }
            [Index (15)] public virtual string cannot_purchase_message { get; set; }
            [Index (16)] public virtual string purchase_button { get; set; }
            [Index (17)] public virtual string close_button { get; set; }
            [Index (18)] public virtual string purchase_success { get; set; }
            [Index (19)] public virtual string dialogue { get; set; }
            [Index (20)] public virtual string purchase_success_accessory_name { get; set; }
            [Index (21)] public virtual string purchase_success_close_button { get; set; }
        }
        [Index (1)] public virtual MaterialSprite material_sprite { get; set; }
        [Index (2)] public virtual Dialogue dialogue { get; set; }
        [Index (3)] public virtual UiSprite ui_sprite { get; set; }
        [Index (4)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN52 - Gallery Crystal Panel Data
    [ZeroFormattable]
    public class GalleryCrystalPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string crystal_button_background_id { get; set; }
            [Index (5)] public virtual string back_button_background_id { get; set; }
            [Index (6)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string select_crystal { get; set; }
            [Index (1)] public virtual string crystal_button { get; set; }
            [Index (2)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN53 - Gallery Crystal Statistic Panel Data
    [ZeroFormattable]
    public class GalleryCrystalStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string thumbnail_background_id { get; set; }
            [Index (8)] public virtual string portrait_background_id { get; set; }
            [Index (9)] public virtual string first_seperator_id { get; set; }
            [Index (10)] public virtual string used_icon_id { get; set; }
            [Index (11)] public virtual string second_seperator_id { get; set; }
            [Index (12)] public virtual string unknown_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string crystal_name { get; set; }
            [Index (1)] public virtual string effect { get; set; }
            [Index (2)] public virtual string effect_description { get; set; }
            [Index (3)] public virtual string used { get; set; }
            [Index (4)] public virtual string close_button { get; set; }

        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN54 - Gallery Accessory Panel Data
    [ZeroFormattable]
    public class GalleryAccessoryPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string accessory_button_background_id { get; set; }
            [Index (5)] public virtual string back_button_background_id { get; set; }
            [Index (6)] public virtual string back_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string select_accessory { get; set; }
            [Index (1)] public virtual string accessory_button { get; set; }
            [Index (2)] public virtual string back_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN55 - Gallery Accessory Statistic Panel Data
    [ZeroFormattable]
    public class GalleryAccessoryStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string thumbnail_background_id { get; set; }
            [Index (8)] public virtual string portrait_background_id { get; set; }
            [Index (9)] public virtual string first_seperator_id { get; set; }
            [Index (10)] public virtual string used_icon_id { get; set; }
            [Index (11)] public virtual string second_seperator_id { get; set; }
            [Index (12)] public virtual string unknown_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string accessory_name { get; set; }
            [Index (1)] public virtual string effect { get; set; }
            [Index (2)] public virtual string effect_description { get; set; }
            [Index (3)] public virtual string used { get; set; }
            [Index (4)] public virtual string close_button { get; set; }

        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN56 - Wood Cabin Activity Panel Data
    [ZeroFormattable]
    public class WoodCabinActivityPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string camp_button_background_id { get; set; }
            [Index (2)] public virtual string camp_icon_id { get; set; }
            [Index (3)] public virtual string equip_button_background_id { get; set; }
            [Index (4)] public virtual string equip_icon_id { get; set; }
            [Index (5)] public virtual string unequip_button_background_id { get; set; }
            [Index (6)] public virtual string unequip_icon_id { get; set; }
            [Index (7)] public virtual string craft_button_background_id { get; set; }
            [Index (8)] public virtual string craft_icon_id { get; set; }
            [Index (9)] public virtual string scroll_view_background_id { get; set; }
            [Index (10)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (11)] public virtual string scroll_view_handler_id { get; set; }
            [Index (12)] public virtual string wood_background_id { get; set; }
            [Index (13)] public virtual string hole_id { get; set; }
            [Index (14)] public virtual string unit_thumbnail_background_id { get; set; }
            [Index (15)] public virtual string material_thumbnail_background_id { get; set; }
            [Index (16)] public virtual string hole_discovery_group_background_id { get; set; }
            [Index (17)] public virtual string unit_layer_group_background_id { get; set; }
            [Index (18)] public virtual string hole_progress_background_id { get; set; }
            [Index (19)] public virtual string hole_progress_id { get; set; }
            [Index (20)] public virtual string bug_icon_id { get; set; }
            [Index (21)] public virtual string auto_equip_lure_background_id { get; set; }
            [Index (22)] public virtual string auto_equip_lure_tick_id { get; set; }
            [Index (23)] public virtual string auto_hole_repair_background_id { get; set; }
            [Index (24)] public virtual string auto_hole_repair_tick_id { get; set; }
            [Index (25)] public virtual string unknown_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string title { get; set; }
            [Index (1)] public virtual string camp_button { get; set; }
            [Index (2)] public virtual string equip_button { get; set; }
            [Index (3)] public virtual string unequip_button { get; set; }
            [Index (4)] public virtual string craft_button { get; set; }
            [Index (5)] public virtual string hole_discovery_group { get; set; }
            [Index (6)] public virtual string unit_layer_group { get; set; }
            [Index (7)] public virtual string material_to_lure_and_repair { get; set; }
            [Index (8)] public virtual string normal_quantity { get; set; }
            [Index (9)] public virtual string quantity_low { get; set; }
            [Index (10)] public virtual string unit_layer { get; set; }
            [Index (11)] public virtual string unit_to_boost_repair { get; set; }
            [Index (12)] public virtual string auto_equip_lure { get; set; }
            [Index (13)] public virtual string auto_hole_repair { get; set; }
            [Index (14)] public virtual string hole_progress { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN57 - Wood House Activity Panel Data
    [ZeroFormattable]
    public class WoodHouseActivityPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string camp_button_background_id { get; set; }
            [Index (2)] public virtual string camp_icon_id { get; set; }
            [Index (3)] public virtual string equip_button_background_id { get; set; }
            [Index (4)] public virtual string equip_icon_id { get; set; }
            [Index (5)] public virtual string unequip_button_background_id { get; set; }
            [Index (6)] public virtual string unequip_icon_id { get; set; }
            [Index (7)] public virtual string craft_button_background_id { get; set; }
            [Index (8)] public virtual string craft_icon_id { get; set; }
            [Index (9)] public virtual string use_key_button_background_id { get; set; }
            [Index (10)] public virtual string use_key_icon_id { get; set; }
            [Index (11)] public virtual string scroll_view_background_id { get; set; }
            [Index (12)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (13)] public virtual string scroll_view_handler_id { get; set; }
            [Index (14)] public virtual string storage_door_background_id { get; set; }
            [Index (15)] public virtual string storage_room_background_id { get; set; }
            [Index (16)] public virtual string unit_thumbnail_background_id { get; set; }
            [Index (17)] public virtual string material_thumbnail_background_id { get; set; }
            [Index (18)] public virtual string party_discovery_group_background_id { get; set; }
            [Index (19)] public virtual string key_hole_group_background_id { get; set; }
            [Index (20)] public virtual string key_hole_frame_id { get; set; }
            [Index (21)] public virtual string key_hole_mud_id { get; set; }
            [Index (22)] public virtual string room_open_group_background_id { get; set; }
            [Index (23)] public virtual string party_unit_group_background_id { get; set; }
            [Index (24)] public virtual string auto_equip_web_background_id { get; set; }
            [Index (25)] public virtual string auto_equip_web_tick_id { get; set; }
            [Index (26)] public virtual string unknown_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string title { get; set; }
            [Index (1)] public virtual string camp_button { get; set; }
            [Index (2)] public virtual string equip_button { get; set; }
            [Index (3)] public virtual string unequip_button { get; set; }
            [Index (4)] public virtual string craft_button { get; set; }
            [Index (5)] public virtual string use_key_button { get; set; }
            [Index (6)] public virtual string party_discovery_group { get; set; }
            [Index (7)] public virtual string key_hole_group { get; set; }
            [Index (8)] public virtual string mud_fill_rate { get; set; }
            [Index (9)] public virtual string unit_key_drop_group { get; set; }
            [Index (10)] public virtual string material_to_open_door { get; set; }
            [Index (11)] public virtual string room_open_group { get; set; }
            [Index (12)] public virtual string material_to_slow_speed { get; set; }
            [Index (13)] public virtual string normal_quantity { get; set; }
            [Index (14)] public virtual string quantity_low { get; set; }
            [Index (15)] public virtual string auto_equip_web { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN58 - Setting Panel Data
    [ZeroFormattable]
    public class SettingPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string gameplay_button_background_id { get; set; }
            [Index (3)] public virtual string gameplay_icon_id { get; set; }
            [Index (4)] public virtual string audio_button_background_id { get; set; }
            [Index (5)] public virtual string audio_icon_id { get; set; }
            [Index (6)] public virtual string backup_save_button_background_id { get; set; }
            [Index (7)] public virtual string backup_save_icon_id { get; set; }
            [Index (8)] public virtual string restore_save_button_background_id { get; set; }
            [Index (9)] public virtual string restore_save_icon_id { get; set; }
            [Index (10)] public virtual string delete_backup_save_button_background_id { get; set; }
            [Index (11)] public virtual string delete_backup_save_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string setting { get; set; }
            [Index (1)] public virtual string version { get; set; }
            [Index (2)] public virtual string gameplay_button { get; set; }
            [Index (3)] public virtual string audio_button { get; set; }
            [Index (4)] public virtual string backup_save_button { get; set; }
            [Index (5)] public virtual string restore_save_button { get; set; }
            [Index (6)] public virtual string delete_backup_save_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN59 - Gameplay Setting Panel Data
    [ZeroFormattable]
    public class SettingGameplayPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string quantity_slide_bar_background_id { get; set; }
            [Index (8)] public virtual string quantity_slide_bar_id { get; set; }
            [Index (9)] public virtual string quantity_slide_bar_handler_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string gameplay { get; set; }
            [Index (1)] public virtual string hunt_category { get; set; }
            [Index (2)] public virtual string cage_to_check { get; set; }
            [Index (3)] public virtual string cage_quantity { get; set; }
            [Index (4)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN60 - Backup Save Setting Panel Data
    [ZeroFormattable]
    public class SettingBackupSavePanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string backup_button_background_id { get; set; }
            [Index (5)] public virtual string backup_icon_id { get; set; }
            [Index (6)] public virtual string confirm_button_background_id { get; set; }
            [Index (7)] public virtual string confirm_icon_id { get; set; }
            [Index (8)] public virtual string name_input_background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string backup_save { get; set; }
            [Index (1)] public virtual string backup_message { get; set; }
            [Index (2)] public virtual string name_prompt { get; set; }
            [Index (3)] public virtual string name_input { get; set; }
            [Index (4)] public virtual string backup_success { get; set; }
            [Index (5)] public virtual string backup_failed { get; set; }
            [Index (6)] public virtual string close_button { get; set; }
            [Index (7)] public virtual string backup_button { get; set; }
            [Index (8)] public virtual string confirm_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN61 - Restore Save Setting Panel Data
    [ZeroFormattable]
    public class SettingRestoreSavePanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string close_button_background_id { get; set; }
            [Index (6)] public virtual string close_icon_id { get; set; }
            [Index (7)] public virtual string restore_button_background_id { get; set; }
            [Index (8)] public virtual string restore_icon_id { get; set; }
            [Index (9)] public virtual string backup_save_button_background_id { get; set; }
            [Index (10)] public virtual string backup_save_button_highlight { get; set; }
            [Index (11)] public virtual string restore_confirm_background_id { get; set; }
            [Index (12)] public virtual string restore_confirm_midground_id { get; set; }
            [Index (13)] public virtual string restore_confirm_attention_icon_id { get; set; }
            [Index (14)] public virtual string restore_confirm_restore_failed_icon_id { get; set; }
            [Index (15)] public virtual string restore_confirm_backup_save_background_id { get; set; }
            [Index (16)] public virtual string no_button_background_id { get; set; }
            [Index (17)] public virtual string no_icon_id { get; set; }
            [Index (18)] public virtual string yes_button_background_id { get; set; }
            [Index (19)] public virtual string yes_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string restore_save { get; set; }
            [Index (1)] public virtual string close_button { get; set; }
            [Index (2)] public virtual string restore_button { get; set; }
            [Index (3)] public virtual string backup_save_name { get; set; }
            [Index (4)] public virtual string backup_save_date { get; set; }
            [Index (5)] public virtual string select_message { get; set; }
            [Index (6)] public virtual string restore_confirm_attention { get; set; }
            [Index (7)] public virtual string restore_confirm_message { get; set; }
            [Index (8)] public virtual string restore_confirm_restore_failed { get; set; }
            [Index (9)] public virtual string restore_confirm_restore_failed_reason { get; set; }
            [Index (10)] public virtual string restore_confirm_backup_save_name { get; set; }
            [Index (11)] public virtual string restore_confirm_backup_save_date { get; set; }
            [Index (12)] public virtual string yes_button { get; set; }
            [Index (13)] public virtual string no_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN62 - Delete Save Setting Panel Data
    [ZeroFormattable]
    public class SettingDeleteSavePanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string scroll_view_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (4)] public virtual string scroll_view_handler_id { get; set; }
            [Index (5)] public virtual string close_button_background_id { get; set; }
            [Index (6)] public virtual string close_icon_id { get; set; }
            [Index (7)] public virtual string delete_button_background_id { get; set; }
            [Index (8)] public virtual string delete_icon_id { get; set; }
            [Index (9)] public virtual string backup_save_button_background_id { get; set; }
            [Index (10)] public virtual string backup_save_button_highlight { get; set; }
            [Index (11)] public virtual string delete_confirm_background_id { get; set; }
            [Index (12)] public virtual string delete_confirm_midground_id { get; set; }
            [Index (13)] public virtual string delete_confirm_attention_icon_id { get; set; }
            [Index (14)] public virtual string delete_confirm_delete_failed_icon_id { get; set; }
            [Index (15)] public virtual string delete_confirm_backup_save_background_id { get; set; }
            [Index (16)] public virtual string no_button_background_id { get; set; }
            [Index (17)] public virtual string no_icon_id { get; set; }
            [Index (18)] public virtual string yes_button_background_id { get; set; }
            [Index (19)] public virtual string yes_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string delete_save { get; set; }
            [Index (1)] public virtual string close_button { get; set; }
            [Index (2)] public virtual string delete_button { get; set; }
            [Index (3)] public virtual string backup_save_name { get; set; }
            [Index (4)] public virtual string backup_save_date { get; set; }
            [Index (5)] public virtual string select_message { get; set; }
            [Index (6)] public virtual string delete_confirm_attention { get; set; }
            [Index (7)] public virtual string delete_confirm_message { get; set; }
            [Index (8)] public virtual string delete_confirm_delete_failed { get; set; }
            [Index (9)] public virtual string delete_confirm_delete_failed_reason { get; set; }
            [Index (10)] public virtual string delete_confirm_backup_save_name { get; set; }
            [Index (11)] public virtual string delete_confirm_backup_save_date { get; set; }
            [Index (12)] public virtual string yes_button { get; set; }
            [Index (13)] public virtual string no_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN63 - Audio Setting Panel Data
    [ZeroFormattable]
    public class SettingAudioPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string sfx_slide_bar_background_id { get; set; }
            [Index (8)] public virtual string sfx_slide_bar_id { get; set; }
            [Index (9)] public virtual string sfx_slide_bar_handler_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string audio { get; set; }
            [Index (1)] public virtual string close_button { get; set; }
            [Index (2)] public virtual string volume { get; set; }
            [Index (3)] public virtual string sfx { get; set; }
            [Index (4)] public virtual string sfx_value { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN64 - Statistic Panel Data
    [ZeroFormattable]
    public class StatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string location_background_id { get; set; }
            [Index (1)] public virtual string background_id { get; set; }
            [Index (2)] public virtual string gameplay_statistic_button_background_id { get; set; }
            [Index (3)] public virtual string gameplay_statistic_icon_id { get; set; }
            [Index (4)] public virtual string discovery_statistic_button_background_id { get; set; }
            [Index (5)] public virtual string discovery_statistic_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string statistic { get; set; }
            [Index (1)] public virtual string gameplay_statistic { get; set; }
            [Index (2)] public virtual string discovery_statistic { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN65 - Gameplay Statistic Panel Data
    [ZeroFormattable]
    public class GameplayStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string playtime_icon_id { get; set; }
            [Index (8)] public virtual string hunt_since_icon_id { get; set; }
            [Index (9)] public virtual string first_seperator_id { get; set; }
            [Index (10)] public virtual string trap_check_icon_id { get; set; }
            [Index (11)] public virtual string pest_encounter_icon_id { get; set; }
            [Index (12)] public virtual string pest_catch_rate_icon_id { get; set; }
            [Index (13)] public virtual string pest_catch_rate_bar_background_id { get; set; }
            [Index (14)] public virtual string pest_catch_rate_bar_id { get; set; }
            [Index (15)] public virtual string pest_death_rate_icon_id { get; set; }
            [Index (16)] public virtual string pest_death_rate_bar_background_id { get; set; }
            [Index (17)] public virtual string pest_death_rate_bar_id { get; set; }
            [Index (18)] public virtual string coin_earn_icon_id { get; set; }
            [Index (19)] public virtual string coin_spend_icon_id { get; set; }
            [Index (20)] public virtual string reputation_earn_icon_id { get; set; }
            [Index (21)] public virtual string material_gather_icon_id { get; set; }
            [Index (22)] public virtual string royal_pest_encounter_icon_id { get; set; }
            [Index (23)] public virtual string royal_pest_catch_rate_icon_id { get; set; }
            [Index (24)] public virtual string royal_pest_catch_rate_bar_background_id { get; set; }
            [Index (25)] public virtual string royal_pest_catch_rate_bar_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string gameplay_statistic { get; set; }
            [Index (1)] public virtual string platyime { get; set; }
            [Index (2)] public virtual string hunt_since { get; set; }
            [Index (3)] public virtual string trap_check { get; set; }
            [Index (4)] public virtual string pest_encounter { get; set; }
            [Index (5)] public virtual string pest_catch_rate { get; set; }
            [Index (6)] public virtual string pest_death_rate { get; set; }
            [Index (7)] public virtual string coin_earn { get; set; }
            [Index (8)] public virtual string coin_spend { get; set; }
            [Index (9)] public virtual string reputation_earn { get; set; }
            [Index (10)] public virtual string material_gather { get; set; }
            [Index (11)] public virtual string royal_pest_encounter { get; set; }
            [Index (12)] public virtual string royal_pest_catch_rate { get; set; }
            [Index (13)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN66 - Discovery Statistic Panel Data
    [ZeroFormattable]
    public class DiscoveryStatisticPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string midground_id { get; set; }
            [Index (2)] public virtual string close_button_background_id { get; set; }
            [Index (3)] public virtual string close_icon_id { get; set; }
            [Index (4)] public virtual string scroll_view_background_id { get; set; }
            [Index (5)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (6)] public virtual string scroll_view_handler_id { get; set; }
            [Index (7)] public virtual string fairy_icon_id { get; set; }
            [Index (8)] public virtual string weapon_icon_id { get; set; }
            [Index (9)] public virtual string ammo_icon_id { get; set; }
            [Index (10)] public virtual string bait_icon_id { get; set; }
            [Index (11)] public virtual string flavour_icon_id { get; set; }
            [Index (12)] public virtual string crystal_icon_id { get; set; }
            [Index (13)] public virtual string accessory_icon_id { get; set; }
            [Index (14)] public virtual string material_icon_id { get; set; }
            [Index (15)] public virtual string bug_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string discovery_statistic { get; set; }
            [Index (1)] public virtual string close_button { get; set; }
            [Index (2)] public virtual string fairy { get; set; }
            [Index (3)] public virtual string weapon { get; set; }
            [Index (4)] public virtual string ammo { get; set; }
            [Index (5)] public virtual string bait { get; set; }
            [Index (6)] public virtual string flavour { get; set; }
            [Index (7)] public virtual string crystal { get; set; }
            [Index (8)] public virtual string accessory { get; set; }
            [Index (9)] public virtual string material { get; set; }
            [Index (10)] public virtual string bug { get; set; }
            [Index (11)] public virtual string location_bug { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN67 - Credit Panel Data
    [ZeroFormattable]
    public class CreditPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string credit { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

    #region PAN68 - Fairy Level Up Panel
    [ZeroFormattable]
    public class FairyLevelUpPanelData : BaseData
    {
        [ZeroFormattable]
        public class UiSprite
        {
            [Index (0)] public virtual string background_id { get; set; }
            [Index (1)] public virtual string scroll_view_background_id { get; set; }
            [Index (2)] public virtual string scroll_view_handler_background_id { get; set; }
            [Index (3)] public virtual string scroll_view_handler_id { get; set; }
            [Index (4)] public virtual string level_up_to_id { get; set; }
            [Index (5)] public virtual string close_button_background_id { get; set; }
            [Index (6)] public virtual string close_icon_id { get; set; }
        }
        [ZeroFormattable]
        public class TextVisual
        {
            [Index (0)] public virtual string congrat { get; set; }
            [Index (1)] public virtual string message { get; set; }
            [Index (2)] public virtual string fairy_name { get; set; }
            [Index (3)] public virtual string level { get; set; }
            [Index (4)] public virtual string level_old_value { get; set; }
            [Index (5)] public virtual string level_new_value { get; set; }
            [Index (6)] public virtual string strength { get; set; }
            [Index (7)] public virtual string strength_old_value { get; set; }
            [Index (8)] public virtual string strength_new_value { get; set; }
            [Index (9)] public virtual string close_button { get; set; }
        }
        [Index (1)] public virtual UiSprite ui_sprite { get; set; }
        [Index (2)] public virtual TextVisual text_visual { get; set; }
    }
    #endregion

}






















