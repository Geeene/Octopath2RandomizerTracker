using Octopath2RandomizerTracker.Commands;
using Octopath2RandomizerTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Octopath2RandomizerTracker.ViewModels
{
    public class MainViewModel : ViewModelBase {
        private readonly KeyItemCategoryViewModel _ochette;
        private readonly KeyItemCategoryViewModel _castti;
        private readonly KeyItemCategoryViewModel _temenos;
        private readonly KeyItemCategoryViewModel _throne;
        private readonly KeyItemCategoryViewModel _partitio;
        private readonly KeyItemCategoryViewModel _osvald;
        private readonly KeyItemCategoryViewModel _agnea;
        private readonly KeyItemCategoryViewModel _hikari;
        private readonly KeyItemCategoryViewModel _scholarMerchant;
        private readonly KeyItemCategoryViewModel _apothecaryHunter;
        private readonly KeyItemCategoryViewModel _clericThief;
        private readonly KeyItemCategoryViewModel _dancerWarrior;
        private readonly KeyItemCategoryViewModel _rustedWeapons;
        private readonly KeyItemCategoryViewModel _licenses;
        private readonly KeyItemCategoryViewModel _InventorItems;
        private readonly KeyItemCategoryViewModel _SideStoryCropdale;
        private readonly KeyItemCategoryViewModel _SideStoryWellgrove;
        private readonly KeyItemCategoryViewModel _SideStoryTimberain;
        private readonly KeyItemCategoryViewModel _SideStoryOresrush;
        private readonly KeyItemCategoryViewModel _SideStoryCrackridge;
        private readonly KeyItemCategoryViewModel _SideStoryGravell;
        private readonly KeyItemCategoryViewModel _SideStoryNewDelsta;
        private readonly KeyItemCategoryViewModel _SideStoryAbandonedVillage;
        private readonly KeyItemCategoryViewModel _SideStorySunkenMaw;
        private readonly KeyItemCategoryViewModel _SideStoryFlamechurch;
        private readonly KeyItemCategoryViewModel _SideStoryClericGuild;
        private readonly KeyItemCategoryViewModel _SideStoryMontwise;
        private readonly KeyItemCategoryViewModel _SideStoryMerryHills;
        private readonly KeyItemCategoryViewModel _SideStoryBeastingBay;
        private readonly KeyItemCategoryViewModel _SideStoryBeastingVillage;
        private readonly KeyItemCategoryViewModel _SideStoryTropuhopu;
        private readonly KeyItemCategoryViewModel _SideStoryKu;
        private readonly KeyItemCategoryViewModel _SideStorySai;
        private readonly KeyItemCategoryViewModel _SideStoryCapeCold;
        private readonly KeyItemCategoryViewModel _SideStoryWinterbloom;
        private readonly KeyItemCategoryViewModel _SideStoryStormhail;
        private readonly KeyItemCategoryViewModel _SideStoryCanalbrine;
        private readonly KeyItemCategoryViewModel _SideStoryLighthouseIsland;
        private readonly KeyItemCategoryViewModel _SideStoryNamelessIsle;
        private readonly KeyItemCategoryViewModel _SideStoryGalderaQuest;
        private readonly KeyItemCategoryViewModel _ExSkills;
        private readonly ParentKeyItemCategoryViewModel _Characters;

        public KeyItemCategoryViewModel Ochette => _ochette;
        public KeyItemCategoryViewModel Castti => _castti;
        public KeyItemCategoryViewModel Temenos => _temenos;
        public KeyItemCategoryViewModel Throne => _throne;
        public KeyItemCategoryViewModel Partitio => _partitio;
        public KeyItemCategoryViewModel Osvald => _osvald;
        public KeyItemCategoryViewModel Agnea => _agnea;
        public KeyItemCategoryViewModel Hikari => _hikari;
        public KeyItemCategoryViewModel MerchantScholar => _scholarMerchant;
        public KeyItemCategoryViewModel HunterApothecary => _apothecaryHunter;
        public KeyItemCategoryViewModel ThiefCleric => _clericThief;
        public KeyItemCategoryViewModel DancerWarrior => _dancerWarrior;
        public KeyItemCategoryViewModel RustedWeapons => _rustedWeapons;
        public KeyItemCategoryViewModel Licenses => _licenses;
        public KeyItemCategoryViewModel InventorItems => _InventorItems;
        public KeyItemCategoryViewModel SideStoryCropdale => _SideStoryCropdale;
        public KeyItemCategoryViewModel SideStoryWellgrove => _SideStoryWellgrove;
        public KeyItemCategoryViewModel SideStoryTimberain => _SideStoryTimberain;
        public KeyItemCategoryViewModel SideStoryOresrush => _SideStoryOresrush;
        public KeyItemCategoryViewModel SideStoryCrackridge => _SideStoryCrackridge;
        public KeyItemCategoryViewModel SideStoryGravell => _SideStoryGravell;
        public KeyItemCategoryViewModel SideStoryNewDelsta => _SideStoryNewDelsta;
        public KeyItemCategoryViewModel SideStoryAbandonedVillage => _SideStoryAbandonedVillage;
        public KeyItemCategoryViewModel SideStorySunkenMaw => _SideStorySunkenMaw;
        public KeyItemCategoryViewModel SideStoryFlamechurch => _SideStoryFlamechurch;
        public KeyItemCategoryViewModel SideStoryClericGuild => _SideStoryClericGuild;
        public KeyItemCategoryViewModel SideStoryMontwise => _SideStoryMontwise;
        public KeyItemCategoryViewModel SideStoryMerryHills => _SideStoryMerryHills;
        public KeyItemCategoryViewModel SideStoryBeastingBay => _SideStoryBeastingBay;
        public KeyItemCategoryViewModel SideStoryBeastingVillage => _SideStoryBeastingVillage;
        public KeyItemCategoryViewModel SideStoryTropuhopu => _SideStoryTropuhopu;
        public KeyItemCategoryViewModel SideStoryKu => _SideStoryKu;
        public KeyItemCategoryViewModel SideStorySai=> _SideStorySai;
        public KeyItemCategoryViewModel SideStoryCapeCold => _SideStoryCapeCold;
        public KeyItemCategoryViewModel SideStoryStormhail => _SideStoryStormhail;
        public KeyItemCategoryViewModel SideStoryWinterbloom => _SideStoryWinterbloom;
        public KeyItemCategoryViewModel SideStoryCanalbrine => _SideStoryCanalbrine;
        public KeyItemCategoryViewModel SideStoryLighthouseIsland => _SideStoryLighthouseIsland;
        public KeyItemCategoryViewModel SideStoryNamelessIsle => _SideStoryNamelessIsle;
        public KeyItemCategoryViewModel SideStoryGaldera => _SideStoryGalderaQuest;

        public ParentKeyItemCategoryViewModel Characters => _Characters;


        public MainViewModel()
        {
            ParentKeyItemCategoryViewModel characters = InitializeCharacterParentCategory();

            // Ochette Key Items
            KeyItemCategory ochette = new("Ochette");
            ochette.AddKeyItem(new("Images/Ochette/Chapter_2_Cateracta.png", "Ochette Chapter 2 Cateracta"));
            ochette.AddKeyItem(new("Images/Ochette/Acta.png", "Obtained Acta"));
            ochette.AddKeyItem(new("Images/Ochette/Chapter_2_Terra.png", "Ochette Chapter 2 Terra"));
            ochette.AddKeyItem(new("Images/Ochette/Terra.png", "Obtained Terra"));
            ochette.AddKeyItem(new("Images/Ochette/Chapter_2_Glacis.png", "Ochette Chapter 2 Glacis"));
            ochette.AddKeyItem(new("Images/Ochette/Glacis.png", "Obtained Glacis"));
            ochette.AddKeyItem(new("Images/Ochette/Chapter_3.png", "Ochette Chapter 3"));
            _ochette = new(ochette);

            // Castti Key Items
            KeyItemCategory castti = new("Castti");
            castti.AddKeyItem(new("Images/Castti/Chapter_2_Sai.png", "Castti Chapter 2 Sai"));
            castti.AddKeyItem(new("Images/Castti/Chapter_2_Winterbloom.png", "Castti Chapter 2 Winterbloom"));
            castti.AddKeyItem(new("Images/Castti/Rosas Medicine.png", "Rosa's Medicine"));
            castti.AddKeyItem(new("Images/Castti/Chapter_3.png", "Castti Chapter 3"));
            castti.AddKeyItem(new("Images/Castti/Chapter_4.png", "Castti Chapter 4"));
            _castti = new(castti);

            // Temenos Key Items
            KeyItemCategory temenos = new("Temenos");
            temenos.AddKeyItem(new("Images/Temenos/Chapter_2.png", "Temenos Chapter 2"));
            temenos.AddKeyItem(new("Images/Temenos/Culprits_true_identity.png", "The Culprit's True Identity"));
            temenos.AddKeyItem(new("Images/Temenos/Chapter_3_Crackridge.png", "Temenos Chapter 3 Crackridge"));
            temenos.AddKeyItem(new("Images/Temenos/Mysterious_Notebook.png", "Mysterious Notebook"));
            temenos.AddKeyItem(new("Images/Temenos/Chapter_3_Stormhail.png", "Temenos Chapter 3 Stormhail"));
            temenos.AddKeyItem(new("Images/Temenos/Kaldenas_Notebook.png", "Kaldena's Notebook"));
            temenos.AddKeyItem(new("Images/Temenos/Chapter_4.png", "Temenos Chapter 4"));
            _temenos = new(temenos);

            // Throne Key Items
            KeyItemCategory throne = new("Throné");
            throne.AddKeyItem(new("Images/Throne/Chapter_2_Mother.png", "Throne Chapter 2 Mother"));
            throne.AddKeyItem(new("Images/Throne/Horse_Coin.png", "Horse Coin"));
            throne.AddKeyItem(new("Images/Throne/Masked_Child.png", "Mask"));
            throne.AddKeyItem(new("Images/Throne/Chapter_2_Father.png", "Throne Chapter 2 Father"));
            throne.AddKeyItem(new("Images/Throne/Chapter_3_Mother.png", "Throne Chapter 3 Mother"));
            throne.AddKeyItem(new("Images/Throne/Habit.png", "Habit"));
            throne.AddKeyItem(new("Images/Throne/Chapter_3_Father.png", "Throne Chapter 3 Father"));
            throne.AddKeyItem(new("Images/Throne/Mother_and_Father_keys.png", "Mother's and Father's Key", 2));
            throne.AddKeyItem(new("Images/Throne/Chapter_4.png", "Throné Chapter 4"));
            _throne = new(throne);

            // Partitio Key Items
            KeyItemCategory partitio = new("Partitio");
            partitio.AddKeyItem(new("Images/Partitio/Chapter_2.png", "Partitio Chapter 2"));
            partitio.AddKeyItem(new("Images/Partitio/Clockite.png", "Clockite"));
            partitio.AddKeyItem(new("Images/Partitio/Chapter_3.png", "Partitio Chapter 3"));
            partitio.AddKeyItem(new("Images/Partitio/SOC_Terry.png", "The Grand Terry", 2));
            partitio.AddKeyItem(new("Images/Partitio/SOC_Grammophone.png", "Grammophone", 2));
            partitio.AddKeyItem(new("Images/Partitio/SOC_Merchantile_Manuscript_Key.png", "Merchantile Manuscript Key", 2));
            partitio.AddKeyItem(new("Images/Partitio/Chapter_4.png", "Partitio Chapter 4"));
            _partitio = new(partitio);  

            // Osvald Key Items
            KeyItemCategory osvald = new("Osvald");
            osvald.AddKeyItem(new("Images/Osvald/Chapter_3.png", "Osvald Chapter 3"));
            osvald.AddKeyItem(new("Images/Osvald/Chapter_4.png", "Osvald Chapter 4"));
            osvald.AddKeyItem(new("Images/Osvald/Library_Information.png", "Information: Library Rumor, Harvey's Whereabouts, and An Eyewitness to Harvey"));
            osvald.AddKeyItem(new("Images/Osvald/Chapter_5.png", "Osvald Chapter 5"));
            osvald.AddKeyItem(new("Images/Osvald/Black_Crystal.png", "Black Crystals", 5));
            _osvald = new(osvald);  

            // Agnea Key Items
            KeyItemCategory agnea = new("Agnea");
            agnea.AddKeyItem(new("Images/Agnea/Chapter_2.png", "Agnea Chapter 2"));
            agnea.AddKeyItem(new("Images/Agnea/Woman_Theater_Ticket_Agnea_2.png", "Theater Ticket"));
            agnea.AddKeyItem(new("Images/Agnea/Chapter_3.png", "Agnea Chapter 3"));
            agnea.AddKeyItem(new("Images/Agnea/Islander_Wooden_Sword_Agnea_3.png", "Wooden Sword"));
            agnea.AddKeyItem(new("Images/Agnea/Chapter_4.png", "Agnea Chapter 4"));
            agnea.AddKeyItem(new("Images/Agnea/Old_Man_Cute_Shoes_Agnea_4.png", "Cute Shoes"));
            agnea.AddKeyItem(new("Images/Agnea/Chapter_5.png", "Agnea Chapter 5"));
            _agnea = new(agnea);    

            // Hikari Key Items
            KeyItemCategory hikari = new("Hikari");
            hikari.AddKeyItem(new("Images/Hikari/Chapter_2.png", "Hikari Chapter 2"));
            hikari.AddKeyItem(new("Images/Hikari/Chapter_3.png", "Hikari Chapter 3"));
            hikari.AddKeyItem(new("Images/Hikari/Merchant_NPC_Hikari_3.png", "Weapon Deal Details"));
            hikari.AddKeyItem(new("Images/Hikari/Chapter_4.png", "Hikari Chapter 4"));
            hikari.AddKeyItem(new("Images/Hikari/Chapter_5.png", "Hikari Chapter 5"));
            _hikari = new(hikari);  

            // Key Items Scholar & Merchant Crossed Path
            KeyItemCategory scholarMerchant = new("Merchant & Scholar");
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Scholar & Merchant 1"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Mirror"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Precision Lense"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Metalworking Tool"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Scholar & Merchant 2"));
            _scholarMerchant = new(scholarMerchant);        

            // Key Items Apothecary & Hunter Crossed Path
            KeyItemCategory apothecaryHunter = new("Hunter & Apothecary");
            apothecaryHunter.AddKeyItem(new("Images/Crossed_Paths/Apothecary_Hunter_1.png", "Apothecary & Hunter 1"));
            apothecaryHunter.AddKeyItem(new("Images/Crossed_Paths/Apothecary_Hunter.png", "Apothecary & Hunter 2"));
            _apothecaryHunter = new(apothecaryHunter);

            // Key Items Cleric & Thief Crossed Path
            KeyItemCategory clericThief = new("Thief & Cleric");
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cleric & Thief 1"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cloudy Mirror Fragment"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cleric & Thief 2"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cloudy Mirror"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Folded Paper"));
            _clericThief = new(clericThief);

            // Dancer & Warrior
            KeyItemCategory dancerWarrior = new("Dancer & Warrior");
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer & Warrior 1"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Horse Tail"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer & Warrior 2"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer's Mask"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Sacred Wood"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Wine Offering"));
            _dancerWarrior = new(dancerWarrior);

            // Rusted Weapons
            KeyItemCategory rustedWeapons = new("Rusted \nWeapons");
            rustedWeapons.AddKeyItem(new("Images/Weapons/Sword.png", "Got the Rusty Sword"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Polearm.png", "Got the Rusty Axe"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Dagger.png", "Got the Rusty Polearm"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Axe.png", "Got the Rusty Bow"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Bow.png", "Got the Rusty Dagger"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Staff.png", "Got the Rusty Staff"));
            _rustedWeapons = new(rustedWeapons);

            // Job Licenses
            KeyItemCategory licenses = new("Licenses");
            licenses.AddKeyItem(new("Images/Jobs/Hunter.png", "Got the Hunter License", 3));
            licenses.AddKeyItem(new("Images/Jobs/Apothecary.png", "Got the Apothecary License", 3));
            licenses.AddKeyItem(new("Images/Jobs/Thief.png", "Got the Thief License", 3));
            licenses.AddKeyItem(new("Images/Jobs/Scholar.png", "Got the Scholar License", 3));
            licenses.AddKeyItem(new("Images/Jobs/Merchant.png", "Got the Merchant License", 3));
            licenses.AddKeyItem(new("Images/Jobs/Dancer.png", "Got the Dancer License", 3));
            licenses.AddKeyItem(new("Images/Jobs/Cleric.png", "Got the Cleric License", 3));
            licenses.AddKeyItem(new("Images/Jobs/Warrior.png", "Got the Warrior License", 3));
            licenses.AddKeyItem(new("Images/Jobs/Inventor.png", "Got the Inventor License"));
            licenses.AddKeyItem(new("Images/Jobs/Armsmaster.png", "Got the Armsmaster License"));
            licenses.AddKeyItem(new("Images/Jobs/Arcanist.png", "Got the Arcanist License"));
            licenses.AddKeyItem(new("Images/Jobs/Conjurer.png", "Got the Conjurer License"));
            _licenses = new(licenses);  

            // Inventor Items
            KeyItemCategory inventorItems = new("Inventor \nItems");
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Inventor_Clockbank.png", "Scrap Metal from Clockbank"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Inventor_Clockbank.png", "Rainbow Glassbottle from Conning Creek"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Miner_Natural_Magnetite.png", "Natural Magnetite from Mines"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Inventor_Clockbank.png", "Tin Toy from Wellgrove"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Ancient_Cog.png", "Ancient Cog from Roque Island"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Beastling_Mythical_Horn.png", "Mythical Horn from Nameless Village"));
            _InventorItems = new(inventorItems);

            // Side Story Key Items
            KeyItemCategory sideStoryCropdale = new("Cropdale");
            sideStoryCropdale.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Useless Fruit: Well Iris Uses"));
            sideStoryCropdale.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Goading the Grapes: Tricks to Growing Grapes"));
            sideStoryCropdale.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Crop Revival: Crop Tapestry Pattern"));
            _SideStoryCropdale = new(sideStoryCropdale);

            KeyItemCategory sideStoryWellgrove = new("Wellgrove");
            sideStoryWellgrove.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Misha’s Next Chapter: Man in a Brown Coat"));
            sideStoryWellgrove.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Misha’s Next Chapter: Garbage Collector"));
            _SideStoryWellgrove = new(sideStoryWellgrove);

            KeyItemCategory sideStoryTimberain = new("Timberain");
            sideStoryTimberain.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Proof of Guilt: Azure Sun Sword"));
            sideStoryTimberain.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Proof of Justice: Stolen Sword"));
            _SideStoryTimberain= new(sideStoryTimberain);   

            KeyItemCategory sideStoryOresrush = new("Oresrush");
            sideStoryOresrush.AddKeyItem(new("Images/Side_Stories/Joes_Jokes.png", "Wanted: A Good Joke: 3 jokes", 3));
            sideStoryOresrush.AddKeyItem(new("Images/Side_Stories/Sturdy_Pickaxe.png", "The Sword in the Stone: Sturdy Pickaxe"));
            sideStoryOresrush.AddKeyItem(new("Images/Side_Stories/Stocked_Goods.png", "Stolen Goods: Stocked Goods"));
            _SideStoryOresrush = new(sideStoryOresrush); 

            KeyItemCategory sideStoryCrackridge = new("Crackridge (Harbor)");
            sideStoryCrackridge.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "The Treasures of Ku: Phoenix Fan"));
            sideStoryCrackridge.AddKeyItem(new("Images/Side_Stories/From_the_Far_Reaches_of_Hell.png", "Procuring Peculiar Tomes: From the Far Reaches of Hell"));
            _SideStoryCrackridge = new(sideStoryCrackridge); 
            
            KeyItemCategory sideStoryGravell = new("Gravell");
            sideStoryGravell.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "The Missing Girl: Cloudy Crystal Bracelet"));
            sideStoryGravell.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Alpione's Next Chapter: Hunting Request"));
            _SideStoryGravell = new(sideStoryGravell); 
            
            KeyItemCategory sideStoryNewDelsta = new("New Delsta");
            sideStoryNewDelsta.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Young Girl's Wish: Deluxe Crêpe"));
            sideStoryNewDelsta.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Gambling Man: Truth of the Game Parlor"));
            sideStoryNewDelsta.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Proof of Justice: A Killer's Motive"));
            _SideStoryNewDelsta = new(sideStoryNewDelsta);   


            KeyItemCategory sideStoryAbandonedVillage = new("Abandoned Village");
            sideStoryAbandonedVillage.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Descended from Royalty: Nyx Royal Family Tree"));
            _SideStoryAbandonedVillage = new(sideStoryAbandonedVillage);

            KeyItemCategory sideStorySunkenMaw = new("Sunken Maw");
            sideStorySunkenMaw.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Devilishly Delicious Dish: Special Bait"));
            sideStorySunkenMaw.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Devilishly Delicious Dish: Delsta Devil"));
            _SideStorySunkenMaw = new(sideStorySunkenMaw);

            KeyItemCategory sideStoryFlamechurch = new("Flamechurch");
            sideStoryFlamechurch.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Shirlutto's Next Chapter: Paper Play"));
            sideStoryFlamechurch.AddKeyItem(new("Images/Side_Stories/Pilgrims_Torches.png", "Pilgrim Protection: 3 Sacred Flame Candles", 3));
            _SideStoryFlamechurch = new(sideStoryFlamechurch);   
            
            KeyItemCategory sideStoryClericGuild = new("Cleric Guild");
            sideStoryClericGuild.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Young Girl's Wish: Adventures of an Apprentice Cleric’s Sequel"));
            _SideStoryClericGuild = new(sideStoryClericGuild);   
            
            KeyItemCategory sideStoryMontwise = new("Montwise");
            sideStoryMontwise.AddKeyItem(new("Images/Side_Stories/History_Book.png", "Shirlutto's Next Chapter: History Book"));
            sideStoryMontwise.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Descended from Royalty: Nyx Family History"));
            _SideStoryMontwise = new(sideStoryMontwise); 

            KeyItemCategory sideStoryMerryHills = new("Merry Hills");
            sideStoryMerryHills.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "A Mysterious Box: Mysterious Box"));
            _SideStoryMerryHills = new(sideStoryMerryHills);

            KeyItemCategory sideStoryBeastingBay = new("Beasting Bay");
            sideStoryBeastingBay.AddKeyItem(new("Images/Side_Stories/Bottle_Of_White_Dust.png", "Traveler's Lost and Found: Bottle of White Powder"));
            _SideStoryBeastingBay = new(sideStoryBeastingBay);

            KeyItemCategory sideStoryBeastingVillage = new("Beasting Village");
            sideStoryBeastingVillage.AddKeyItem(new("Images/Side_Stories/Amulet_Of_Affection.png", "Building Bridges: Amulet of Affection"));
            sideStoryBeastingVillage.AddKeyItem(new("Images/Side_Stories/Dispatches_from_Beastling_Island.png", "Procuring Peculiar Tomes: Dispatches from Beastling Island"));
            _SideStoryBeastingVillage = new(sideStoryBeastingVillage);
            
            KeyItemCategory sideStoryTropuhopu = new("Tropu'hopu");
            sideStoryTropuhopu.AddKeyItem(new("Images/Side_Stories/Pretty_Pearls.png", "Pearl Hunt: 4 Pretty Pearls", 4));
            sideStoryTropuhopu.AddKeyItem(new("Images/Side_Stories/Spicy_Chicken.png", "Culinary Cunning: Spicy Chicken Recipe"));
            _SideStoryTropuhopu = new(sideStoryTropuhopu);
            
            KeyItemCategory sideStoryCapeCold = new("Cape Cold");
            sideStoryCapeCold.AddKeyItem(new("Images/Side_Stories/Silver_Quill.png", "A Present for my Son: Silver Quill"));
            _SideStoryCapeCold = new(sideStoryCapeCold);

            KeyItemCategory sideStoryWinterbloom = new("Winterbloom");
            sideStoryWinterbloom.AddKeyItem(new("Images/Side_Stories/Melia_Snow_Hares.png", "Melia's Next Chapter: Letter from the Snowhares"));
            _SideStoryWinterbloom = new(sideStoryWinterbloom);   

            KeyItemCategory sideStoryStormhail = new("Stormhail");
            sideStoryStormhail.AddKeyItem(new("Images/Side_Stories/Curious_Legend_of_the_Great_Wall.png", "Procuring Peculiar Tomes: The Curious Legends of the Great Wall"));
            sideStoryStormhail.AddKeyItem(new("Images/Side_Stories/Treasured_Necklace.png", "Lingering Love: Treasured Necklace"));
            _SideStoryStormhail = new(sideStoryStormhail);
            
            KeyItemCategory sideStorySai = new("Sai");
            sideStorySai.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Shirlutto's Next Chapter: Lute"));
            sideStorySai.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Veronica's Next Chapter: Dolcinaea and Gifts"));
            _SideStorySai = new(sideStorySai);

            KeyItemCategory sideStoryKu = new("Ku");
            sideStoryKu.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Mikka’s Next Chapter: Earrings"));
            _SideStoryKu = new(sideStoryKu);    

            KeyItemCategory sideStoryCanalbrine = new("Canalbrine");
            sideStoryCanalbrine.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "The Treasures of Ku: Dragon Vase"));
            sideStoryCanalbrine.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Plans from a Ruined Nation: Fort Orochi Plans"));
            _SideStoryCanalbrine = new(sideStoryCanalbrine);
            
            KeyItemCategory sideStoryLighthouseIsland = new("Lighthouse Island");
            sideStoryLighthouseIsland.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "The Washed-Up Letter: Message in a Bottle"));
            sideStoryLighthouseIsland.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Lighthouse Restoration: Aelmorite Reflector"));
            _SideStoryLighthouseIsland = new(sideStoryLighthouseIsland);
            
            KeyItemCategory sideStoryNamelessIsle = new("Nameless Isle");
            sideStoryNamelessIsle.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "How to Decipher Unkown Languages"));
            _SideStoryNamelessIsle = new(sideStoryNamelessIsle);
            
            KeyItemCategory sideStoryGalderaQuest = new("Galdera Quest");
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Al's Bag"));
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Return Al's Bag"));
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Return books to Library"));
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Assist Als Translatione "));
            sideStoryGalderaQuest.AddKeyItem(new("Images/Side_Stories/Worker_Inventor_Clockbank.png", "Defeat Galdera"));
            _SideStoryGalderaQuest = new(sideStoryGalderaQuest);
        }

        private static ParentKeyItemCategoryViewModel InitializeCharacterParentCategory()
        {
            var model = new ParentKeyItemCategoryViewModel();
            KeyItemCategoryViewModel ochette = new(new("Ochette"));
            ochette.AddKeyItem(new("Images/Ochette/Ochette_Generic.png", "Recruit Ochette"));
            ochette.AddKeyItem(new("Images/Ochette/Ochette_Generic.png", "Visit the Altar of the Huntress and received the EX-Skill 'Indomitable Beast'"));
            ochette.AddKeyItem(new("Images/Ochette/Ochette_Generic.png", "Finished Ochette Chapter 3 and received the EX-Skill 'Provoke Beasts'"));
            model.AddSubcategory(ochette);

            KeyItemCategoryViewModel castti = new(new("Castti"));
            castti.AddKeyItem(new("Images/Castti/Castti_Generic.png", "Recruit Castti"));
            castti.AddKeyItem(new("Images/Castti/Castti_Generic.png", "Visit the Altar of the Charitable and receive the EX-Skill 'Drastic Measures'"));
            castti.AddKeyItem(new("Images/Castti/Castti_Generic.png", "Finish Castti Chapter 4 and receive the EX-Skill 'Remedy'"));
            model.AddSubcategory(castti);

            KeyItemCategoryViewModel temenos = new(new("Temenos"));
            temenos.AddKeyItem(new("Images/Temenos/Temenos_Generic.png", "Recruit Temenos"));
            temenos.AddKeyItem(new("Images/Temenos/Temenos_Generic.png", "Visit the Altar of the Flamebringer and receive the EX-Skill 'Prayer for Plenty'"));
            temenos.AddKeyItem(new("Images/Temenos/Temenos_Generic.png", "Finish Temenos Chapter 4 and receive the EX-Skill 'Heavenly Shine'"));
            model.AddSubcategory(temenos);

            KeyItemCategoryViewModel osvald = new(new("Osvald"));
            osvald.AddKeyItem(new("Images/Osvald/Osvald_Generic.png", "Recruit Osvald"));
            osvald.AddKeyItem(new("Images/Osvald/Osvald_Generic.png", "Visit the Altar of the Scholarking and receive the EX-Skill 'Teach'"));
            osvald.AddKeyItem(new("Images/Osvald/Osvald_Generic.png", "Finish Osvald Chapter 5 and receive the EX-Skill 'One True Magic'"));
            model.AddSubcategory(osvald);

            KeyItemCategoryViewModel partitio = new(new("Partitio"));
            partitio.AddKeyItem(new("Images/Partitio/Partitio_Generic.png", "Recruit Partitio"));
            partitio.AddKeyItem(new("Images/Partitio/Partitio_Generic.png", "Visit the Altar of the Trader and receive the EX-Skill 'Negotiate Schedule'"));
            partitio.AddKeyItem(new("Images/Partitio/Partitio_Generic.png", "Finish Partitio Chapter 4 and receive the EX-Skill 'Share SP'"));
            model.AddSubcategory(partitio);

            KeyItemCategoryViewModel agnea = new(new("Agnea"));
            agnea.AddKeyItem(new("Images/Agnea/Agnea_Generic.png", "Recruit Agnea"));
            agnea.AddKeyItem(new("Images/Agnea/Agnea_Generic.png", "Visit the Altar of the Lady of Grace and receive the EX-Skill 'Windy Refrain'"));
            agnea.AddKeyItem(new("Images/Agnea/Agnea_Generic.png", "Finish Agnea Chapter 5 and receive the EX-Skill 'Song of Hope'"));
            model.AddSubcategory(agnea);

            KeyItemCategoryViewModel throne = new(new("Throné"));
            throne.AddKeyItem(new("Images/Throne/Throne_Generic.png", "Recruit Throné"));
            throne.AddKeyItem(new("Images/Throne/Throne_Generic.png", "Visist the Altar of the Prince of Thieves and receive the EX-Skill 'Veil of Darkness'"));
            throne.AddKeyItem(new("Images/Throne/Throne_Generic.png", "Finish Throné Chapter 4 and receive the EX-Skill 'Disguise'"));
            model.AddSubcategory(throne);

            KeyItemCategoryViewModel hikari = new(new("Hikari"));
            hikari.AddKeyItem(new("Images/Hikari/Hikari_Generic.png", "Recruit Hikari"));
            hikari.AddKeyItem(new("Images/Hikari/Hikari_Generic.png", "Visist the Altar of the Thunderblade and receive the EX-Skill 'Ultimate Stance'"));
            hikari.AddKeyItem(new("Images/Hikari/Hikari_Generic.png", "Finish Hikari Chapter 5 and receive the EX-Skill 'Shinjumonjigiri'"));
            model.AddSubcategory(hikari);

            return model;
        }
    }

}
