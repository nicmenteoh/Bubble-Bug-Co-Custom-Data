using System.Collections.Generic;
using ZeroFormatter;

namespace ProjectPestHuntData
{
    // ========================== DO NOT MOVE DOWN =============================================
    [ZeroFormattable]
    public class AssetLanguageList
    {
        [Index (0)] public virtual IList<BaseLanguage> language { get; set; }
    }

    [ZeroFormattable]
    public class CampDisplayLanguage : TutorialCampDisplayLanguage
    {
        [Index (21)] public virtual string slot_2 { get; set; }
        [Index (22)] public virtual string slot_3 { get; set; }
        [Index (23)] public virtual string slot_4 { get; set; }
        [Index (24)] public virtual string slot_5 { get; set; }
        [Index (25)] public virtual string slot_6 { get; set; }
    }

    [ZeroFormattable]
    public class ChangeTrapSetupLanguage : TutorialChangeLocationLanguage
    {
        [Index (3)] public virtual string select_fairy { get; set; }
        [Index (4)] public virtual string select_crystal { get; set; }
        [Index (5)] public virtual string select_weapon { get; set; }
        [Index (6)] public virtual string select_ammo { get; set; }
        [Index (7)] public virtual string select_bait { get; set; }
        [Index (8)] public virtual string select_flavour { get; set; }
        [Index (9)] public virtual string select_accessory { get; set; }
        [Index (10)] public virtual string swap { get; set; }
        [Index (11)] public virtual string remove { get; set; }
        [Index (12)] public virtual string close { get; set; }
        [Index (13)] public virtual string strength { get; set; }
        [Index (14)] public virtual string strength_bonus { get; set; }
        [Index (15)] public virtual string luck { get; set; }
        [Index (16)] public virtual string lethal { get; set; }
        [Index (17)] public virtual string effect { get; set; }
        [Index (18)] public virtual string fairy_level { get; set; }
        [Index (19)] public virtual string hunt_at { get; set; }
        [Index (20)] public virtual string occupy_by { get; set; }
        [Index (21)] public virtual string ammo { get; set; }
        [Index (22)] public virtual string used_by { get; set; }
        [Index (23)] public virtual string in_use { get; set; }
        [Index (24)] public virtual string search_weapon { get; set; }
        [Index (25)] public virtual string search { get; set; }
    }
    // =========================================================================================

    [ZeroFormattable]
    public class BaseLanguage : BaseData
    {
        [Index (1)] public virtual string language { get; set; }
    }


    [ZeroFormattable]
    public class BottomMenuLanguage : BaseData
    {
        [Index (1)] public virtual string menu { get; set; }
        [Index (2)] public virtual string camp { get; set; }
        [Index (3)] public virtual string warehouse { get; set; }
        [Index (4)] public virtual string food_stall { get; set; }
        [Index (5)] public virtual string smith { get; set; }
        [Index (6)] public virtual string ammo_dealer { get; set; }
        [Index (7)] public virtual string fairy_bakery { get; set; }
        [Index (8)] public virtual string crystal_lab { get; set; }
        [Index (9)] public virtual string accessory_maker { get; set; }
        [Index (10)] public virtual string craftsman { get; set; }
        [Index (11)] public virtual string cage_master { get; set; }
        [Index (12)] public virtual string inventory { get; set; }
        [Index (13)] public virtual string gallery { get; set; }
        [Index (14)] public virtual string statistic { get; set; }
        [Index (15)] public virtual string setting { get; set; }
    }

    [ZeroFormattable]
    public class TutorialCampDisplayLanguage : BaseData
    {
        [Index (1)] public virtual string title { get; set; }
        [Index (2)] public virtual string activity_button { get; set; }
        [Index (3)] public virtual string change_location_button { get; set; }
        [Index (4)] public virtual string hunt_button { get; set; }
        [Index (5)] public virtual string effectiveness_button { get; set; }
        [Index (6)] public virtual string history_button { get; set; }
        [Index (7)] public virtual string slot { get; set; }
        [Index (8)] public virtual string slot_1 { get; set; }
        [Index (9)] public virtual string no_fairy { get; set; }
        [Index (10)] public virtual string no_fairy_food { get; set; }
        [Index (11)] public virtual string no_crystal { get; set; }
        [Index (12)] public virtual string no_bait { get; set; }
        [Index (13)] public virtual string no_flavour { get; set; }
        [Index (14)] public virtual string no_weapon { get; set; }
        [Index (15)] public virtual string no_ammo { get; set; }
        [Index (16)] public virtual string no_accessory { get; set; }
        [Index (17)] public virtual string rage_level { get; set; }
        [Index (18)] public virtual string fairy_level { get; set; }
        [Index (19)] public virtual string fairy_max_level { get; set; }
        [Index (20)] public virtual string infinite { get; set; }
    }

