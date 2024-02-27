using Mutagen.Bethesda.Skyrim;
using Noggog.StructuredStrings.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectProblematicRecordsForMutagen
{
    internal partial class Program
    {
        static void IndividualBasic(ISkyrimModDisposableGetter mod)
        {
            #region GameSettings
            foreach (var key in mod.GameSettings.FormKeys)
            {
                try
                {
                    mod.GameSettings[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("GameSettings fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion GameSettings
            #region Keywords
            foreach (var key in mod.Keywords.FormKeys)
            {
                try
                {
                    mod.Keywords[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Keywords fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Keywords
            #region LocationReferenceTypes
            foreach (var key in mod.LocationReferenceTypes.FormKeys)
            {
                try
                {
                    mod.LocationReferenceTypes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("LocationReferenceTypes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion LocationReferenceTypes
            #region Actions
            foreach (var key in mod.Actions.FormKeys)
            {
                try
                {
                    mod.Actions[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Actions fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Actions
            #region TextureSets
            foreach (var key in mod.TextureSets.FormKeys)
            {
                try
                {
                    mod.TextureSets[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("TextureSets fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion TextureSets
            #region Globals
            foreach (var key in mod.Globals.FormKeys)
            {
                try
                {
                    mod.Globals[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Globals fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Globals
            #region Classes
            foreach (var key in mod.Classes.FormKeys)
            {
                try
                {
                    mod.Classes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Classes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Classes
            #region Factions
            foreach (var key in mod.Factions.FormKeys)
            {
                try
                {
                    mod.Factions[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Factions fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Factions
            #region HeadParts
            foreach (var key in mod.HeadParts.FormKeys)
            {
                try
                {
                    mod.HeadParts[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("HeadParts fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion HeadParts
            #region Hairs
            foreach (var key in mod.Hairs.FormKeys)
            {
                try
                {
                    mod.Hairs[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Hairs fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Hairs
            #region Eyes
            foreach (var key in mod.Eyes.FormKeys)
            {
                try
                {
                    mod.Eyes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Eyes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Eyes
            #region Races
            foreach (var key in mod.Races.FormKeys)
            {
                try
                {
                    mod.Races[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Races fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Races
            #region SoundMarkers
            foreach (var key in mod.SoundMarkers.FormKeys)
            {
                try
                {
                    mod.SoundMarkers[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("SoundMarkers fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion SoundMarkers
            #region AcousticSpaces
            foreach (var key in mod.AcousticSpaces.FormKeys)
            {
                try
                {
                    mod.AcousticSpaces[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("AcousticSpaces fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion AcousticSpaces
            #region MagicEffects
            foreach (var key in mod.MagicEffects.FormKeys)
            {
                try
                {
                    mod.MagicEffects[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("MagicEffects fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion MagicEffects
            #region LandscapeTextures
            foreach (var key in mod.LandscapeTextures.FormKeys)
            {
                try
                {
                    mod.LandscapeTextures[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("LandscapeTextures fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion LandscapeTextures
            #region ObjectEffects
            foreach (var key in mod.ObjectEffects.FormKeys)
            {
                try
                {
                    mod.ObjectEffects[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ObjectEffects fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ObjectEffects
            #region Spells
            foreach (var key in mod.Spells.FormKeys)
            {
                try
                {
                    mod.Spells[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Spells fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Spells
            #region Scrolls
            foreach (var key in mod.Scrolls.FormKeys)
            {
                try
                {
                    mod.Scrolls[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Scrolls fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Scrolls
            #region Activators
            foreach (var key in mod.Activators.FormKeys)
            {
                try
                {
                    mod.Activators[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Activators fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Activators
            #region TalkingActivators
            foreach (var key in mod.TalkingActivators.FormKeys)
            {
                try
                {
                    mod.TalkingActivators[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("TalkingActivators fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion TalkingActivators
            #region Armors
            foreach (var key in mod.Armors.FormKeys)
            {
                try
                {
                    mod.Armors[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Armors fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Armors
            #region Books
            foreach (var key in mod.Books.FormKeys)
            {
                try
                {
                    mod.Books[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Books fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Books
            #region Containers
            foreach (var key in mod.Containers.FormKeys)
            {
                try
                {
                    mod.Containers[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Containers fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Containers
            #region Doors
            foreach (var key in mod.Doors.FormKeys)
            {
                try
                {
                    mod.Doors[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Doors fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Doors
            #region Ingredients
            foreach (var key in mod.Ingredients.FormKeys)
            {
                try
                {
                    mod.Ingredients[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Ingredients fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Ingredients
            #region Lights
            foreach (var key in mod.Lights.FormKeys)
            {
                try
                {
                    mod.Lights[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Lights fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Lights
            #region MiscItems
            foreach (var key in mod.MiscItems.FormKeys)
            {
                try
                {
                    mod.MiscItems[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("MiscItems fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion MiscItems
            #region AlchemicalApparatuses
            foreach (var key in mod.AlchemicalApparatuses.FormKeys)
            {
                try
                {
                    mod.AlchemicalApparatuses[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("AlchemicalApparatuses fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion AlchemicalApparatuses
            #region Statics
            foreach (var key in mod.Statics.FormKeys)
            {
                try
                {
                    mod.Statics[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Statics fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Statics
            #region MoveableStatics
            foreach (var key in mod.MoveableStatics.FormKeys)
            {
                try
                {
                    mod.MoveableStatics[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("MoveableStatics fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion MoveableStatics
            #region Grasses
            foreach (var key in mod.Grasses.FormKeys)
            {
                try
                {
                    mod.Grasses[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Grasses fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Grasses
            #region Trees
            foreach (var key in mod.Trees.FormKeys)
            {
                try
                {
                    mod.Trees[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Trees fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Trees
            #region Florae
            foreach (var key in mod.Florae.FormKeys)
            {
                try
                {
                    mod.Florae[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Florae fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Florae
            #region Furniture
            foreach (var key in mod.Furniture.FormKeys)
            {
                try
                {
                    mod.Furniture[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Furniture fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Furniture
            #region Weapons
            foreach (var key in mod.Weapons.FormKeys)
            {
                try
                {
                    mod.Weapons[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Weapons fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Weapons
            #region Ammunitions
            foreach (var key in mod.Ammunitions.FormKeys)
            {
                try
                {
                    mod.Ammunitions[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Ammunitions fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Ammunitions
            #region Npcs
            foreach (var key in mod.Npcs.FormKeys)
            {
                try
                {
                    mod.Npcs[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Npcs fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Npcs
            #region LeveledNpcs
            foreach (var key in mod.LeveledNpcs.FormKeys)
            {
                try
                {
                    mod.LeveledNpcs[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("LeveledNpcs fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion LeveledNpcs
            #region Keys
            foreach (var key in mod.Keys.FormKeys)
            {
                try
                {
                    mod.Keys[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Keys fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Keys
            #region Ingestibles
            foreach (var key in mod.Ingestibles.FormKeys)
            {
                try
                {
                    mod.Ingestibles[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Ingestibles fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Ingestibles
            #region IdleMarkers
            foreach (var key in mod.IdleMarkers.FormKeys)
            {
                try
                {
                    mod.IdleMarkers[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("IdleMarkers fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion IdleMarkers
            #region ConstructibleObjects
            foreach (var key in mod.ConstructibleObjects.FormKeys)
            {
                try
                {
                    mod.ConstructibleObjects[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ConstructibleObjects fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ConstructibleObjects
            #region Projectiles
            foreach (var key in mod.Projectiles.FormKeys)
            {
                try
                {
                    mod.Projectiles[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Projectiles fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Projectiles
            #region Hazards
            foreach (var key in mod.Hazards.FormKeys)
            {
                try
                {
                    mod.Hazards[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Hazards fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Hazards
            #region SoulGems
            foreach (var key in mod.SoulGems.FormKeys)
            {
                try
                {
                    mod.SoulGems[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("SoulGems fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion SoulGems
            #region LeveledItems
            foreach (var key in mod.LeveledItems.FormKeys)
            {
                try
                {
                    mod.LeveledItems[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("LeveledItems fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion LeveledItems
            #region Weathers
            foreach (var key in mod.Weathers.FormKeys)
            {
                try
                {
                    mod.Weathers[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Weathers fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Weathers
            #region Climates
            foreach (var key in mod.Climates.FormKeys)
            {
                try
                {
                    mod.Climates[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Climates fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Climates
            #region ShaderParticleGeometries
            foreach (var key in mod.ShaderParticleGeometries.FormKeys)
            {
                try
                {
                    mod.ShaderParticleGeometries[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ShaderParticleGeometries fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ShaderParticleGeometries
            #region VisualEffects
            foreach (var key in mod.VisualEffects.FormKeys)
            {
                try
                {
                    mod.VisualEffects[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("VisualEffects fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion VisualEffects
            #region Regions
            foreach (var key in mod.Regions.FormKeys)
            {
                try
                {
                    mod.Regions[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Regions fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Regions
            #region NavigationMeshInfoMaps
            foreach (var key in mod.NavigationMeshInfoMaps.FormKeys)
            {
                try
                {
                    mod.NavigationMeshInfoMaps[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("NavigationMeshInfoMaps fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion NavigationMeshInfoMaps
            #region Quests
            foreach (var key in mod.Quests.FormKeys)
            {
                try
                {
                    mod.Quests[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Quests fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Quests
            #region IdleAnimations
            foreach (var key in mod.IdleAnimations.FormKeys)
            {
                try
                {
                    mod.IdleAnimations[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("IdleAnimations fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion IdleAnimations
            #region Packages
            foreach (var key in mod.Packages.FormKeys)
            {
                try
                {
                    mod.Packages[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Packages fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Packages
            #region CombatStyles
            foreach (var key in mod.CombatStyles.FormKeys)
            {
                try
                {
                    mod.CombatStyles[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("CombatStyles fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion CombatStyles
            #region LoadScreens
            foreach (var key in mod.LoadScreens.FormKeys)
            {
                try
                {
                    mod.LoadScreens[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("LoadScreens fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion LoadScreens
            #region LeveledSpells
            foreach (var key in mod.LeveledSpells.FormKeys)
            {
                try
                {
                    mod.LeveledSpells[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("LeveledSpells fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion LeveledSpells
            #region AnimatedObjects
            foreach (var key in mod.AnimatedObjects.FormKeys)
            {
                try
                {
                    mod.AnimatedObjects[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("AnimatedObjects fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion AnimatedObjects
            #region Waters
            foreach (var key in mod.Waters.FormKeys)
            {
                try
                {
                    mod.Waters[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Waters fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Waters
            #region EffectShaders
            foreach (var key in mod.EffectShaders.FormKeys)
            {
                try
                {
                    mod.EffectShaders[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("EffectShaders fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion EffectShaders
            #region Explosions
            foreach (var key in mod.Explosions.FormKeys)
            {
                try
                {
                    mod.Explosions[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Explosions fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Explosions
            #region Debris
            foreach (var key in mod.Debris.FormKeys)
            {
                try
                {
                    mod.Debris[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Debris fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Debris
            #region ImageSpaces
            foreach (var key in mod.ImageSpaces.FormKeys)
            {
                try
                {
                    mod.ImageSpaces[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ImageSpaces fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ImageSpaces
            #region ImageSpaceAdapters
            foreach (var key in mod.ImageSpaceAdapters.FormKeys)
            {
                try
                {
                    mod.ImageSpaceAdapters[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ImageSpaceAdapters fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ImageSpaceAdapters
            #region FormLists
            foreach (var key in mod.FormLists.FormKeys)
            {
                try
                {
                    mod.FormLists[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("FormLists fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion FormLists
            #region Perks
            foreach (var key in mod.Perks.FormKeys)
            {
                try
                {
                    mod.Perks[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Perks fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Perks
            #region BodyParts
            foreach (var key in mod.BodyParts.FormKeys)
            {
                try
                {
                    mod.BodyParts[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("BodyParts fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion BodyParts
            #region AddonNodes
            foreach (var key in mod.AddonNodes.FormKeys)
            {
                try
                {
                    mod.AddonNodes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("AddonNodes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion AddonNodes
            #region ActorValueInformation
            foreach (var key in mod.ActorValueInformation.FormKeys)
            {
                try
                {
                    mod.ActorValueInformation[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ActorValueInformation fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ActorValueInformation
            #region CameraShots
            foreach (var key in mod.CameraShots.FormKeys)
            {
                try
                {
                    mod.CameraShots[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("CameraShots fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion CameraShots
            #region CameraPaths
            foreach (var key in mod.CameraPaths.FormKeys)
            {
                try
                {
                    mod.CameraPaths[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("CameraPaths fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion CameraPaths
            #region VoiceTypes
            foreach (var key in mod.VoiceTypes.FormKeys)
            {
                try
                {
                    mod.VoiceTypes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("VoiceTypes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion VoiceTypes
            #region MaterialTypes
            foreach (var key in mod.MaterialTypes.FormKeys)
            {
                try
                {
                    mod.MaterialTypes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("MaterialTypes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion MaterialTypes
            #region Impacts
            foreach (var key in mod.Impacts.FormKeys)
            {
                try
                {
                    mod.Impacts[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Impacts fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Impacts
            #region ImpactDataSets
            foreach (var key in mod.ImpactDataSets.FormKeys)
            {
                try
                {
                    mod.ImpactDataSets[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ImpactDataSets fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ImpactDataSets
            #region ArmorAddons
            foreach (var key in mod.ArmorAddons.FormKeys)
            {
                try
                {
                    mod.ArmorAddons[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ArmorAddons fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ArmorAddons
            #region EncounterZones
            foreach (var key in mod.EncounterZones.FormKeys)
            {
                try
                {
                    mod.EncounterZones[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("EncounterZones fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion EncounterZones
            #region Locations
            foreach (var key in mod.Locations.FormKeys)
            {
                try
                {
                    mod.Locations[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Locations fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Locations
            #region Messages
            foreach (var key in mod.Messages.FormKeys)
            {
                try
                {
                    mod.Messages[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Messages fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Messages
            #region DefaultObjectManagers
            foreach (var key in mod.DefaultObjectManagers.FormKeys)
            {
                try
                {
                    mod.DefaultObjectManagers[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("DefaultObjectManagers fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion DefaultObjectManagers
            #region LightingTemplates
            foreach (var key in mod.LightingTemplates.FormKeys)
            {
                try
                {
                    mod.LightingTemplates[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("LightingTemplates fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion LightingTemplates
            #region MusicTypes
            foreach (var key in mod.MusicTypes.FormKeys)
            {
                try
                {
                    mod.MusicTypes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("MusicTypes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion MusicTypes
            #region Footsteps
            foreach (var key in mod.Footsteps.FormKeys)
            {
                try
                {
                    mod.Footsteps[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Footsteps fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Footsteps
            #region FootstepSets
            foreach (var key in mod.FootstepSets.FormKeys)
            {
                try
                {
                    mod.FootstepSets[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("FootstepSets fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion FootstepSets
            #region StoryManagerBranchNodes
            foreach (var key in mod.StoryManagerBranchNodes.FormKeys)
            {
                try
                {
                    mod.StoryManagerBranchNodes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("StoryManagerBranchNodes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion StoryManagerBranchNodes
            #region StoryManagerQuestNodes
            foreach (var key in mod.StoryManagerQuestNodes.FormKeys)
            {
                try
                {
                    mod.StoryManagerQuestNodes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("StoryManagerQuestNodes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion StoryManagerQuestNodes
            #region StoryManagerEventNodes
            foreach (var key in mod.StoryManagerEventNodes.FormKeys)
            {
                try
                {
                    mod.StoryManagerEventNodes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("StoryManagerEventNodes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion StoryManagerEventNodes
            #region DialogBranches
            foreach (var key in mod.DialogBranches.FormKeys)
            {
                try
                {
                    mod.DialogBranches[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("DialogBranches fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion DialogBranches
            #region MusicTracks
            foreach (var key in mod.MusicTracks.FormKeys)
            {
                try
                {
                    mod.MusicTracks[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("MusicTracks fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion MusicTracks
            #region DialogViews
            foreach (var key in mod.DialogViews.FormKeys)
            {
                try
                {
                    mod.DialogViews[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("DialogViews fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion DialogViews
            #region WordsOfPower
            foreach (var key in mod.WordsOfPower.FormKeys)
            {
                try
                {
                    mod.WordsOfPower[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("WordsOfPower fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion WordsOfPower
            #region Shouts
            foreach (var key in mod.Shouts.FormKeys)
            {
                try
                {
                    mod.Shouts[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Shouts fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Shouts
            #region EquipTypes
            foreach (var key in mod.EquipTypes.FormKeys)
            {
                try
                {
                    mod.EquipTypes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("EquipTypes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion EquipTypes
            #region Relationships
            foreach (var key in mod.Relationships.FormKeys)
            {
                try
                {
                    mod.Relationships[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Relationships fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Relationships
            #region Scenes
            foreach (var key in mod.Scenes.FormKeys)
            {
                try
                {
                    mod.Scenes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Scenes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Scenes
            #region AssociationTypes
            foreach (var key in mod.AssociationTypes.FormKeys)
            {
                try
                {
                    mod.AssociationTypes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("AssociationTypes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion AssociationTypes
            #region Outfits
            foreach (var key in mod.Outfits.FormKeys)
            {
                try
                {
                    mod.Outfits[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Outfits fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Outfits
            #region ArtObjects
            foreach (var key in mod.ArtObjects.FormKeys)
            {
                try
                {
                    mod.ArtObjects[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ArtObjects fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ArtObjects
            #region MaterialObjects
            foreach (var key in mod.MaterialObjects.FormKeys)
            {
                try
                {
                    mod.MaterialObjects[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("MaterialObjects fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion MaterialObjects
            #region MovementTypes
            foreach (var key in mod.MovementTypes.FormKeys)
            {
                try
                {
                    mod.MovementTypes[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("MovementTypes fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion MovementTypes
            #region SoundDescriptors
            foreach (var key in mod.SoundDescriptors.FormKeys)
            {
                try
                {
                    mod.SoundDescriptors[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("SoundDescriptors fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion SoundDescriptors
            #region DualCastData
            foreach (var key in mod.DualCastData.FormKeys)
            {
                try
                {
                    mod.DualCastData[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("DualCastData fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion DualCastData
            #region SoundCategories
            foreach (var key in mod.SoundCategories.FormKeys)
            {
                try
                {
                    mod.SoundCategories[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("SoundCategories fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion SoundCategories
            #region SoundOutputModels
            foreach (var key in mod.SoundOutputModels.FormKeys)
            {
                try
                {
                    mod.SoundOutputModels[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("SoundOutputModels fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion SoundOutputModels
            #region CollisionLayers
            foreach (var key in mod.CollisionLayers.FormKeys)
            {
                try
                {
                    mod.CollisionLayers[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("CollisionLayers fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion CollisionLayers
            #region Colors
            foreach (var key in mod.Colors.FormKeys)
            {
                try
                {
                    mod.Colors[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("Colors fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Colors
            #region ReverbParameters
            foreach (var key in mod.ReverbParameters.FormKeys)
            {
                try
                {
                    mod.ReverbParameters[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("ReverbParameters fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion ReverbParameters
            #region VolumetricLightings
            foreach (var key in mod.VolumetricLightings.FormKeys)
            {
                try
                {
                    mod.VolumetricLightings[key].DeepCopy();
                }
                catch (Exception ex)
                {
                    WriteLine("VolumetricLightings fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion VolumetricLightings
            IndividualNested(mod);
        }

        static void IndividualNested(ISkyrimModDisposableGetter mod)
        {
            #region Cells
            foreach (var cellBlock in mod.Cells)
            {
                try
                {
                    foreach (var cellSubBlock in cellBlock.SubBlocks)
                    {
                        try
                        {
                            foreach (var cell in cellSubBlock.Cells)
                            {
                                try
                                {
                                    foreach (var persistent in cell.Persistent) ;
                                    
                                }
                                catch (Exception ex)
                                {
                                    WriteLine("Persistant List of Placed items fail in cell " + cell.FormKey);
                                    WriteLine(ex.Message);
                                    WriteLine(ex.StackTrace!);
                                    WriteLine("\n\n\n");
                                }

                                try
                                {
                                    foreach (var temp in cell.Temporary) ;

                                }
                                catch (Exception ex)
                                {
                                    WriteLine("Temporary List of Placed items fail in cell " + cell.FormKey);
                                    WriteLine(ex.Message);
                                    WriteLine(ex.StackTrace!);
                                    WriteLine("\n\n\n");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            WriteLine("Cell block number fail on " + cellBlock.BlockNumber);
                            WriteLine("Cell block sub number fail on " + cellSubBlock.BlockNumber);
                            WriteLine(ex.Message);
                            WriteLine(ex.StackTrace!);
                            WriteLine("\n\n\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    WriteLine("Cell block number fail on " + cellBlock.BlockNumber);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Cells

            #region Worldspaces
            foreach (var key in mod.Worldspaces.FormKeys)
            {
                try
                {
                    var worldspace = mod.Worldspaces[key];
                    foreach (var worldspaceBlock in worldspace.SubCells)
                    {
                        try
                        {
                            foreach(var worldspaceSubBlock in worldspaceBlock.Items)
                            {
                                try
                                {
                                    foreach(var cell in worldspaceSubBlock.Items)
                                    {
                                        try
                                        {
                                            foreach (var persistent in cell.Persistent) ;

                                        }
                                        catch (Exception ex)
                                        {
                                            WriteLine("Persistant List of Placed items fail in cell " + cell.FormKey);
                                            WriteLine(ex.Message);
                                            WriteLine(ex.StackTrace!);
                                            WriteLine("\n\n\n");
                                        }

                                        try
                                        {
                                            foreach (var temp in cell.Temporary) ;

                                        }
                                        catch (Exception ex)
                                        {
                                            WriteLine("Temporary List of Placed items fail in cell " + cell.FormKey);
                                            WriteLine(ex.Message);
                                            WriteLine(ex.StackTrace!);
                                            WriteLine("\n\n\n");
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    WriteLine("Worldspace Block fail in X:" + worldspaceBlock.BlockNumberX + " Y:" + worldspaceBlock.BlockNumberY);
                                    WriteLine("Worldspace Sub Block fail in X:" + worldspaceSubBlock.BlockNumberX + " Y:" + worldspaceSubBlock.BlockNumberY);
                                    WriteLine("Can not locate the problem cell");
                                    WriteLine(ex.Message);
                                    WriteLine(ex.StackTrace!);
                                    WriteLine("\n\n\n");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            WriteLine("Worldspace Sub Block fail in main Block X:" + worldspaceBlock.BlockNumberX + " Y:" + worldspaceBlock.BlockNumberY);
                            WriteLine(ex.Message);
                            WriteLine(ex.StackTrace!);
                            WriteLine("\n\n\n");
                        }
                    }
                }
                catch (Exception ex)
                {
                    WriteLine("Worldspaces fail on " + key);
                    WriteLine("Its possable that the fail came from inside a Block.");
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion Worldspaces

            #region DialogTopics
            foreach (var key in mod.DialogTopics.FormKeys)
            {
                try
                {
                    var topic = mod.DialogTopics[key];
                    try
                    {
                        foreach (var respons in topic.Responses) { }
                    }
                    catch (Exception ex)
                    {
                        WriteLine("Responses fail in Topic " + key);
                        WriteLine(ex.Message);
                        WriteLine(ex.StackTrace!);
                        WriteLine("\n\n\n");
                    }
                }
                catch (Exception ex)
                {
                    WriteLine("DialogTopics fail on " + key);
                    WriteLine(ex.Message);
                    WriteLine(ex.StackTrace!);
                    WriteLine("\n\n\n");
                }
            }
            #endregion DialogTopics
        }
    }
}
