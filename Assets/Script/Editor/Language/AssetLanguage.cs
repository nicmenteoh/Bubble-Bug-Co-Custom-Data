using ProjectPestHuntData;
using UnityEditor;

public class AssetLanguage
{

    [MenuItem ("Data Generator/Language/Asset/Unit")]
    static void GenerateUnitLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Unit Language", AssetLanguageFilename.unit);

    [MenuItem ("Data Generator/Language/Asset/Unit Family")]
    static void GenerateUnitFamilyLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Unit Family Language", AssetLanguageFilename.unitFamily);

    [MenuItem ("Data Generator/Language/Asset/Fairy")]
    static void GenerateFairyLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Fairy Language", AssetLanguageFilename.fairy);

    [MenuItem ("Data Generator/Language/Asset/Fairy Food")]
    static void GenerateFairyFoodLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Fairy Food Language", AssetLanguageFilename.fairyFood);

    [MenuItem ("Data Generator/Language/Asset/Crystal")]
    static void GenerateCrystalLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Crystal Language", AssetLanguageFilename.crystal);

    [MenuItem ("Data Generator/Language/Asset/Bait")]
    static void GenerateBaitLanguageJson ()
    => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Bait Language", AssetLanguageFilename.bait);

    [MenuItem ("Data Generator/Language/Asset/Flavour")]
    static void GenerateFlavourLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Flavour Language", AssetLanguageFilename.flavour);

    [MenuItem ("Data Generator/Language/Asset/Weapon")]
    static void GenerateWeaponLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Weapon Language", AssetLanguageFilename.weapon);

    [MenuItem ("Data Generator/Language/Asset/Ammo")]
    static void GenerateAmmoLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Ammo Language", AssetLanguageFilename.ammo);

    [MenuItem ("Data Generator/Language/Asset/Accessory")]
    static void GenerateAccessoryLanguageJson ()
    => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Accessory Language", AssetLanguageFilename.accessory);

    [MenuItem ("Data Generator/Language/Asset/Material")]
    static void GenerateMaterialLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Material Language", AssetLanguageFilename.material);

    [MenuItem ("Data Generator/Language/Asset/Effect")]
    static void GenerateEffectLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Effect Language", AssetLanguageFilename.effect);

    [MenuItem ("Data Generator/Language/Asset/Hunt Result Message")]
    static void GenerateHuntResultMessageLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Hunt Result Language", AssetLanguageFilename.huntResult);

    [MenuItem ("Data Generator/Language/Asset/Elemental")]
    static void GenerateElementalLanguageJson ()
    => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Elemental Language", AssetLanguageFilename.elemental);

    [MenuItem ("Data Generator/Language/Asset/Rank")]
    static void GenerateRankLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Rank Language", AssetLanguageFilename.rank);

    [MenuItem ("Data Generator/Language/Asset/Location")]
    static void GenerateLocationLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Location Language", AssetLanguageFilename.location);
    
    [MenuItem ("Data Generator/Language/Asset/Region")]
    static void GenerateRegionLanguageJson ()
        => EditorJsonGeneratorHelper.GenerateAssetLanguageData ("Region Language", AssetLanguageFilename.region);
        
}
