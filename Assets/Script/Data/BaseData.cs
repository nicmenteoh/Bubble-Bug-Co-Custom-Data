using System.Collections.Generic;
using ZeroFormatter;

namespace ProjectPestHuntData
{
    [ZeroFormattable]
    public class BaseData
    {
        [Index (0)] public virtual string asset_id { get; set; }
    }

    [ZeroFormattable]
    public class BaseIconData : BaseData
    {
        [Index (1)] public virtual string portrait_id { get; set; }
        [Index (2)] public virtual string thumbnail_id { get; set; }
    }

    [ZeroFormattable]
    public class BaseRewardData : BaseIconData
    {
        [Index (3)] public virtual Reward_Type reward_type { get; set; }
    }

    [ZeroFormattable]
    public class UnitData : BaseIconData
    {
        [ZeroFormattable]
        public class FlavourData
        {
            [Index (0)] public virtual string flavour_id { get; set; }
            [Index (1)] public virtual int attract_poll { get; set; }
        }

        [Index (4)] public virtual string silhouette_id { get; set; }
        [Index (5)] public virtual string family { get; set; }
        [Index (6)] public virtual string elemental { get; set; }
        [Index (7)] public virtual byte rage { get; set; }
        [Index (8)] public virtual int strength { get; set; }
        [Index (9)] public virtual int size { get; set; }
        [Index (10)] public virtual int coin { get; set; }
        [Index (11)] public virtual int reputation { get; set; }
        [Index (12)] public virtual IList<FlavourData> flavour_polls { get; set; }
        [Index (13)] public virtual IList<RegionData.RewardPoll> reward_polls { get; set; }
    }

    [ZeroFormattable]
    public class MaterialData : BaseRewardData
    {
        [ZeroFormattable]
        public class CraftMaterial
        {
            [Index (0)] public virtual string material_id { get; set; }
            [Index (1)] public virtual int quantity { get; set; }
        }

        [Index (4)] public virtual IList<CraftMaterial> craft_materials { get; set; }
        [Index (5)] public virtual string get_at { get; set; }
        [Index (6)] public virtual int cost { get; set; }
        [Index (7)] public virtual int free_claim_poll { get; set; }
        [Index (8)] public virtual int quantity { set; get; }
    }

    [ZeroFormattable]
    public class BaitData : MaterialData
    {
        [ZeroFormattable]
        public class AttractiveChance
        {
            [Index (0)] public virtual string family { get; set; }
            [Index (1)] public virtual int chance { get; set; }
        }

        [Index (9)] public virtual int available_chance { get; set; }
        [Index (10)] public virtual IList<AttractiveChance> family_attractive_chance { set; get; }
    }

    [ZeroFormattable]
    public class FairyData : BaseRewardData
    {
        [Index (4)] public virtual string silhouette_id { get; set; }
        [Index (5)] public virtual byte rarity { get; set; }
        [Index (6)] public virtual int base_strength { get; set; }
        [Index (7)] public virtual int strength_per_level { get; set; }
        [Index (8)] public virtual byte luck { get; set; }
        [Index (9)] public virtual string food_id { get; set; }
        [Index (10)] public virtual IList<string> effect_id { get; set; }
        [Index (11)] public virtual string awaken_to { get; set; }
        [Index (12)] public virtual string duplicate_drop { get; set; }
        [Index (13)] public virtual IList<MaterialData.CraftMaterial> awaken_material { get; set; }
    }

    [ZeroFormattable]
    public class CrystalData : MaterialData
    {
        [Index (9)] public virtual string silhouette_id { get; set; }
        [Index (10)] public virtual ushort rarity { get; set; }
        [Index (11)] public virtual byte unlock_rank { get; set; }
        [Index (12)] public virtual IList<string> effect_id { get; set; }
    }

    [ZeroFormattable]
    public class WeaponData : MaterialData
    {
        [Index (9)] public virtual string silhouette_id { get; set; }
        [Index (10)] public virtual string elemental { get; set; }
        [Index (11)] public virtual int strength { get; set; }
        [Index (12)] public virtual byte unlock_rank { get; set; }
        [Index (13)] public virtual IList<string> ammo_id { get; set; }
        [Index (14)] public virtual string base_craft_weapon_id { get; set; }
    }

