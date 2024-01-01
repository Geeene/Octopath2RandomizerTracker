using Octopath2RandomizerTracker.Commands;
using Octopath2RandomizerTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Octopath2RandomizerTracker.ViewModels
{
    public class MainViewModel : ViewModelBase {

        private readonly ParentKeyItemCategoryViewModel _Story;
        private readonly ParentKeyItemCategoryViewModel _CrossedPaths;
        private readonly ParentKeyItemCategoryViewModel _Characters;
        private readonly ParentKeyItemCategoryViewModel _SideStories;
        private readonly ParentKeyItemCategoryViewModel _MainStory;
        private readonly ParentKeyItemCategoryViewModel _MiscKeyItems;
        public ParentKeyItemCategoryViewModel Characters => _Characters;
        public ParentKeyItemCategoryViewModel Story => _Story;
        public ParentKeyItemCategoryViewModel Crossed_Paths => _CrossedPaths;
        public ParentKeyItemCategoryViewModel Side_Stories => _SideStories;
        public ParentKeyItemCategoryViewModel Main_Story => _MainStory;
        public ParentKeyItemCategoryViewModel Misc_Key_Items => _MiscKeyItems;

        private KeyItemViewModel _CurrentlyEditedKeyItem { get; set;}
        public KeyItemViewModel CurrentlyEditedKeyItem => _CurrentlyEditedKeyItem;


        public MainViewModel()
        {
            // Initialize all the Properties
            _Characters = InitializeCharacterParentCategory();
            _Story = InitializeStoryChapters();
            _CrossedPaths = InitializeCrossedPaths();
            _MainStory = InitializeMainStory();
            _SideStories = InitializeSideStories();
            _MiscKeyItems = InitializeMiscKeyItems();
        }

        private static ParentKeyItemCategoryViewModel InitializeCharacterParentCategory()
        {
            var model = new ParentKeyItemCategoryViewModel("Characters");
            KeyItemCategoryViewModel ochette = new(new("Ochette"));
            ochette.AddKeyItem(new("Images/Ochette/Ochette_Generic.png", "Recruit Ochette"));
            ochette.AddKeyItem(new("Images/Skill_Icons/Buff.png", "Visit the Altar of the Huntress and received the EX-Skill 'Indomitable Beast'"));
            ochette.AddKeyItem(new("Images/Skill_Icons/Physical_Attack.png", "Finished Ochette Chapter 3 and received the EX-Skill 'Provoke Beasts'"));
            model.AddSubcategory(ochette);

            KeyItemCategoryViewModel castti = new(new("Castti"));
            castti.AddKeyItem(new("Images/Castti/Castti_Generic.png", "Recruit Castti"));
            castti.AddKeyItem(new("Images/Skill_Icons/Physical_Attack.png", "Visit the Altar of the Charitable and receive the EX-Skill 'Drastic Measures'"));
            castti.AddKeyItem(new("Images/Skill_Icons/Debuff.png", "Finish Castti Chapter 4 and receive the EX-Skill 'Remedy'"));
            model.AddSubcategory(castti);

            KeyItemCategoryViewModel temenos = new(new("Temenos"));
            temenos.AddKeyItem(new("Images/Temenos/Temenos_Generic.png", "Recruit Temenos"));
            temenos.AddKeyItem(new("Images/Skill_Icons/Recovery.png", "Visit the Altar of the Flamebringer and receive the EX-Skill 'Prayer for Plenty'"));
            temenos.AddKeyItem(new("Images/Skill_Icons/Elemental_Attack.png", "Finish Temenos Chapter 4 and receive the EX-Skill 'Heavenly Shine'"));
            model.AddSubcategory(temenos);

            KeyItemCategoryViewModel osvald = new(new("Osvald"));
            osvald.AddKeyItem(new("Images/Osvald/Osvald_Generic.png", "Recruit Osvald"));
            osvald.AddKeyItem(new("Images/Skill_Icons/Buff.png", "Visit the Altar of the Scholarking and receive the EX-Skill 'Teach'"));
            osvald.AddKeyItem(new("Images/Skill_Icons/Elemental_Attack.png", "Finish Osvald Chapter 5 and receive the EX-Skill 'One True Magic'"));
            model.AddSubcategory(osvald);

            KeyItemCategoryViewModel partitio = new(new("Partitio"));
            partitio.AddKeyItem(new("Images/Partitio/Partitio_Generic.png", "Recruit Partitio"));
            partitio.AddKeyItem(new("Images/Skill_Icons/Debuff.png", "Visit the Altar of the Trader and receive the EX-Skill 'Negotiate Schedule'"));
            partitio.AddKeyItem(new("Images/Skill_Icons/Buff.png", "Finish Partitio Chapter 4 and receive the EX-Skill 'Share SP'"));
            model.AddSubcategory(partitio);

            KeyItemCategoryViewModel agnea = new(new("Agnea"));
            agnea.AddKeyItem(new("Images/Agnea/Agnea_Generic.png", "Recruit Agnea"));
            agnea.AddKeyItem(new("Images/Skill_Icons/Elemental_Attack.png", "Visit the Altar of the Lady of Grace and receive the EX-Skill 'Windy Refrain'"));
            agnea.AddKeyItem(new("Images/Skill_Icons/Buff.png", "Finish Agnea Chapter 5 and receive the EX-Skill 'Song of Hope'"));
            model.AddSubcategory(agnea);

            KeyItemCategoryViewModel throne = new(new("Throné"));
            throne.AddKeyItem(new("Images/Throne/Throne_Generic.png", "Recruit Throné"));
            throne.AddKeyItem(new("Images/Skill_Icons/Elemental_Attack.png", "Visist the Altar of the Prince of Thieves and receive the EX-Skill 'Veil of Darkness'"));
            throne.AddKeyItem(new("Images/Skill_Icons/Buff.png", "Finish Throné Chapter 4 and receive the EX-Skill 'Disguise'"));
            model.AddSubcategory(throne);

            KeyItemCategoryViewModel hikari = new(new("Hikari"));
            hikari.AddKeyItem(new("Images/Hikari/Hikari_Generic.png", "Recruit Hikari"));
            hikari.AddKeyItem(new("Images/Skill_Icons/Buff.png", "Visist the Altar of the Thunderblade and receive the EX-Skill 'Ultimate Stance'"));
            hikari.AddKeyItem(new("Images/Skill_Icons/Physical_Attack.png", "Finish Hikari Chapter 5 and receive the EX-Skill 'Shinjumonjigiri'"));
            model.AddSubcategory(hikari);

            return model;
        }

        private static ParentKeyItemCategoryViewModel InitializeStoryChapters()
        {
            var model = new ParentKeyItemCategoryViewModel("Character Stories");
            // Ochette Key Items
            KeyItemCategory ochette = new("Ochette");
            ochette.AddKeyItem(new("Images/Ochette/Chapter_2_Cateracta.png", "Ochette Chapter 2 Cateracta"));
            ochette.AddKeyItem(new("Images/Ochette/Chapter_2_Terra.png", "Ochette Chapter 2 Terra"));
            ochette.AddKeyItem(new("Images/Ochette/Chapter_2_Glacis.png", "Ochette Chapter 2 Glacis"));
            ochette.AddKeyItem(new("Images/Ochette/Chapter_3.png", "Ochette Chapter 3"));
            ochette.AddKeyItem(new("Images/Ochette/Acta.png", "Obtained Acta", 0, 1));
            ochette.AddKeyItem(new("Images/Ochette/Terra.png", "Obtained Terra", 0, 1));
            ochette.AddKeyItem(new("Images/Ochette/Glacis.png", "Obtained Glacis", 0, 1));
            model.AddSubcategory(new(ochette));

            // Castti Key Items
            KeyItemCategory castti = new("Castti");
            castti.AddKeyItem(new("Images/Castti/Chapter_2_Sai.png", "Castti Chapter 2 Sai"));
            castti.AddKeyItem(new("Images/Castti/Chapter_2_Winterbloom.png", "Castti Chapter 2 Winterbloom"));
            castti.AddKeyItem(new("Images/Castti/Rosas Medicine.png", "Rosa's Medicine"));
            castti.AddKeyItem(new("Images/Castti/Chapter_3.png", "Castti Chapter 3"));
            castti.AddKeyItem(new("Images/Castti/Chapter_4.png", "Castti Chapter 4"));
            model.AddSubcategory(new(castti));

            // Temenos Key Items
            KeyItemCategory temenos = new("Temenos");
            temenos.AddKeyItem(new("Images/Temenos/Chapter_2.png", "Temenos Chapter 2"));
            temenos.AddKeyItem(new("Images/Temenos/Culprits_true_identity.png", "The Culprit's True Identity"));
            temenos.AddKeyItem(new("Images/Temenos/Chapter_3_Crackridge.png", "Temenos Chapter 3 Crackridge"));
            temenos.AddKeyItem(new("Images/Temenos/Mysterious_Notebook.png", "Mysterious Notebook"));
            temenos.AddKeyItem(new("Images/Temenos/Chapter_3_Stormhail.png", "Temenos Chapter 3 Stormhail"));
            temenos.AddKeyItem(new("Images/Temenos/Kaldenas_Notebook.png", "Kaldena's Notebook", 0, 1));
            temenos.AddKeyItem(new("Images/Temenos/Chapter_4.png", "Temenos Chapter 4"));
            model.AddSubcategory(new(temenos));

            // Throne Key Items
            KeyItemCategory throne = new("Throné");
            throne.AddKeyItem(new("Images/Throne/Chapter_2_Mother.png", "Throne Chapter 2 Mother"));
            throne.AddKeyItem(new("Images/Throne/Horse_Coin.png", "Horse Coin"));
            throne.AddKeyItem(new("Images/Throne/Masked_Child.png", "Mask"));
            throne.AddKeyItem(new("Images/Throne/Chapter_2_Father.png", "Throne Chapter 2 Father"));
            throne.AddKeyItem(new("Images/Throne/Chapter_3_Mother.png", "Throne Chapter 3 Mother"));
            throne.AddKeyItem(new("Images/Throne/Habit.png", "Habit"));
            throne.AddKeyItem(new("Images/Throne/Chapter_3_Father.png", "Throne Chapter 3 Father"));
            throne.AddKeyItem(new("Images/Throne/Mother_and_Father_keys.png", "Mother's and Father's Key", 0, 2));
            throne.AddKeyItem(new("Images/Throne/Chapter_4.png", "Throné Chapter 4"));
            model.AddSubcategory(new(throne));

            // Partitio Key Items
            KeyItemCategory partitio = new("Partitio");
            partitio.AddKeyItem(new("Images/Partitio/Chapter_2.png", "Partitio Chapter 2"));
            partitio.AddKeyItem(new("Images/Partitio/Clockite.png", "Clockite"));
            partitio.AddKeyItem(new("Images/Partitio/Chapter_3.png", "Partitio Chapter 3"));
            partitio.AddKeyItem(new("Images/Partitio/Boat.png", "The Grand Terry", 1, 2));
            partitio.AddKeyItem(new("Images/Partitio/SOC_Grammophone.png", "Grammophone", 1, 2));
            partitio.AddKeyItem(new("Images/Partitio/SOC_Merchantile_Manuscript_Key.png", "Merchantile Manuscript Key", 1, 2));
            partitio.AddKeyItem(new("Images/Partitio/Chapter_4.png", "Partitio Chapter 4"));
            model.AddSubcategory(new(partitio));

            // Osvald Key Items
            KeyItemCategory osvald = new("Osvald");
            osvald.AddKeyItem(new("Images/Osvald/Chapter_3.png", "Osvald Chapter 3"));
            osvald.AddKeyItem(new("Images/Osvald/Chapter_4.png", "Osvald Chapter 4"));
            osvald.AddKeyItem(new("Images/Osvald/Library_Information.png", "Information: Library Rumor, Harvey's Whereabouts, and An Eyewitness to Harvey", 1, 3));
            osvald.AddKeyItem(new("Images/Osvald/Chapter_5.png", "Osvald Chapter 5"));
            osvald.AddKeyItem(new("Images/Osvald/Black_Crystal.png", "Black Crystals", 5));
            model.AddSubcategory(new(osvald));

            // Agnea Key Items
            KeyItemCategory agnea = new("Agnea");
            agnea.AddKeyItem(new("Images/Agnea/Chapter_2.png", "Agnea Chapter 2"));
            agnea.AddKeyItem(new("Images/Agnea/Theater_Ticket.png", "Theater Ticket"));
            agnea.AddKeyItem(new("Images/Agnea/Chapter_3.png", "Agnea Chapter 3"));
            agnea.AddKeyItem(new("Images/Agnea/Wooden_Sword.png", "Wooden Sword"));
            agnea.AddKeyItem(new("Images/Agnea/Chapter_4.png", "Agnea Chapter 4"));
            agnea.AddKeyItem(new("Images/Agnea/Old_Man_Cute_Shoes_Agnea_4.png", "Cute Shoes"));
            agnea.AddKeyItem(new("Images/Agnea/Chapter_5.png", "Agnea Chapter 5"));
            model.AddSubcategory(new(agnea));

            // Hikari Key Items
            KeyItemCategory hikari = new("Hikari");
            hikari.AddKeyItem(new("Images/Hikari/Chapter_2.png", "Hikari Chapter 2"));
            hikari.AddKeyItem(new("Images/Hikari/Chapter_3.png", "Hikari Chapter 3"));
            hikari.AddKeyItem(new("Images/Hikari/Merchant_NPC_Hikari_3.png", "Weapon Deal Details"));
            hikari.AddKeyItem(new("Images/Hikari/Chapter_4.png", "Hikari Chapter 4"));
            hikari.AddKeyItem(new("Images/Hikari/Chapter_5.png", "Hikari Chapter 5"));
            model.AddSubcategory(new(hikari));

            return model;
        }

        private static ParentKeyItemCategoryViewModel InitializeCrossedPaths()
        {
            var model = new ParentKeyItemCategoryViewModel("Crossed Paths");


            // Key Items Apothecary & Hunter Crossed Path
            KeyItemCategory apothecaryHunter = new("Apothecary & Hunter");
            apothecaryHunter.AddKeyItem(new("Images/Crossed_Paths/Apothecary_Hunter_1.png", "Apothecary & Hunter 1"));
            apothecaryHunter.AddKeyItem(new("Images/Crossed_Paths/Apothecary_Hunter_2.png", "Apothecary & Hunter 2"));
            model.AddSubcategory(new(apothecaryHunter));

            // Key Items Cleric & Thief Crossed Path
            KeyItemCategory clericThief = new("Cleric & Thief");
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief_1.png", "Cleric & Thief 1"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cloudy Mirror Fragment", 0, 1));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief_2.png", "Cleric & Thief 2"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Folded_Paper.png", "Folded Paper"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cloudy_Mirror.png", "Cloudy Mirror", 0, 1));
            model.AddSubcategory(new(clericThief));

            // Key Items Scholar & Merchant Crossed Path
            KeyItemCategory scholarMerchant = new("Scholar & Merchant");
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant_1.png", "Scholar & Merchant 1"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Mirror, Precision Lense, and Metalworking Tool", 1, 3));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant_2.png", "Scholar & Merchant 2"));
            model.AddSubcategory(new(scholarMerchant));

            // Dancer & Warrior
            KeyItemCategory dancerWarrior = new("Dancer & Warrior");
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer & Warrior 1"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Horse Tail"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer & Warrior 2"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer's Mask, Sacred Wood, and Wine Offering", 1, 3));
            model.AddSubcategory(new(dancerWarrior));

            return model;
        }

        private static ParentKeyItemCategoryViewModel InitializeMainStory() {
            var model = new ParentKeyItemCategoryViewModel("Main Story");
            KeyItemCategory flames = new("Sacred Flames");
            flames.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Sacred Flame Ku"));
            flames.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Sacred Flame Crackridge"));
            flames.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Sacred Flame Toto'haha"));
            flames.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Sacred Flame Flamechurch"));
            model.AddSubcategory(new(flames));


            KeyItemCategory sideStoryNamelessIsle = new("Nameless Isle");
            sideStoryNamelessIsle.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "How to Decipher Unkown Languages"));
            model.AddSubcategory(new(sideStoryNamelessIsle));

            KeyItemCategory sideStoryGalderaQuest = new("Galdera Quest");
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Al's Bag"));
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Return Al's Bag"));
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Return Books to Library"));
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Assist Al's Translation efforts "));
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Defeat Galdera"));
            model.AddSubcategory(new(sideStoryGalderaQuest));

            return model;
        }

        private static ParentKeyItemCategoryViewModel InitializeSideStories() {
            // Side Story Key Items
            ParentKeyItemCategoryViewModel model = new("Side Stories");
            ParentKeyItemCategoryViewModel leaflands = new("Leaflands");
            ParentKeyItemCategoryViewModel wildlands = new("Wildlands");
            ParentKeyItemCategoryViewModel brightlands = new("Brightlands");
            ParentKeyItemCategoryViewModel crestlands = new("Crestlands");
            ParentKeyItemCategoryViewModel totohaha = new("Toto'haha");
            ParentKeyItemCategoryViewModel winterlands = new("Winterlands");
            ParentKeyItemCategoryViewModel hinoeuma = new("Hinoeuma");
            ParentKeyItemCategoryViewModel miscSidestories = new("Misc. Sidestories");
            
            KeyItemCategory sideStoryCropdale = new("Cropdale");
            sideStoryCropdale.AddKeyItem(new("Images/Side_Stories/Well_Iris.png", "Useless Fruit: Well Iris Uses"));
            sideStoryCropdale.AddKeyItem(new("Images/Side_Stories/Grapes_Growing_Tricks.png", "Goading the Grapes: Tricks to Growing Grapes"));
            sideStoryCropdale.AddKeyItem(new("Images/Side_Stories/Crop_Tapestry.png", "Crop Revival: Crop Tapestry Pattern"));
            leaflands.AddSubcategory(new(sideStoryCropdale));

            KeyItemCategory sideStoryWellgrove = new("Wellgrove");
            sideStoryWellgrove.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Misha’s Next Chapter: Man in a Brown Coat, and Garbage Collector", 1, 2));
            leaflands.AddSubcategory(new(sideStoryWellgrove));

            KeyItemCategory sideStoryTimberain = new("Timberain");
            sideStoryTimberain.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Proof of Guilt: Azure Sun Sword"));
            sideStoryTimberain.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Proof of Justice: Stolen Sword"));
            leaflands.AddSubcategory(new(sideStoryTimberain));

            KeyItemCategory sideStoryOresrush = new("Oresrush");
            sideStoryOresrush.AddKeyItem(new("Images/Side_Stories/Joes_Jokes.png", "Wanted: A Good Joke: 3 jokes", 1, 3));
            sideStoryOresrush.AddKeyItem(new("Images/Side_Stories/Sturdy_Pickaxe.png", "The Sword in the Stone: Sturdy Pickaxe"));
            sideStoryOresrush.AddKeyItem(new("Images/Side_Stories/Stocked_Goods.png", "Stolen Goods: Stocked Goods"));
            wildlands.AddSubcategory(new(sideStoryOresrush));

            KeyItemCategory sideStoryCrackridge = new("Crackridge (Harbor)");
            sideStoryCrackridge.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "The Treasures of Ku: Phoenix Fan"));
            sideStoryCrackridge.AddKeyItem(new("Images/Side_Stories/From_the_Far_Reaches_of_Hell.png", "Procuring Peculiar Tomes: From the Far Reaches of Hell"));
            wildlands.AddSubcategory(new(sideStoryCrackridge));

            KeyItemCategory sideStoryGravell = new("Gravell");
            sideStoryGravell.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "The Missing Girl: Cloudy Crystal Bracelet"));
            sideStoryGravell.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Alpione's Next Chapter: Hunting Request"));
            wildlands.AddSubcategory(new(sideStoryGravell));

            KeyItemCategory sideStoryNewDelsta = new("New Delsta");
            sideStoryNewDelsta.AddKeyItem(new("Images/Side_Stories/Deluxe_Crepe.png", "A Young Girl's Wish: Deluxe Crêpe"));
            sideStoryNewDelsta.AddKeyItem(new("Images/Side_Stories/Truth_Of_The_Game_Parlor.png", "A Gambling Man: Truth of the Game Parlor"));
            sideStoryNewDelsta.AddKeyItem(new("Images/Side_Stories/Killers_Motive.png", "Proof of Justice: A Killer's Motive"));
            brightlands.AddSubcategory(new(sideStoryNewDelsta));

            KeyItemCategory sideStoryAbandonedVillage = new("Abandoned Village");
            sideStoryAbandonedVillage.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Descended from Royalty: Nyx Royal Family Tree"));
            brightlands.AddSubcategory(new(sideStoryAbandonedVillage));

            KeyItemCategory sideStorySunkenMaw = new("Sunken Maw");
            sideStorySunkenMaw.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Devilishly Delicious Dish: Special Bait"));
            sideStorySunkenMaw.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Devilishly Delicious Dish: Delsta Devil"));
            brightlands.AddSubcategory(new(sideStorySunkenMaw));

            KeyItemCategory sideStoryFlamechurch = new("Flamechurch");
            sideStoryFlamechurch.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Shirlutto's Next Chapter: Paper Play"));
            sideStoryFlamechurch.AddKeyItem(new(["Images/Side_Stories/Pilgrims_Torches.png", "Images/Side_Stories/Worker_Inventor_Clockbank.png", "Images/Side_Stories/Worker_Inventor_Clockbank.png"], "Pilgrim Protection: 3 Sacred Flame Candles", 1, 3));
            crestlands.AddSubcategory(new(sideStoryFlamechurch));

            KeyItemCategory sideStoryClericGuild = new("Cleric Guild");
            sideStoryClericGuild.AddKeyItem(new("Images/Side_Stories/Apprentice_Cleric.png", "A Young Girl's Wish: Adventures of an Apprentice Cleric’s Sequel"));
            crestlands.AddSubcategory(new(sideStoryClericGuild));

            KeyItemCategory sideStoryMontwise = new("Montwise");
            sideStoryMontwise.AddKeyItem(new("Images/Side_Stories/History_Book.png", "Shirlutto's Next Chapter: History Book"));
            sideStoryMontwise.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Descended from Royalty: Nyx Family History"));
            crestlands.AddSubcategory(new(sideStoryMontwise));

            KeyItemCategory sideStoryMerryHills = new("Merry Hills");
            sideStoryMerryHills.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Mysterious Box: Mysterious Box"));
            crestlands.AddSubcategory(new(sideStoryMerryHills));


            KeyItemCategory sideStoryBeastingBay = new("Beasting Bay");
            sideStoryBeastingBay.AddKeyItem(new("Images/Side_Stories/Bottle_Of_White_Dust.png", "Traveler's Lost and Found: Bottle of White Powder"));
            totohaha.AddSubcategory(new(sideStoryBeastingBay));

            KeyItemCategory sideStoryBeastingVillage = new("Beasting Village");
            sideStoryBeastingVillage.AddKeyItem(new("Images/Side_Stories/Amulet_Of_Affection.png", "Building Bridges: Amulet of Affection"));
            sideStoryBeastingVillage.AddKeyItem(new("Images/Side_Stories/Dispatches_from_Beastling_Island.png", "Procuring Peculiar Tomes: Dispatches from Beastling Island"));
            totohaha.AddSubcategory(new(sideStoryBeastingVillage));

            KeyItemCategory sideStoryTropuhopu = new("Tropu'hopu");
            sideStoryTropuhopu.AddKeyItem(new("Images/Side_Stories/Pretty_Pearls.png", "Pearl Hunt: 4 Pretty Pearls", 4));
            sideStoryTropuhopu.AddKeyItem(new("Images/Side_Stories/Spicy_Chicken.png", "Culinary Cunning: Spicy Chicken Recipe"));
            totohaha.AddSubcategory(new(sideStoryTropuhopu));

            KeyItemCategory sideStoryCapeCold = new("Cape Cold");
            sideStoryCapeCold.AddKeyItem(new("Images/Side_Stories/Silver_Quill.png", "A Present for my Son: Silver Quill"));
            winterlands.AddSubcategory(new(sideStoryCapeCold));

            KeyItemCategory sideStoryWinterbloom = new("Winterbloom");
            sideStoryWinterbloom.AddKeyItem(new("Images/Side_Stories/Melia_Snow_Hares.png", "Melia's Next Chapter: Letter from the Snowhares"));
            winterlands.AddSubcategory(new(sideStoryWinterbloom));

            KeyItemCategory sideStoryStormhail = new("Stormhail");
            sideStoryStormhail.AddKeyItem(new("Images/Side_Stories/Curious_Legend_of_the_Great_Wall.png", "Procuring Peculiar Tomes: The Curious Legends of the Great Wall"));
            sideStoryStormhail.AddKeyItem(new("Images/Side_Stories/Treasured_Necklace.png", "Lingering Love: Treasured Necklace"));
            winterlands.AddSubcategory(new(sideStoryStormhail));

            KeyItemCategory sideStorySai = new("Sai");
            sideStorySai.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Shirlutto's Next Chapter: Lute"));
            sideStorySai.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Veronica's Next Chapter: Dolcinaea and Gifts"));
            hinoeuma.AddSubcategory(new(sideStorySai));

            KeyItemCategory sideStoryKu = new("Ku");
            sideStoryKu.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Mikka’s Next Chapter: Earrings"));
            hinoeuma.AddSubcategory(new(sideStoryKu));

            KeyItemCategory sideStoryCanalbrine = new("Canalbrine");
            sideStoryCanalbrine.AddKeyItem(new("Images/Side_Stories/Dragon_Vase.png", "The Treasures of Ku: Dragon Vase"));
            sideStoryCanalbrine.AddKeyItem(new("Images/Side_Stories/Fort_Orochi_Plans.png", "Plans from a Ruined Nation: Fort Orochi Plans"));
            miscSidestories.AddSubcategory(new(sideStoryCanalbrine));

            KeyItemCategory sideStoryLighthouseIsland = new("Lighthouse Island");
            sideStoryLighthouseIsland.AddKeyItem(new("Images/Side_Stories/Letter_Bottle.png", "The Washed-Up Letter: Message in a Bottle"));
            sideStoryLighthouseIsland.AddKeyItem(new("Images/Side_Stories/Aelmorite_Reflector.png", "Lighthouse Restoration: Aelmorite Reflector"));
            miscSidestories.AddSubcategory(new(sideStoryLighthouseIsland));


            model.AddSubParentCategory(leaflands);
            model.AddSubParentCategory(wildlands);
            model.AddSubParentCategory(hinoeuma);
            model.AddSubParentCategory(miscSidestories);
            model.AddSubParentCategory(winterlands);
            model.AddSubParentCategory(brightlands);
            model.AddSubParentCategory(crestlands);
            model.AddSubParentCategory(totohaha);
            return model;
        }

        private static ParentKeyItemCategoryViewModel InitializeMiscKeyItems()
        {
            var model = new ParentKeyItemCategoryViewModel("Misc Key Items");
            model.AddSubcategory(InitializeLicenses());
            model.AddSubcategory(InitializeRustedWeapons());
            model.AddSubcategory(InitializeInventorItems());
            model.AddSubcategory(InitializeLocationLocks());
            return model;
        }
        private static KeyItemCategoryViewModel InitializeLicenses() {
            var model = new KeyItemCategory("Licenses");
            model.AddKeyItem(new("Images/Jobs/Hunter.png", "Got the Hunter License", 1, 3));
            model.AddKeyItem(new("Images/Jobs/Apothecary.png", "Got the Apothecary License", 1, 3));
            model.AddKeyItem(new("Images/Jobs/Thief.png", "Got the Thief License", 1, 3));
            model.AddKeyItem(new("Images/Jobs/Scholar.png", "Got the Scholar License", 1, 3));
            model.AddKeyItem(new("Images/Jobs/Merchant.png", "Got the Merchant License", 1, 3));
            model.AddKeyItem(new("Images/Jobs/Dancer.png", "Got the Dancer License", 1, 3));
            model.AddKeyItem(new("Images/Jobs/Cleric.png", "Got the Cleric License", 1, 3));
            model.AddKeyItem(new("Images/Jobs/Warrior.png", "Got the Warrior License", 1, 3));
            model.AddKeyItem(new("Images/Jobs/Inventor.png", "Got the Inventor License"));
            model.AddKeyItem(new("Images/Jobs/Armsmaster.png", "Got the Armsmaster License"));
            model.AddKeyItem(new("Images/Jobs/Arcanist.png", "Got the Arcanist License"));
            model.AddKeyItem(new("Images/Jobs/Conjurer.png", "Got the Conjurer License"));
            return new(model);
        }

        private static KeyItemCategoryViewModel InitializeRustedWeapons()
        {
            // Rusted Weapons
            KeyItemCategory rustedWeapons = new("Rusted Weapons");
            rustedWeapons.AddKeyItem(new("Images/Weapons/Sword.png", "Got the Rusty Sword"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Polearm.png", "Got the Rusty Axe"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Dagger.png", "Got the Rusty Polearm"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Axe.png", "Got the Rusty Bow"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Bow.png", "Got the Rusty Dagger"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Staff.png", "Got the Rusty Staff"));
            return new(rustedWeapons);
        }

        private static KeyItemCategoryViewModel InitializeInventorItems()
        {
            // Inventor Items
            KeyItemCategory inventorItems = new("Inventor Items");
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Inventor_Clockbank.png", "Scrap Metal from Clockbank"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Rainbow_Glass_Bottle.png", "Rainbow Glassbottle from Conning Creek"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Miner_Natural_Magnetite.png", "Natural Magnetite from Mines"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Inventor_Clockbank.png", "Tin Toy from Wellgrove"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Ancient_Cog.png", "Ancient Cog from Roque Island"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Mythical_Horn.png", "Mythical Horn from Nameless Village"));
            return new(inventorItems);
        }        
        
        private static KeyItemCategoryViewModel InitializeLocationLocks()
        {
            // Inventor Items
            KeyItemCategory locationLocks = new("Location Locks");
            locationLocks.AddKeyItem(new("Images/Location_Locks/New_Delsta_Ferry.png", "New Delsta Ferry"));
            locationLocks.AddKeyItem(new("Images/Location_Locks/Crackridge_Ferry.png", "Crackridge Ferry"));
            locationLocks.AddKeyItem(new("Images/Location_Locks/Canalbrine_Ferry.png", "Canalbrine Ferry"));
            locationLocks.AddKeyItem(new("Images/Location_Locks/Beasting_Bay_Ferry.png", "Beasting Bay Ferry"));
            locationLocks.AddKeyItem(new("Images/Location_Locks/Northern_Montwise_Pass.png", "Northern Montwise Pass"));
            return new(locationLocks);
        }

        private void setCurrentlyEditedKeyItem(KeyItemViewModel keyItem) {
            _CurrentlyEditedKeyItem = keyItem;
            OnPropertyChanged(nameof(CurrentlyEditedKeyItem));
        }
    }

}