    [ZeroFormattable]
    public class TransitionLoadingLanguage : BaseData
    {
        [Index (1)] public virtual string loading { get; set; }
        [Index (2)] public virtual string fetching_asset { get; set; }
        [Index (3)] public virtual string hunting { get; set; }
    }

    [ZeroFormattable]
    public class HuntResultLanguage : BaseData
    {
        [Index (1)] public virtual string summary { get; set; }
        [Index (2)] public virtual string slot { get; set; }
        [Index (3)] public virtual string reward { get; set; }
        [Index (4)] public virtual string trade { get; set; }
        [Index (5)] public virtual string skip { get; set; }
        [Index (6)] public virtual string skip_all { get; set; }
        [Index (7)] public virtual string attract_failed { get; set; }
        [Index (8)] public virtual string rage_level { get; set; }
        [Index (9)] public virtual string loot_summary { get; set; }
        [Index (10)] public virtual string slot_1 { get; set; }
        [Index (11)] public virtual string slot_2 { get; set; }
        [Index (12)] public virtual string slot_3 { get; set; }
        [Index (13)] public virtual string slot_4 { get; set; }
        [Index (14)] public virtual string slot_5 { get; set; }
        [Index (15)] public virtual string slot_6 { get; set; }
        [Index (16)] public virtual string no_action { get; set; }
    }

    [ZeroFormattable]
    public class HuntHistoryLanguage : BaseData
    {
        [Index (1)] public virtual string history { get; set; }
        [Index (2)] public virtual string slot { get; set; }
        [Index (3)] public virtual string reward { get; set; }
        [Index (4)] public virtual string close { get; set; }
        [Index (5)] public virtual string order { get; set; }
        [Index (6)] public virtual string attract_failed { get; set; }
    }

    [ZeroFormattable]
    public class TutorialChangeLocationLanguage : BaseData
    {
        [Index (1)] public virtual string select_location { get; set; }
        [Index (2)] public virtual string select { get; set; }
    }

    [ZeroFormattable]
    public class MainMenuLanguage : BaseData
    {
        [Index (1)] public virtual string menu { get; set; }
        [Index (2)] public virtual string setting { get; set; }
        [Index (3)] public virtual string close { get; set; }
        [Index (4)] public virtual string quit { get; set; }
        [Index (5)] public virtual string quit_message { get; set; }
        [Index (6)] public virtual string yes { get; set; }
        [Index (7)] public virtual string no { get; set; }
        [Index (8)] public virtual string camp { get; set; }
        [Index (9)] public virtual string warehouse { get; set; }
        [Index (10)] public virtual string food_stall { get; set; }
        [Index (11)] public virtual string smith { get; set; }
        [Index (12)] public virtual string ammo_dealer { get; set; }
        [Index (13)] public virtual string fairy_bakery { get; set; }
        [Index (14)] public virtual string crystal_lab { get; set; }
        [Index (15)] public virtual string accessory_maker { get; set; }
        [Index (16)] public virtual string craftsman { get; set; }
        [Index (17)] public virtual string cage_master { get; set; }
        [Index (18)] public virtual string inventory { get; set; }
        [Index (19)] public virtual string gallery { get; set; }
        [Index (20)] public virtual string statistic { get; set; }
        [Index (21)] public virtual string credit { get; set; }
    }

    [ZeroFormattable]
    public class TopBarHuntLanguage : BaseData
    {
        [Index (1)] public virtual string hunt_button { get; set; }
    }

    [ZeroFormattable]
    public class GalleryCategoryLanguage : BaseData
    {
        [Index (1)] public virtual string gallery { get; set; }
        [Index (2)] public virtual string fairy { get; set; }
        [Index (3)] public virtual string weapon { get; set; }
        [Index (4)] public virtual string bait { get; set; }
        [Index (5)] public virtual string flavour { get; set; }
        [Index (6)] public virtual string crystal { get; set; }
        [Index (7)] public virtual string accessory { get; set; }
        [Index (8)] public virtual string unit { get; set; }
    }

    [ZeroFormattable]
    public class GalleryUnitLocationLanguage : BaseData
    {
        [Index (1)] public virtual string select_location { get; set; }
        [Index (2)] public virtual string back { get; set; }
    }

    [ZeroFormattable]
    public class GalleryUnitLanguage : BaseData
    {
        [Index (1)] public virtual string select_unit { get; set; }
        [Index (2)] public virtual string back { get; set; }
    }