    [ZeroFormattable]
    public class AmmoData : MaterialData
    {
        [Index (9)] public virtual int strength_bonus { get; set; }
        [Index (10)] public virtual byte lethal { get; set; }
        [Index (11)] public virtual bool infinite { get; set; }
    }

    [ZeroFormattable]
    public class AccessoryData : CrystalData
    {
        [Index (13)] public virtual string base_craft_accessory_id { get; set; }
    }

    [ZeroFormattable]
    public class RankData : BaseData
    {
        [Index (1)] public virtual int level { get; set; }
        [Index (2)] public virtual long rank_up_experience { get; set; }
        [Index (3)] public virtual long accumulate_experience { get; set; }
    }

    [ZeroFormattable]
    public class EffectData : BaseData
    {
        [Index (1)] public virtual Accessory_Effect effect { get; set; }
        [Index (2)] public virtual IList<int> values { get; set; }
    }

    [ZeroFormattable]
    public class RegionData : BaseIconData
    {
        [ZeroFormattable]
        public class RewardPoll : BaseData
        {
            [Index (1)] public virtual int poll {  get; set; }
        }

        [Index (3)] public virtual IList<string> location_id { get; set; }
        [Index (4)] public virtual IList<string> unit_id { get; set; }
        [Index (5)] public virtual string fairy_appear_id { get; set; }
        [Index (6)] public virtual IList<RewardPoll> reward_polls { get; set; }
    }

    [ZeroFormattable]
    public class LocationData : BaseIconData
    {
        [Index (3)] public virtual IList<string> unit_id { get; set; }
        [Index (4)] public virtual IList<RegionData.RewardPoll> reward_polls { get; set; }
        [Index (5)] public virtual string activity_id { get; set; }
        [Index (6)] public virtual string intro_id { get; set; }
    }

    [ZeroFormattable]
    public class ElementalData : BaseData
    {
        [ZeroFormattable]
        public class Against
        {
            [Index (0)] public virtual string asset_id { get; set; }
            [Index (1)] public virtual int value { get; set; }
        }

        [Index (1)] public virtual IList<Against> against { get; set; }
    }

    [ZeroFormattable]
    public class DialogueData : BaseData
    {
        [ZeroFormattable]
        public class Dialogue
        {
            [Index (0)] public virtual string character_id { get; set; }
            [Index (1)] public virtual FloatXY character_position { get; set; }
            [Index (2)] public virtual FloatXY dialogue_position { get; set; }
            [Index (3)] public virtual string dialogue { get; set; }
        }

        [ZeroFormattable]
        public class Segment
        {
            [Index (0)] public virtual int segment { get; set; }
            [Index (1)] public virtual IList<Dialogue> dialogues { get; set; }
        }

        [Index (1)] public virtual IList<Segment> intro { get; set; }
    }

    [ZeroFormattable]
    public struct FloatXY
    {
        [Index (0)] public float x;
        [Index (1)] public float y;

