using ProjectPestHuntData;
using UnityEditor;

public class GeneralPanelLanguage
{

    [MenuItem ("Data Generator/Language/General Panel/Bottom Menu Panel")]
    static void GenerateBottomMenuPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<BottomMenuLanguage> (PanelLanguageFilename.bottomMenu);

    [MenuItem ("Data Generator/Language/General Panel/Camp Display Panel")]
    static void GenerateCampPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CampDisplayLanguage> (PanelLanguageFilename.camp);

    [MenuItem ("Data Generator/Language/General Panel/Transition Loading Panel")]
    static void GenerateTransitionLoadingPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<TransitionLoadingLanguage> (PanelLanguageFilename.transitionLoading);

    [MenuItem ("Data Generator/Language/General Panel/Hunt Result Panel")]
    static void GenerateHuntResultPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<HuntResultLanguage> (PanelLanguageFilename.huntResult);

    [MenuItem ("Data Generator/Language/General Panel/Hunt History Panel")]
    static void GenerateHuntHistoryPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<HuntHistoryLanguage> (PanelLanguageFilename.huntHistory);

    [MenuItem ("Data Generator/Language/General Panel/Change Trap Setup Panel")]
    static void GenerateChangeTrapSetupPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<ChangeTrapSetupLanguage> (PanelLanguageFilename.changeTrapSetup);

    [MenuItem ("Data Generator/Language/General Panel/Main Menu Panel")]
    static void GenerateMainMenuPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<MainMenuLanguage> (PanelLanguageFilename.mainMenu);

    [MenuItem ("Data Generator/Language/General Panel/Top Bar Hunt Panel")]
    static void GenerateTopBarHuntPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<TopBarHuntLanguage> (PanelLanguageFilename.topBarHunt);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Category Panel")]
    static void GenerateGalleryCategoryPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryCategoryLanguage> (PanelLanguageFilename.galleryCategory);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Unit Location Panel")]
    static void GenerateGalleryUnitLocationPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryUnitLocationLanguage> (PanelLanguageFilename.galleryUnitLocation);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Unit Panel")]
    static void GenerateGalleryUnitPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryUnitLanguage> (PanelLanguageFilename.galleryUnit);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Unit Statistic Panel")]
    static void GenerateGalleryUnitStatisticPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryUnitStatisticLanguage> (PanelLanguageFilename.galleryUnitStatistic);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Fairy Panel")]
    static void GenerateGalleryFairyPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryFairyLanguage> (PanelLanguageFilename.galleryFairy);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Fairy Statistic Panel")]
    static void GenerateGalleryFairyStatisticPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryFairyStatisticLanguage> (PanelLanguageFilename.galleryFairyStatistic);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Weapon Panel")]
    static void GenerateGalleryWeaponPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryWeaponLanguage> (PanelLanguageFilename.galleryWeapon);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Weapon Statistic Panel")]
    static void GenerateGalleryWeaponStatisticPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryWeaponStatisticLanguage> (PanelLanguageFilename.galleryWeaponStatistic);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Bait Panel")]
    static void GenerateGalleryBaitPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryBaitLanguage> (PanelLanguageFilename.galleryBait);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Bait Statistic Panel")]
    static void GenerateGalleryBaitStatisticPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryBaitStatisticLanguage> (PanelLanguageFilename.galleryBaitStatistic);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Flavour Panel")]
    static void GenerateGalleryFlavourPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryFlavourLanguage> (PanelLanguageFilename.galleryFlavour);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Flavour Statistic Panel")]
    static void GenerateGalleryFlavourStatisticPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryFlavourStatisticLanguage> (PanelLanguageFilename.galleryFlavourStatistic);

    [MenuItem ("Data Generator/Language/General Panel/Food Stall Panel")]
    static void GenerateFoodStallPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<FoodStallLanguage> (PanelLanguageFilename.foodStall);

    [MenuItem ("Data Generator/Language/General Panel/Food Stall Purchase Panel")]
    static void GenerateFoodStallPurchasePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<FoodStallPurchaseLanguage> (PanelLanguageFilename.foodStallPurchase);

    [MenuItem ("Data Generator/Language/General Panel/Special Reward")]
    static void GenerateSpecialRewardPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SpecialRewardLanguage> (PanelLanguageFilename.specialReward);

    [MenuItem ("Data Generator/Language/General Panel/Catch Effectiveness Panel")]
    static void GenerateCatchEffectivenessPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CatchEffectivenessLanguage> (PanelLanguageFilename.catchEffectiveness);