    [ZeroFormattable]
    public class GalleryUnitStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string elemental { get; set; }
        [Index (2)] public virtual string strength { get; set; }
        [Index (3)] public virtual string reputation { get; set; }
        [Index (4)] public virtual string rage { get; set; }
        [Index (5)] public virtual string size { get; set; }
        [Index (6)] public virtual string total_encounter { get; set; }
        [Index (7)] public virtual string catch_rate { get; set; }
        [Index (8)] public virtual string death_rate { get; set; }
        [Index (9)] public virtual string coin_reward { get; set; }
        [Index (10)] public virtual string reputation_reward { get; set; }
        [Index (11)] public virtual string material_gather { get; set; }
        [Index (12)] public virtual string royal_encounter { get; set; }
        [Index (13)] public virtual string royal_catch_rate { get; set; }
        [Index (14)] public virtual string loot { get; set; }
        [Index (15)] public virtual string locate_at { get; set; }
        [Index (16)] public virtual string no_loot { get; set; }
        [Index (17)] public virtual string close { get; set; }
    }

    [ZeroFormattable]
    public class GalleryFairyLanguage : BaseData
    {
        [Index (1)] public virtual string select_fairy { get; set; }
        [Index (2)] public virtual string back { get; set; }
    }

    [ZeroFormattable]
    public class GalleryFairyStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string food { get; set; }
        [Index (2)] public virtual string strength { get; set; }
        [Index (3)] public virtual string strength_per_level { get; set; }
        [Index (4)] public virtual string max_level { get; set; }
        [Index (5)] public virtual string luck { get; set; }
        [Index (6)] public virtual string effect { get; set; }
        [Index (7)] public virtual string pest_encounter { get; set; }
        [Index (8)] public virtual string pest_catch_rate { get; set; }
        [Index (9)] public virtual string pest_death_rate { get; set; }
        [Index (10)] public virtual string coin_reward { get; set; }
        [Index (11)] public virtual string reputation_reward { get; set; }
        [Index (12)] public virtual string material_gather { get; set; }
        [Index (13)] public virtual string royal_pest_encounter { get; set; }
        [Index (14)] public virtual string royal_pest_catch_rate { get; set; }
        [Index (15)] public virtual string next { get; set; }
        [Index (16)] public virtual string close { get; set; }
        [Index (17)] public virtual string no_pest_encounter { get; set; }
    }

    [ZeroFormattable]
    public class GalleryWeaponLanguage : BaseData
    {
        [Index (1)] public virtual string select_weapon { get; set; }
        [Index (2)] public virtual string back { get; set; }
    }

    [ZeroFormattable]
    public class GalleryWeaponStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string elemental { get; set; }
        [Index (2)] public virtual string strength { get; set; }
        [Index (3)] public virtual string pest_encounter { get; set; }
        [Index (4)] public virtual string pest_catch_rate { get; set; }
        [Index (5)] public virtual string strength_bonus { get; set; }
        [Index (6)] public virtual string lethal { get; set; }
        [Index (7)] public virtual string used { get; set; }
        [Index (8)] public virtual string pest_death_rate { get; set; }
        [Index (9)] public virtual string next { get; set; }
        [Index (10)] public virtual string close { get; set; }
    }

    [ZeroFormattable]
    public class GalleryBaitLanguage : BaseData
    {
        [Index (1)] public virtual string select_bait { get; set; }
        [Index (2)] public virtual string back { get; set; }
    }

    [ZeroFormattable]
    public class GalleryBaitStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string used { get; set; }
        [Index (2)] public virtual string attractive_rate { get; set; }
        [Index (3)] public virtual string close { get; set; }
    }

    [ZeroFormattable]
    public class GalleryFlavourLanguage : BaseData
    {
        [Index (1)] public virtual string select_flavour { get; set; }
        [Index (2)] public virtual string back { get; set; }
    }

    [ZeroFormattable]
    public class GalleryFlavourStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string used { get; set; }
        [Index (2)] public virtual string close { get; set; }
    }

    [ZeroFormattable]
    public class FoodStallLanguage : BaseData
    {
        [Index (1)] public virtual string food_stall { get; set; }
        [Index (2)] public virtual string no_bait { get; set; }
    }

    [ZeroFormattable]
    public class FoodStallPurchaseLanguage : BaseData
    {
        [Index (1)] public virtual string owned { get; set; }
        [Index (2)] public virtual string material_require { get; set; }
        [Index (3)] public virtual string no_material_require { get; set; }
        [Index (4)] public virtual string quantity { get; set; }
        [Index (5)] public virtual string purchase_quantity { get; set; }
        [Index (6)] public virtual string close { get; set; }
        [Index (7)] public virtual string purchase { get; set; }
        [Index (8)] public virtual string cannot_purchase { get; set; }
        [Index (9)] public virtual string purchase_success { get; set; }
        [Index (10)] public virtual string free { get; set; }
        [Index (11)] public virtual string confirm { get; set; }
        [Index (12)] public virtual string thank_you { get; set; }
        [Index (13)] public virtual string thank_you_with_free_gift { get; set; }
    }

    [ZeroFormattable]
    public class SpecialRewardLanguage : BaseData
    {
        [Index (1)] public virtual string congrat { get; set; }
        [Index (2)] public virtual string confirm { get; set; }
        [Index (3)] public virtual string fairy_acquire { get; set; }
        [Index (4)] public virtual string fairy_food_acquire { get; set; }
        [Index (5)] public virtual string crystal_acquire { get; set; }
        [Index (6)] public virtual string weapon_acquire { get; set; }
        [Index (7)] public virtual string ammo_acquire { get; set; }
        [Index (8)] public virtual string bait_acquire { get; set; }
        [Index (9)] public virtual string flavour_acquire { get; set; }
        [Index (10)] public virtual string accessory_acquire { get; set; }
        [Index (11)] public virtual string material_acquire { get; set; }
        [Index (12)] public virtual string location_unlock { get; set; }
    }

    [ZeroFormattable]
    public class CatchEffectivenessLanguage : BaseData
    {
        [Index (1)] public virtual string catch_effeciveness { get; set; }
        [Index (2)] public virtual string close { get; set; }
    }

    [ZeroFormattable]
    public class WarehouseLanguage : BaseData
    {
        [Index (1)] public virtual string warehouse { get; set; }
        [Index (2)] public virtual string free_claim { get; set; }
        [Index (3)] public virtual string next_claim { get; set; }
        [Index (4)] public virtual string claim { get; set; }
        [Index (5)] public virtual string summary { get; set; }
    }

    [ZeroFormattable]
    public class RewardSummaryLanguage : BaseData
    {
        [Index (1)] public virtual string fairy_food { get; set; }
        [Index (2)] public virtual string bait { get; set; }
        [Index (3)] public virtual string flavour { get; set; }
        [Index (4)] public virtual string ammo { get; set; }
        [Index (5)] public virtual string material { get; set; }
        [Index (6)] public virtual string close { get; set; }
        [Index (7)] public virtual string no_info { get; set; }
    }

    [ZeroFormattable]
    public class LevelUpLanguage : BaseData
    {
        [Index (1)] public virtual string congrat { get; set; }
        [Index (2)] public virtual string confirm { get; set; }
        [Index (3)] public virtual string level_up { get; set; }
        [Index (4)] public virtual string item_unlock { get; set; }
        [Index (5)] public virtual string weapon { get; set; }
        [Index (6)] public virtual string crystal { get; set; }
        [Index (7)] public virtual string accessory { get; set; }
        [Index (8)] public virtual string no_info { get; set; }
    }

    [ZeroFormattable]
    public class SmithLanguage : BaseData
    {
        [Index (1)] public virtual string smith { get; set; }
        [Index (2)] public virtual string no_weapon { get; set; }
    }

    [ZeroFormattable]
    public class SmithPurchaseLanguage : BaseData
    {
        [Index (1)] public virtual string elemental { get; set; }
        [Index (2)] public virtual string strength { get; set; }
        [Index (3)] public virtual string owned { get; set; }
        [Index (4)] public virtual string base_weapon_require { get; set; }
        [Index (5)] public virtual string used_by { get; set; }
        [Index (6)] public virtual string no_base_weapon_require { get; set; }
        [Index (7)] public virtual string material_require { get; set; }
        [Index (8)] public virtual string no_material_require { get; set; }
        [Index (9)] public virtual string close { get; set; }
        [Index (10)] public virtual string purchase { get; set; }
        [Index (11)] public virtual string cannot_purchase { get; set; }
        [Index (12)] public virtual string purchase_success { get; set; }
        [Index (13)] public virtual string confirm { get; set; }
        [Index (14)] public virtual string thank_you { get; set; }
    }

    [ZeroFormattable]
    public class AmmoDealerWeaponLanguage : BaseData
    {
        [Index (1)] public virtual string ammo_dealer_weapon { get; set; }
        [Index (2)] public virtual string no_weapon { get; set; }
    }

    [ZeroFormattable]
    public class AmmoDealerAmmmLanguage : BaseData
    {
        [Index (1)] public virtual string ammo_dealer_ammo { get; set; }
    }

    [ZeroFormattable]
    public class AmmoDealerPurchaseLanguage : BaseData
    {
        [Index (1)] public virtual string strength_bonus { get; set; }
        [Index (2)] public virtual string lethal { get; set; }
        [Index (3)] public virtual string owned { get; set; }
        [Index (4)] public virtual string material_require { get; set; }
        [Index (5)] public virtual string no_material_require { get; set; }
        [Index (6)] public virtual string quantity { get; set; }
        [Index (7)] public virtual string purchase_quantity { get; set; }
        [Index (8)] public virtual string close { get; set; }
        [Index (9)] public virtual string purchase { get; set; }
        [Index (10)] public virtual string cannot_purchase { get; set; }
        [Index (11)] public virtual string purchase_success { get; set; }
        [Index (12)] public virtual string free { get; set; }
        [Index (13)] public virtual string confirm { get; set; }
        [Index (14)] public virtual string thank_you { get; set; }
        [Index (15)] public virtual string thank_you_with_free_gift { get; set; }
    }

    [ZeroFormattable]
    public class FairyBakeryLanguage : BaseData
    {
        [Index (1)] public virtual string fairy_bakery { get; set; }
    }

    [ZeroFormattable]
    public class FairyBakeryPurchaseLanguage : BaseData
    {
        [Index (1)] public virtual string owned { get; set; }
        [Index (2)] public virtual string material_require { get; set; }
        [Index (3)] public virtual string no_material_require { get; set; }
        [Index (4)] public virtual string quantity { get; set; }
        [Index (5)] public virtual string purchase_quantity { get; set; }
        [Index (6)] public virtual string close { get; set; }
        [Index (7)] public virtual string purchase { get; set; }
        [Index (8)] public virtual string cannot_purchase { get; set; }
        [Index (9)] public virtual string purchase_success { get; set; }
        [Index (10)] public virtual string confirm { get; set; }
        [Index (11)] public virtual string thank_you { get; set; }
    }

    [ZeroFormattable]
    public class CageMasterLanguage : BaseData
    {
        [Index (1)] public virtual string cage_master { get; set; }
        [Index (2)] public virtual string slot_1 { get; set; }
        [Index (3)] public virtual string slot_2 { get; set; }
        [Index (4)] public virtual string slot_3 { get; set; }
        [Index (5)] public virtual string slot_4 { get; set; }
        [Index (6)] public virtual string slot_5 { get; set; }
        [Index (7)] public virtual string slot_6 { get; set; }
    }

    [ZeroFormattable]
    public class CageMasterPurchaseLanguage : BaseData
    {
        [Index (1)] public virtual string cage { get; set; }
        [Index (2)] public virtual string owned { get; set; }
        [Index (3)] public virtual string material_require { get; set; }
        [Index (4)] public virtual string no_material_require { get; set; }
        [Index (5)] public virtual string close { get; set; }
        [Index (6)] public virtual string purchase { get; set; }
        [Index (7)] public virtual string cannot_purchase { get; set; }
        [Index (8)] public virtual string max_capacity { get; set; }
        [Index (9)] public virtual string purchase_success { get; set; }
        [Index (10)] public virtual string confirm { get; set; }
        [Index (11)] public virtual string thank_you { get; set; }
    }

    [ZeroFormattable]
    public class InventoryCategoryLanguage : BaseData
    {
        [Index (1)] public virtual string inventory { get; set; }
        [Index (2)] public virtual string fairy_food { get; set; }
        [Index (3)] public virtual string weapon { get; set; }
        [Index (4)] public virtual string ammo { get; set; }
        [Index (5)] public virtual string bait { get; set; }
        [Index (6)] public virtual string flavour { get; set; }
        [Index (7)] public virtual string crystal { get; set; }
        [Index (8)] public virtual string accessory { get; set; }
        [Index (9)] public virtual string material { get; set; }
    }

    [ZeroFormattable]
    public class InventoryLanguage : BaseData
    {
        [Index (1)] public virtual string search_material { get; set; }
        [Index (2)] public virtual string search { get; set; }
        [Index (3)] public virtual string filter_all { get; set; }
        [Index (4)] public virtual string filter_general_material { get; set; }
        [Index (5)] public virtual string filter_currency { get; set; }
        [Index (6)] public virtual string filter_key_item { get; set; }
        [Index (7)] public virtual string filter_fairy_awaken_item { get; set; }
        [Index (8)] public virtual string filter_resources { get; set; }
        [Index (9)] public virtual string filter_activity_item { get; set; }
        [Index (10)] public virtual string fairy_food { get; set; }
        [Index (11)] public virtual string weapon { get; set; }
        [Index (12)] public virtual string ammo { get; set; }
        [Index (13)] public virtual string bait { get; set; }
        [Index (14)] public virtual string flavour { get; set; }
        [Index (15)] public virtual string crystal { get; set; }
        [Index (16)] public virtual string accessory { get; set; }
        [Index (17)] public virtual string general_material { get; set; }
        [Index (18)] public virtual string currency { get; set; }
        [Index (19)] public virtual string key_item { get; set; }
        [Index (20)] public virtual string fairy_awaken_item { get; set; }
        [Index (21)] public virtual string resources { get; set; }
        [Index (22)] public virtual string activity_item { get; set; }
        [Index (23)] public virtual string no_material { get; set; }
        [Index (24)] public virtual string infinite { get; set; }
        [Index (25)] public virtual string sort { get; set; }
        [Index (26)] public virtual string close { get; set; }
    }

    [ZeroFormattable]
    public class MaterialDetailLanguage : BaseData
    {
        [Index (1)] public virtual string detail { get; set; }
        [Index (2)] public virtual string get_at { get; set; }
        [Index (3)] public virtual string craft_material { get; set; }
        [Index (4)] public virtual string use_to_craft { get; set; }
        [Index (5)] public virtual string fairy_awaken { get; set; }
        [Index (6)] public virtual string loot_at { get; set; }
        [Index (7)] public virtual string close { get; set; }
        [Index (8)] public virtual string no_info { get; set; }
        [Index (9)] public virtual string food_stall { get; set; }
        [Index (10)] public virtual string smith { get; set; }
        [Index (11)] public virtual string ammo_dealer { get; set; }
        [Index (12)] public virtual string fairy_bakery { get; set; }
        [Index (13)] public virtual string material_craft { get; set; }
        [Index (14)] public virtual string crystal_lab { get; set; }
        [Index (15)] public virtual string accessory_maker { get; set; }
        [Index (16)] public virtual string bait { get; set; }
        [Index (17)] public virtual string weapon { get; set; }
        [Index (18)] public virtual string ammo { get; set; }
        [Index (19)] public virtual string fairy_food { get; set; }
        [Index (20)] public virtual string material { get; set; }
        [Index (21)] public virtual string crystal { get; set; }
        [Index (22)] public virtual string accessory { get; set; }
    }

    [ZeroFormattable]
    public class CraftsmanLanguage : BaseData
    {
        [Index (1)] public virtual string craftsman { get; set; }
        [Index (2)] public virtual string no_material { get; set; }
        [Index (3)] public virtual string search { get; set; }
    }

    [ZeroFormattable]
    public class CraftsmanPurchaseLanguage : BaseData
    {
        [Index (1)] public virtual string owned { get; set; }
        [Index (2)] public virtual string material_require { get; set; }
        [Index (3)] public virtual string no_material_require { get; set; }
        [Index (4)] public virtual string quantity { get; set; }
        [Index (5)] public virtual string purchase_quantity { get; set; }
        [Index (6)] public virtual string close { get; set; }
        [Index (7)] public virtual string purchase { get; set; }
        [Index (8)] public virtual string cannot_purchase { get; set; }
        [Index (9)] public virtual string purchase_success { get; set; }
        [Index (10)] public virtual string confirm { get; set; }
        [Index (11)] public virtual string thank_you { get; set; }
    }

    [ZeroFormattable]
    public class CrystalLabLanguage : BaseData
    {
        [Index (1)] public virtual string crystal_lab { get; set; }
        [Index (2)] public virtual string no_crystal { get; set; }
        [Index (3)] public virtual string search { get; set; }
    }

    [ZeroFormattable]
    public class CrystalLabPurchaseLanguage : BaseData
    {
        [Index (1)] public virtual string owned { get; set; }
        [Index (2)] public virtual string material_require { get; set; }
        [Index (3)] public virtual string no_material_require { get; set; }
        [Index (4)] public virtual string quantity { get; set; }
        [Index (5)] public virtual string purchase_quantity { get; set; }
        [Index (6)] public virtual string close { get; set; }
        [Index (7)] public virtual string purchase { get; set; }
        [Index (8)] public virtual string cannot_purchase { get; set; }
        [Index (9)] public virtual string purchase_success { get; set; }
        [Index (10)] public virtual string confirm { get; set; }
        [Index (11)] public virtual string thank_you { get; set; }
    }

    [ZeroFormattable]
    public class AccessoryMakerLanguage : BaseData
    {
        [Index (1)] public virtual string accessory_maker { get; set; }
        [Index (2)] public virtual string no_accessory { get; set; }
        [Index (3)] public virtual string search { get; set; }
    }

    [ZeroFormattable]
    public class AccessoryMakerPurchaseLanguage : BaseData
    {
        [Index (1)] public virtual string owned { get; set; }
        [Index (2)] public virtual string base_accessory_require { get; set; }
        [Index (3)] public virtual string used_by { get; set; }
        [Index (4)] public virtual string no_base_accessory_require { get; set; }
        [Index (5)] public virtual string material_require { get; set; }
        [Index (6)] public virtual string no_material_require { get; set; }
        [Index (7)] public virtual string close { get; set; }
        [Index (8)] public virtual string purchase { get; set; }
        [Index (9)] public virtual string cannot_purchase { get; set; }
        [Index (10)] public virtual string purchase_success { get; set; }
        [Index (11)] public virtual string confirm { get; set; }
        [Index (12)] public virtual string thank_you { get; set; }
    }

    [ZeroFormattable]
    public class GalleryCrystalLanguage : BaseData
    {
        [Index (1)] public virtual string select_crystal { get; set; }
        [Index (2)] public virtual string back { get; set; }
    }

    [ZeroFormattable]
    public class GalleryCrystalStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string effect { get; set; }
        [Index (2)] public virtual string used { get; set; }
        [Index (3)] public virtual string close { get; set; }
    }

    [ZeroFormattable]
    public class GalleryAccessoryLanguage : BaseData
    {
        [Index (1)] public virtual string select_accessory { get; set; }
        [Index (2)] public virtual string back { get; set; }
    }

    [ZeroFormattable]
    public class GalleryyAccessoryStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string effect { get; set; }
        [Index (2)] public virtual string used { get; set; }
        [Index (3)] public virtual string close { get; set; }
    }

    [ZeroFormattable]
    public class WoodCabinActivityLanguage : BaseData
    {
        [Index (1)] public virtual string activity { get; set; }
        [Index (2)] public virtual string camp { get; set; }
        [Index (3)] public virtual string equip { get; set; }
        [Index (4)] public virtual string unequip { get; set; }
        [Index (5)] public virtual string craft { get; set; }
        [Index (6)] public virtual string hole_discovery_group { get; set; }
        [Index (7)] public virtual string unit_layer_group { get; set; }
        [Index (8)] public virtual string material_to_lure_unit_message { get; set; }
        [Index (9)] public virtual string unit_layer { get; set; }
        [Index (10)] public virtual string material_to_repair_message { get; set; }
        [Index (11)] public virtual string unit_to_boost_repair { get; set; }
        [Index (12)] public virtual string auto_equip_lure { get; set; }
        [Index (13)] public virtual string auto_hole_repair { get; set; }
        [Index (14)] public virtual string unit_left { get; set; }
        [Index (15)] public virtual string fill_left { get; set; }
    }

    [ZeroFormattable]
    public class WoodHouseActivityLanguage : BaseData
    {
        [Index (1)] public virtual string activity { get; set; }
        [Index (2)] public virtual string camp { get; set; }
        [Index (3)] public virtual string equip { get; set; }
        [Index (4)] public virtual string unequip { get; set; }
        [Index (5)] public virtual string craft { get; set; }
        [Index (6)] public virtual string use_key { get; set; }
        [Index (7)] public virtual string party_discovery_group { get; set; }
        [Index (8)] public virtual string key_hole_group { get; set; }
        [Index (9)] public virtual string mud_fill_rate { get; set; }
        [Index (10)] public virtual string unit_key_drop_group { get; set; }
        [Index (11)] public virtual string material_to_open_door { get; set; }
        [Index (12)] public virtual string room_open_group { get; set; }
        [Index (13)] public virtual string material_to_slow_speed { get; set; }
        [Index (14)] public virtual string auto_equip_web { get; set; }
    }

    [ZeroFormattable]
    public class SettingLanguage : BaseData
    {
        [Index (1)] public virtual string setting { get; set; }
        [Index (2)] public virtual string gameplay { get; set; }
        [Index (3)] public virtual string audio { get; set; }
        [Index (4)] public virtual string backup_save { get; set; }
        [Index (5)] public virtual string restore_save { get; set; }
        [Index (6)] public virtual string delete_backup_save { get; set; }
    }

    [ZeroFormattable]
    public class SettingGameplayLanguage : BaseData
    {
        [Index (1)] public virtual string gameplay { get; set; }
        [Index (2)] public virtual string close { get; set; }
        [Index (3)] public virtual string hunt_category { get; set; }
        [Index (4)] public virtual string cage_to_check { get; set; }
    }

    [ZeroFormattable]
    public class SettingBackupSaveLanguage : BaseData
    {
        [Index (1)] public virtual string backup_save { get; set; }
        [Index (2)] public virtual string backup_message { get; set; }
        [Index (3)] public virtual string input_name { get; set; }
        [Index (4)] public virtual string backup_failed { get; set; }
        [Index (5)] public virtual string backup_success { get; set; }
        [Index (6)] public virtual string close { get; set; }
        [Index (7)] public virtual string backup { get; set; }
        [Index (8)] public virtual string confirm { get; set; }
    }

    [ZeroFormattable]
    public class SettingRestoreSaveLanguage : BaseData
    {
        [Index (1)] public virtual string restore_save { get; set; }
        [Index (2)] public virtual string close { get; set; }
        [Index (3)] public virtual string restore { get; set; }
        [Index (4)] public virtual string select_message { get; set; }
        [Index (5)] public virtual string attention { get; set; }
        [Index (6)] public virtual string caution_message { get; set; }
        [Index (7)] public virtual string yes { get; set; }
        [Index (8)] public virtual string no { get; set; }
        [Index (9)] public virtual string restore_failed { get; set; }
        [Index (10)] public virtual string restore_failed_reason { get; set; }
    }

    [ZeroFormattable]
    public class SettingDeleteSaveLanguage : BaseData
    {
        [Index (1)] public virtual string delete_save { get; set; }
        [Index (2)] public virtual string close { get; set; }
        [Index (3)] public virtual string delete { get; set; }
        [Index (4)] public virtual string select_message { get; set; }
        [Index (5)] public virtual string attention { get; set; }
        [Index (6)] public virtual string caution_message { get; set; }
        [Index (7)] public virtual string yes { get; set; }
        [Index (8)] public virtual string no { get; set; }
        [Index (9)] public virtual string delete_failed { get; set; }
        [Index (10)] public virtual string delete_failed_reason { get; set; }
    }

    [ZeroFormattable]
    public class SettingAudioLanguage : BaseData
    {
        [Index (1)] public virtual string audio { get; set; }
        [Index (2)] public virtual string close { get; set; }
        [Index (3)] public virtual string volume { get; set; }
        [Index (4)] public virtual string sfx { get; set; }
        [Index (5)] public virtual string bgm { get; set; }
    }

    [ZeroFormattable]
    public class StatisticLanguage : BaseData
    {
        [Index (1)] public virtual string statistic { get; set; }
        [Index (2)] public virtual string gameplay_statistic { get; set; }
        [Index (3)] public virtual string discovery_statistic { get; set; }
    }

    [ZeroFormattable]
    public class GameplayStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string gameplay_statistic { get; set; }
        [Index (2)] public virtual string close { get; set; }
        [Index (3)] public virtual string platyime { get; set; }
        [Index (4)] public virtual string hunt_since { get; set; }
        [Index (5)] public virtual string trap_check { get; set; }
        [Index (6)] public virtual string pest_encounter { get; set; }
        [Index (7)] public virtual string pest_catch_rate { get; set; }
        [Index (8)] public virtual string pest_death_rate { get; set; }
        [Index (9)] public virtual string coin_earn { get; set; }
        [Index (10)] public virtual string coin_spend { get; set; }
        [Index (11)] public virtual string reputation_earn { get; set; }
        [Index (12)] public virtual string material_gather { get; set; }
        [Index (13)] public virtual string royal_pest_encounter { get; set; }
        [Index (14)] public virtual string royal_pest_catch_rate { get; set; }
    }

    [ZeroFormattable]
    public class DiscoveryStatisticLanguage : BaseData
    {
        [Index (1)] public virtual string discovery_statistic { get; set; }
        [Index (2)] public virtual string close { get; set; }
        [Index (3)] public virtual string fairy { get; set; }
        [Index (4)] public virtual string weapon { get; set; }
        [Index (5)] public virtual string ammo { get; set; }
        [Index (6)] public virtual string bait { get; set; }
        [Index (7)] public virtual string flavour { get; set; }
        [Index (8)] public virtual string crystal { get; set; }
        [Index (9)] public virtual string accessory { get; set; }
        [Index (10)] public virtual string bug { get; set; }
        [Index (11)] public virtual string material { get; set; }
    }

    [ZeroFormattable]
    public class CreditLanguage : BaseData
    {
        [Index (1)] public virtual string image_by { get; set; }
        [Index (2)] public virtual string sound_by { get; set; }
    }

    [ZeroFormattable]
    public class FairyLevelUpLanguage : BaseData
    {
        [Index (1)] public virtual string congrat { get; set; }
        [Index (2)] public virtual string confirm { get; set; }
        [Index (3)] public virtual string level_up { get; set; }
        [Index (4)] public virtual string level { get; set; }
        [Index (5)] public virtual string strength { get; set; }
    }
}