        public FloatXY (float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    [ZeroFormattable]
    public class AssetDataList<T>
    {
        [Index (0)] public virtual IList<T> data { get; set; }
    }

    [ZeroFormattable]
    public class SpriteDataList
    {
        [Index (0)] public virtual IList<string> unit { get; set; }
        [Index (1)] public virtual IList<string> unit_family { get; set; }
        [Index (2)] public virtual IList<string> fairy { get; set; }
        [Index (3)] public virtual IList<string> fairy_food { get; set; }
        [Index (4)] public virtual IList<string> crystal { get; set; }
        [Index (5)] public virtual IList<string> weapon { get; set; }
        [Index (6)] public virtual IList<string> ammo { get; set; }
        [Index (7)] public virtual IList<string> bait { get; set; }
        [Index (8)] public virtual IList<string> flavour { get; set; }
        [Index (9)] public virtual IList<string> accessory { get; set; }
        [Index (10)] public virtual IList<string> material { get; set; }
        [Index (11)] public virtual IList<string> effect { get; set; }
        [Index (12)] public virtual IList<string> rank { get; set; }
        [Index (13)] public virtual IList<string> location { get; set; }
        [Index (14)] public virtual IList<string> element { get; set; }
        [Index (15)] public virtual IList<string> hunt_result { get; set; }
        [Index (16)] public virtual IList<string> character { get; set; }
        [Index (17)] public virtual IList<string> ui { get; set; }
    }


    public static class ShopType
    {
        public readonly static string shop = "s";
        public readonly static string blackMarket = "m";
        public readonly static string auction = "a";
        public readonly static string shop_base_location = "l";
    }

    public static class CharacterAtShopPosition
    {
        public readonly static string left = "l";
        public readonly static string right = "r";
    }

    public enum Message_Type
    {
        None,
        Info,
        Warning,
        Error,
        Success
    }

    public enum Active_Panel
    {
        Camp,
        Activity,
        Warehouse,
        Food_Stall,
        Smith,
        Ammo_Dealer,
        Fairy_Bakery,
        Crystal_Lab,
        Accessory_Maker,
        Craftsman,
        Cage_Master,
        Inventory,
        Gallery,
        Statistic,
        Setting
    }

    public enum Reward_Type
    {
        General_Material = 0,
        Currency,
        Fairy,
        Fairy_Food,
        Crystal,
        Weapon,
        Ammo,
        Bait,
        Flavour,
        Accessory,
        Location,
        Key_Item,
        Fairy_Awaken_Item,
        Resources,
        Activity_Item
    }

    public enum Catch_Result
    {
        Success_Survive,
        Success_Death,
        Failed,
        Not_Attracted
    }

    public enum Accessory_Effect
    {
        None = 0,
        Strength_Value,
        Strength_Multiplier,
        Luck_Value,
        Lethal_Value,
        Strength_Multiplier_And_Lethal_Value,
        Reward_Plus_With_Luck_Penalty,
        Royal_Value,
        catch_effective_value,
        Luck_Value_And_Attractiveness_Value,
        Inverse_Rage,
        Cold_Rage,
        Reward_Plus_Even_Catch_Failed
    }

    public static class AssetDataFilename
    {
        public static readonly string spriteList = "Sprite_List.data";
        public static readonly string unit = "Unit.data";
        public static readonly string fairy = "Fairy.data";
        public static readonly string fairyFood = "Fairy_Food.data";
        public static readonly string bait = "Bait.data";
        public static readonly string flavour = "Flavour.data";
        public static readonly string weapon = "Weapon.data";
        public static readonly string ammo = "Ammo.data";
        public static readonly string crystal = "Crystal.data";
        public static readonly string accessory = "Accessory.data";
        public static readonly string material = "Material.data";
        public static readonly string elemental = "Elemental.data";
        public static readonly string effect = "Effect.data";
        public static readonly string region = "Region.data";
        public static readonly string location = "Location.data";
        public static readonly string rank = "Rank.data";
        public static readonly string dialogue = "Dialogue.data";
        public static readonly string config = "Config.data";
    }

    public static class AssetLanguageFilename
    {
        public static readonly string languageList = "Sprite_List.data";
        public static readonly string unit = "Unit.lang";
        public static readonly string unitFamily = "Unit_Family.lang";
        public static readonly string fairy = "Fairy.lang";
        public static readonly string fairyFood = "Fairy_Food.lang";
        public static readonly string bait = "Bait.lang";
        public static readonly string flavour = "Flavour.lang";
        public static readonly string weapon = "Weapon.lang";
        public static readonly string ammo = "Ammo.lang";
        public static readonly string crystal = "Crystal.lang";
        public static readonly string accessory = "Accessory.lang";
        public static readonly string material = "Material.lang";
        public static readonly string elemental = "Elemental.lang";
        public static readonly string effect = "Effect.lang";
        public static readonly string region = "Region.lang";
        public static readonly string location = "Location.lang";
        public static readonly string rank = "Rank.lang";
        public static readonly string huntResult = "Hunt_Result.lang";
    }

    public static class PanelDataFilename
    {
        public static readonly string topBarInfo = "pan2.data";
        public static readonly string bottomMenu = "pan3.data";
        public static readonly string camp = "pan4.data";
        public static readonly string transitionLoading = "pan5.data";
        public static readonly string huntResult = "pan6.data";
        public static readonly string huntHistory = "pan7.data";
        public static readonly string changeTrapSetup = "pan8.data";
        public static readonly string mainMenu = "pan9.data";
        public static readonly string topBarHunt = "pan10.data";
        public static readonly string galleryCategory = "pan11.data";
        public static readonly string galleryUnitLocation = "pan12.data";
        public static readonly string galleryUnit = "pan13.data";
        public static readonly string galleryUnitStatistic = "pan14.data";
        public static readonly string galleryFairy = "pan15.data";
        public static readonly string galleryFairyStatistic = "pan16.data";
        public static readonly string galleryWeapon = "pan17.data";
        public static readonly string galleryWeaponStatistic = "pan18.data";
        public static readonly string galleryBait = "pan19.data";
        public static readonly string galleryBaitStatistic = "pan20.data";
        public static readonly string galleryFlavour = "pan21.data";
        public static readonly string galleryFlavourStatistic = "pan22.data";
        public static readonly string dialogue = "pan23.data";
        public static readonly string foodStall = "pan24.data";
        public static readonly string foodStallPurchase = "pan25.data";
        public static readonly string specialReward = "pan26.data";
        public static readonly string catchEffectiveness = "pan27.data";
        public static readonly string tutorialCamp = "pan28.data";
        public static readonly string tutorialHuntResult = "pan29.data";
        public static readonly string tutorialChangeLocation = "pan30.data";
        public static readonly string warehouse = "pan31.data";
        public static readonly string rewardSummary = "pan32.data";
        public static readonly string levelUp = "pan33.data";
        public static readonly string smith = "pan34.data";
        public static readonly string smithPurchase = "pan35.data";
        public static readonly string ammoDealerWeapon = "pan36.data";
        public static readonly string ammoDealerAmmo = "pan37.data";
        public static readonly string ammoDealerPurchase = "pan38.data";
        public static readonly string fairyBakery = "pan39.data";
        public static readonly string fairyBakeryPurchase = "pan40.data";
        public static readonly string cageMaster = "pan41.data";
        public static readonly string cageMasterPurchase = "pan42.data";
        public static readonly string inventoryCategory = "pan43.data";
        public static readonly string inventory = "pan44.data";
        public static readonly string materialDetail = "pan45.data";
        public static readonly string craftsman = "pan46.data";
        public static readonly string craftsmanPurchase = "pan47.data";
        public static readonly string crystalLab = "pan48.data";
        public static readonly string crystalLabPurchase = "pan49.data";
        public static readonly string accessoryMaker = "pan50.data";
        public static readonly string accessoryMakerPurchase = "pan51.data";
        public static readonly string galleryCrystal = "pan52.data";
        public static readonly string galleryCrystalStatistic = "pan53.data";
        public static readonly string galleryAccessory = "pan54.data";
        public static readonly string galleryAccessoryStatistic = "pan55.data";
        public static readonly string woodCabinActivity = "pan56.data";
        public static readonly string woodHouseActivity = "pan57.data";
        public static readonly string setting = "pan58.data";
        public static readonly string gameplaySetting = "pan59.data";
        public static readonly string backupSaveSetting = "pan60.data";
        public static readonly string restoreSaveSetting = "pan61.data";
        public static readonly string deleteSaveSetting = "pan62.data";
        public static readonly string audioSetting = "pan63.data";
        public static readonly string statistic = "pan64.data";
        public static readonly string gameplayStatistic = "pan65.data";
        public static readonly string discoveryStatistic = "pan66.data";
        public static readonly string credit = "pan67.data";
        public static readonly string fairyLevelUp = "pan68.data";
    }

    public static class PanelLanguageFilename
    {
        public static readonly string bottomMenu = "pan3.lang";
        public static readonly string camp = "pan4.lang";
        public static readonly string transitionLoading = "pan5.lang";
        public static readonly string huntResult = "pan6.lang";
        public static readonly string huntHistory = "pan7.lang";
        public static readonly string changeTrapSetup = "pan8.lang";
        public static readonly string mainMenu = "pan9.lang";
        public static readonly string topBarHunt = "pan10.lang";
        public static readonly string galleryCategory = "pan11.lang";
        public static readonly string galleryUnitLocation = "pan12.lang";
        public static readonly string galleryUnit = "pan13.lang";
        public static readonly string galleryUnitStatistic = "pan14.lang";
        public static readonly string galleryFairy = "pan15.lang";
        public static readonly string galleryFairyStatistic = "pan16.lang";
        public static readonly string galleryWeapon = "pan17.lang";
        public static readonly string galleryWeaponStatistic = "pan18.lang";
        public static readonly string galleryBait = "pan19.lang";
        public static readonly string galleryBaitStatistic = "pan20.lang";
        public static readonly string galleryFlavour = "pan21.lang";
        public static readonly string galleryFlavourStatistic = "pan22.lang";
        public static readonly string dialogue = "pan23.lang";
        public static readonly string foodStall = "pan24.lang";
        public static readonly string foodStallPurchase = "pan25.lang";
        public static readonly string specialReward = "pan26.lang";
        public static readonly string catchEffectiveness = "pan27.lang";
        public static readonly string tutorialCamp = "pan28.lang";
        public static readonly string tutorialHuntResult = "pan29.lang";
        public static readonly string tutorialChangeLocation = "pan30.lang";
        public static readonly string warehouse = "pan31.lang";
        public static readonly string rewardSummary = "pan32.lang";
        public static readonly string levelUp = "pan33.lang";
        public static readonly string smith = "pan34.lang";
        public static readonly string smithPurchase = "pan35.lang";
        public static readonly string ammoDealerWeapon = "pan36.lang";
        public static readonly string ammoDealerAmmo = "pan37.lang";
        public static readonly string ammoDealerPurchase = "pan38.lang";
        public static readonly string fairyBakery = "pan39.lang";
        public static readonly string fairyBakeryPurchase = "pan40.lang";
        public static readonly string cageMaster = "pan41.lang";
        public static readonly string cageMasterPurchase = "pan42.lang";
        public static readonly string inventoryCategory = "pan43.lang";
        public static readonly string inventory = "pan44.lang";
        public static readonly string materialDetail = "pan45.lang";
        public static readonly string craftsman = "pan46.lang";
        public static readonly string craftsmanPurchase = "pan47.lang";
        public static readonly string crystalLab = "pan48.lang";
        public static readonly string crystalLabPurchase = "pan49.lang";
        public static readonly string accessoryMaker = "pan50.lang";
        public static readonly string accessoryMakerPurchase = "pan51.lang";
        public static readonly string galleryCrystal = "pan52.lang";
        public static readonly string galleryCrystalStatistic = "pan53.lang";
        public static readonly string galleryAccessory = "pan54.lang";
        public static readonly string galleryAccessoryStatistic = "pan55.lang";
        public static readonly string woodCabinActivity = "pan56.lang";
        public static readonly string woodHouseActivity = "pan57.lang";
        public static readonly string setting = "pan58.lang";
        public static readonly string gameplaySetting = "pan59.lang";
        public static readonly string backupSaveSetting = "pan60.lang";
        public static readonly string restoreSaveSetting = "pan61.lang";
        public static readonly string deleteSaveSetting = "pan62.lang";
        public static readonly string audioSetting = "pan63.lang";
        public static readonly string statistic = "pan64.lang";
        public static readonly string gameplayStatistic = "pan65.lang";
        public static readonly string discoveryStatistic = "pan66.lang";
        public static readonly string credit = "pan67.lang";
        public static readonly string fairyLevelUp = "pan68.lang";
    }

    public static class ActivityDataFilename
    {
        public static readonly string woodCabin = "act1.data";
        public static readonly string woodHouse = "act2.data";

    }
}