    [MenuItem ("Data Generator/Language/General Panel/Tutorial Camp Display Panel")]
    static void GenerateTutorialCampPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<TutorialCampDisplayLanguage> (PanelLanguageFilename.tutorialCamp);

    [MenuItem ("Data Generator/Language/General Panel/Tutorial Hunt Result Panel")]
    static void GenerateTutorialHuntResultPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<HuntResultLanguage> (PanelLanguageFilename.tutorialHuntResult);

    [MenuItem ("Data Generator/Language/General Panel/Tutorial Change Location Panel")]
    static void GenerateTutorialChangeLocationPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<TutorialChangeLocationLanguage> (PanelLanguageFilename.tutorialChangeLocation);

    [MenuItem ("Data Generator/Language/General Panel/Warehouse Panel")]
    static void GenerateWarehousePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<WarehouseLanguage> (PanelLanguageFilename.warehouse);

    [MenuItem ("Data Generator/Language/General Panel/Reward Summary Panel")]
    static void GenerateRewardSummaryPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<RewardSummaryLanguage> (PanelLanguageFilename.rewardSummary);

    [MenuItem ("Data Generator/Language/General Panel/Level Up Panel")]
    static void GenerateLevelUpPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<LevelUpLanguage> (PanelLanguageFilename.levelUp);

    [MenuItem ("Data Generator/Language/General Panel/Smith Panel")]
    static void GenerateSmithPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SmithLanguage> (PanelLanguageFilename.smith);

    [MenuItem ("Data Generator/Language/General Panel/Smith Purchase Panel")]
    static void GenerateSmithPurchasePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SmithPurchaseLanguage> (PanelLanguageFilename.smithPurchase);

    [MenuItem ("Data Generator/Language/General Panel/Ammo Dealer Weapon Panel")]
    static void GenerateAmmoDealerWeaponPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<AmmoDealerWeaponLanguage> (PanelLanguageFilename.ammoDealerWeapon);

    [MenuItem ("Data Generator/Language/General Panel/Ammo Dealer Ammo Panel")]
    static void GenerateAmmoDealerAmmoPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<AmmoDealerAmmmLanguage> (PanelLanguageFilename.ammoDealerAmmo);

    [MenuItem ("Data Generator/Language/General Panel/Ammo Dealer Purchase Panel")]
    static void GenerateAmmoDealerPurchasePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<AmmoDealerPurchaseLanguage> (PanelLanguageFilename.ammoDealerPurchase);

    [MenuItem ("Data Generator/Language/General Panel/Fairy Bakery Panel")]
    static void GenerateFairyBakeryPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<FairyBakeryLanguage> (PanelLanguageFilename.fairyBakery);

    [MenuItem ("Data Generator/Language/General Panel/Fairy Bakery Purchase Panel")]
    static void GenerateFairyBakeryPurchasePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<FairyBakeryPurchaseLanguage> (PanelLanguageFilename.fairyBakeryPurchase);

    [MenuItem ("Data Generator/Language/General Panel/Cage Master Panel")]
    static void GenerateCageMasterPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CageMasterLanguage> (PanelLanguageFilename.cageMaster);

    [MenuItem ("Data Generator/Language/General Panel/Cage Master Purchase Panel")]
    static void GenerateCageMasterPurchasePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CageMasterPurchaseLanguage> (PanelLanguageFilename.cageMasterPurchase);

    [MenuItem ("Data Generator/Language/General Panel/Inventory Category Panel")]
    static void GenerateInventoryCategoryPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<InventoryCategoryLanguage> (PanelLanguageFilename.inventoryCategory);

    [MenuItem ("Data Generator/Language/General Panel/Inventory Panel")]
    static void GenerateInventoryPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<InventoryLanguage> (PanelLanguageFilename.inventory);

    [MenuItem ("Data Generator/Language/General Panel/Material Detail Panel")]
    static void GenerateMaterialDetailPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<MaterialDetailLanguage> (PanelLanguageFilename.materialDetail);

    [MenuItem ("Data Generator/Language/General Panel/Craftsman Panel")]
    static void GenerateCraftsmanPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CraftsmanLanguage> (PanelLanguageFilename.craftsman);

    [MenuItem ("Data Generator/Language/General Panel/Craftsman Purchase Panel")]
    static void GenerateCraftsmanPurchasePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CraftsmanPurchaseLanguage> (PanelLanguageFilename.craftsmanPurchase);

    [MenuItem ("Data Generator/Language/General Panel/Crystal Lab Panel")]
    static void GenerateCrystalLabPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CrystalLabLanguage> (PanelLanguageFilename.crystalLab);

    [MenuItem ("Data Generator/Language/General Panel/Crystal Lab Purchase Panel")]
    static void GenerateCrystalLabPurchasePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CrystalLabPurchaseLanguage> (PanelLanguageFilename.crystalLabPurchase);
    
    [MenuItem ("Data Generator/Language/General Panel/Accessory Maker Panel")]
    static void GenerateAccessoryMakerPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<AccessoryMakerLanguage> (PanelLanguageFilename.accessoryMaker);

    [MenuItem ("Data Generator/Language/General Panel/Accessory Maker Purchase Panel")]
    static void GenerateAccessoryMakerPurchasePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<AccessoryMakerPurchaseLanguage> (PanelLanguageFilename.accessoryMakerPurchase);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Crystal Panel")]
    static void GenerateGalleryCrystalPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryCrystalLanguage> (PanelLanguageFilename.galleryCrystal);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Crystal Statistic Panel")]
    static void GenerateGalleryCrystalStatisticPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryCrystalStatisticLanguage> (PanelLanguageFilename.galleryCrystalStatistic);
    
    [MenuItem ("Data Generator/Language/General Panel/Gallery Accessory Panel")]
    static void GenerateGalleryAccessoryPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryAccessoryLanguage> (PanelLanguageFilename.galleryAccessory);

    [MenuItem ("Data Generator/Language/General Panel/Gallery Accessory Statistic Panel")]
    static void GenerateGalleryAccessoryStatisticPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GalleryyAccessoryStatisticLanguage> (PanelLanguageFilename.galleryAccessoryStatistic);
    
    [MenuItem ("Data Generator/Language/General Panel/Setting Panel")]
    static void GenerateSettingPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SettingLanguage> (PanelLanguageFilename.setting);

    [MenuItem ("Data Generator/Language/General Panel/Setting Gameplay Panel")]
    static void GenerateSettingGameplayPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SettingGameplayLanguage> (PanelLanguageFilename.gameplaySetting);

    [MenuItem ("Data Generator/Language/General Panel/Setting Backup Save Panel")]
    static void GenerateSettingBackupSavePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SettingBackupSaveLanguage> (PanelLanguageFilename.backupSaveSetting);

    [MenuItem ("Data Generator/Language/General Panel/Setting Restore Save Panel")]
    static void GenerateSettingRestoreSavePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SettingRestoreSaveLanguage> (PanelLanguageFilename.restoreSaveSetting);

    [MenuItem ("Data Generator/Language/General Panel/Setting Delete Save Panel")]
    static void GenerateSettingDeleteSavePanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SettingDeleteSaveLanguage> (PanelLanguageFilename.deleteSaveSetting);

    [MenuItem ("Data Generator/Language/General Panel/Setting Audio Panel")]
    static void GenerateSettingAudioPanelJsonFromData ()
    => EditorJsonGeneratorHelper.GeneratePanelLanguageData<SettingAudioLanguage> (PanelLanguageFilename.audioSetting);

    [MenuItem ("Data Generator/Language/General Panel/Statistic Panel")]
    static void GenerateStatisticPanelJsonFromData ()
    => EditorJsonGeneratorHelper.GeneratePanelLanguageData<StatisticLanguage> (PanelLanguageFilename.statistic);

    [MenuItem ("Data Generator/Language/General Panel/Statistic Gameplay Panel")]
    static void GenerateStatisticGameplayPanelJsonFromData ()
    => EditorJsonGeneratorHelper.GeneratePanelLanguageData<GameplayStatisticLanguage> (PanelLanguageFilename.gameplayStatistic);

    [MenuItem ("Data Generator/Language/General Panel/Statistic Discovery Panel")]
    static void GenerateStatisticDiscoveryPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<DiscoveryStatisticLanguage> (PanelLanguageFilename.discoveryStatistic);
    
    [MenuItem ("Data Generator/Language/General Panel/Credit Panel")]
    static void GenerateCreditPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<CreditLanguage> (PanelLanguageFilename.credit);

    [MenuItem ("Data Generator/Language/General Panel/Fairy Level Up Panel")]
    static void GenerateFairyLevelUpPanelJsonFromData ()
        => EditorJsonGeneratorHelper.GeneratePanelLanguageData<FairyLevelUpLanguage> (PanelLanguageFilename.fairyLevelUp);

}
