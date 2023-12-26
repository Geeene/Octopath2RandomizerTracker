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
        private readonly KeyItemCategoryViewModel _SideStoriesBrightlands;
        private readonly KeyItemCategoryViewModel _SideStoriesCrestlands;
        private readonly KeyItemCategoryViewModel _SideStoriesLeaflands;
        private readonly KeyItemCategoryViewModel _SideStoriesWildlands;
        private readonly KeyItemCategoryViewModel _SideStoriesWinterlands;
        private readonly KeyItemCategoryViewModel _SideStoriesSunderingSea;
        private readonly KeyItemCategoryViewModel _SideStoriesTotohaha;
        private readonly KeyItemCategoryViewModel _SideStoriesHarborlands;
        private readonly KeyItemCategoryViewModel _SideStoriesHinoeuma;
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
        public KeyItemCategoryViewModel SideStoriesBrightlands => _SideStoriesBrightlands;
        public KeyItemCategoryViewModel SideStoriesCrestlands => _SideStoriesCrestlands;
        public KeyItemCategoryViewModel SideStoriesLeaflands => _SideStoriesLeaflands;
        public KeyItemCategoryViewModel SideStoriesHinoeuma => _SideStoriesHinoeuma;
        public KeyItemCategoryViewModel SideStoriesSunderingSea => _SideStoriesSunderingSea;
        public KeyItemCategoryViewModel SideStoriesHarborlands => _SideStoriesHarborlands;
        public KeyItemCategoryViewModel SideStoriesWildlands => _SideStoriesWildlands;
        public KeyItemCategoryViewModel SideStoriesWinterlands => _SideStoriesWinterlands;
        public KeyItemCategoryViewModel SideStoriesTotohaha => _SideStoriesTotohaha;


        public MainViewModel()
        {
            KeyItemCategory ochette = new("Ochette");
            KeyItemCategory castti = new("Castti");
            KeyItemCategory temenos = new("Temenos");
            KeyItemCategory throne = new("Throné");
            KeyItemCategory partitio = new("Partitio");
            KeyItemCategory osvald = new("Osvald");
            KeyItemCategory agnea = new("Agnea");
            KeyItemCategory hikari = new("Hikari");
            KeyItemCategory scholarMerchant = new("Merchant & Scholar");
            KeyItemCategory ApothecaryHunter = new("Hunter & Apothecary");
            KeyItemCategory clericThief = new("Thief & Cleric");
            KeyItemCategory dancerWarrior = new("Dancer & Warrior");
            KeyItemCategory rustedWeapons = new("Rusted \nWeapons");
            KeyItemCategory licenses = new("Licenses");
            KeyItemCategory inventorItems = new("Inventor \nItems");
            KeyItemCategory sideStoryBrightlands = new("Brightlands");
            KeyItemCategory sideStoryWildlands = new("Wildlands");
            KeyItemCategory sideStoryWinterlands = new("Winterlands");
            KeyItemCategory sideStoryCrestlands = new("Crestlands");
            KeyItemCategory sideStoryTotohaha = new("Toto'haha");
            KeyItemCategory sideStoryHarborlands = new("Harborlands");
            KeyItemCategory sideStoryLeaflands = new("Leaflands");
            KeyItemCategory sideStoryHinoeuma = new("Hinoeuma");
            KeyItemCategory sideStorySunderingSea = new("Sundering Sea");
            // Ochette Key Items
            ochette.AddKeyItem(new("Images/Ochette_Generic.png", "Ochette Chapter 2 Acta"));
            ochette.AddKeyItem(new("Images/Acta.png", "Obtained Acta"));
            ochette.AddKeyItem(new("Images/Ochette_Generic.png", "Ochette Chapter 2 Terra"));
            ochette.AddKeyItem(new("Images/Terra.png", "Obtained Terra"));
            ochette.AddKeyItem(new("Images/Ochette_Generic.png", "Ochette Chapter 2 Glacis"));
            ochette.AddKeyItem(new("Images/Glacis.png", "Obtained Glacis"));
            ochette.AddKeyItem(new("Images/Ochette_Generic.png", "Ochette Chapter 3"));

            // Castti Key Items
            castti.AddKeyItem(new("Images/Castti_Generic.png", "Castti Chapter 2 Sai"));
            castti.AddKeyItem(new("Images/Castti_Generic.png", "Castti Chapter 2 Winterbloom"));
            castti.AddKeyItem(new("Images/Castti_Generic.png", "Rosa's Medicine"));
            castti.AddKeyItem(new("Images/Castti_Generic.png", "Castti Chapter 3"));
            castti.AddKeyItem(new("Images/Castti_Generic.png", "Castti Chapter 4"));

            // Temenos Key Items
            temenos.AddKeyItem(new("Images/Temenos_Generic.png", "Temenos Chapter 2"));
            temenos.AddKeyItem(new("Images/Temenos_Generic.png", "The Culprit's True Identity"));
            temenos.AddKeyItem(new("Images/Temenos_Generic.png", "Temenos Chapter 3 Crackridge"));
            temenos.AddKeyItem(new("Images/Temenos/Mysterious_Notebook.png", "Mysterious Notebook"));
            temenos.AddKeyItem(new("Images/Temenos_Generic.png", "Temenos Chapter 3 Stormhail"));
            temenos.AddKeyItem(new("Images/Temenos/Kaldenas_Notebook.png", "Kaldena's Notebook"));
            temenos.AddKeyItem(new("Images/Temenos_Generic.png", "Temenos Chapter 4"));

            // Throne Key Items
            throne.AddKeyItem(new("Images/Throne_Generic.png", "Throne Chapter 2 Mother"));
            throne.AddKeyItem(new("Images/Throne_Generic.png", "Throne Chapter 2 Father"));
            throne.AddKeyItem(new("Images/Throne/Horse_Coin.png", "Horse Coin"));
            throne.AddKeyItem(new("Images/Throne/Masked_Child.png", "Mask"));
            throne.AddKeyItem(new("Images/Throne_Generic.png", "Throne Chapter 3 Mother"));
            throne.AddKeyItem(new("Images/Throne/Habit.png", "Habit"));
            throne.AddKeyItem(new("Images/Throne_Generic.png", "Throne Chapter 3 Father"));
            throne.AddKeyItem(new("Images/Throne_Generic.png", "Mother's and Father's Key", 2));
            throne.AddKeyItem(new("Images/Throne_Generic.png", "Throné Chapter 4"));

            // Partitio Key Items
            partitio.AddKeyItem(new("Images/Partitio_Generic.png", "Partitio Chapter 2"));
            partitio.AddKeyItem(new("Images/Partitio_Generic.png", "Clockite"));
            partitio.AddKeyItem(new("Images/Partitio_Generic.png", "Partitio Chapter 3"));
            partitio.AddKeyItem(new("Images/Partitio_Generic.png", "The Grand Terry"));
            partitio.AddKeyItem(new("Images/Partitio_Generic.png", "Grammophone"));
            partitio.AddKeyItem(new("Images/Partitio_Generic.png", "Merchantile Manuscript Key"));
            partitio.AddKeyItem(new("Images/Partitio_Generic.png", "Partitio Chapter 4"));

            // Osvald Key Items
            osvald.AddKeyItem(new("Images/Osvald_Generic.png", "Osvald Chapter 3"));
            osvald.AddKeyItem(new("Images/Osvald_Generic.png", "Osvald Chapter 4"));
            osvald.AddKeyItem(new("Images/Osvald_Generic.png", "Library Rumor"));
            osvald.AddKeyItem(new("Images/Osvald_Generic.png", "Harvey's Whereabouts"));
            osvald.AddKeyItem(new("Images/Osvald_Generic.png", "An Eyewitness to Harvey"));
            osvald.AddKeyItem(new("Images/Osvald_Generic.png", "Osvald Chapter 5"));
            osvald.AddKeyItem(new("Images/Osvald/Black_Crystal.png", "Black Crystals", 5));

            // Agnea Key Items
            agnea.AddKeyItem(new("Images/Agnea_Generic.png", "Agnea Chapter 2"));
            agnea.AddKeyItem(new("Images/NPCs/Woman_Theater_Ticket_Agnea_2.png", "Theater Ticket"));
            agnea.AddKeyItem(new("Images/Agnea_Generic.png", "Agnea Chapter 3"));
            agnea.AddKeyItem(new("Images/NPCs/Islander_Wooden_Sword_Agnea_3.png", "Wooden Sword"));
            agnea.AddKeyItem(new("Images/Agnea_Generic.png", "Agnea Chapter 4"));
            agnea.AddKeyItem(new("Images/NPCs/Old_Man_Cute_Shoes_Agnea_4.png", "Cute Shoes"));
            agnea.AddKeyItem(new("Images/Agnea_Generic.png", "Agnea Chapter 5"));

            // Hikari Key Items
            hikari.AddKeyItem(new("Images/Hikari_Generic.png", "Hikari Chapter 2"));
            hikari.AddKeyItem(new("Images/Hikari_Generic.png", "Hikari Chapter 3"));
            hikari.AddKeyItem(new("Images/NPCs/Merchant_NPC_Hikari_3.png", "Weapon Deal Details"));
            hikari.AddKeyItem(new("Images/Hikari_Generic.png", "Hikari Chapter 4"));
            hikari.AddKeyItem(new("Images/Hikari_Generic.png", "Hikari Chapter 5"));

            // Key Items Scholar & Merchant Crossed Path
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Scholar & Merchant 1"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Mirror"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Precision Lense"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Metalworking Tool"));
            scholarMerchant.AddKeyItem(new("Images/Crossed_Paths/Scholar_Merchant.png", "Scholar & Merchant 2"));

            // Key Items Apothecary & Hunter Crossed Path
            ApothecaryHunter.AddKeyItem(new("Images/Crossed_Paths/Apothecary_Hunter.png", "Apothecary & Hunter 1"));
            ApothecaryHunter.AddKeyItem(new("Images/Crossed_Paths/Apothecary_Hunter.png", "Apothecary & Hunter 2"));

            // Key Items Cleric & Thief Crossed Path
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cleric & Thief 1"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cloudy Mirror Fragment"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cleric & Thief 2"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Cloudy Mirror"));
            clericThief.AddKeyItem(new("Images/Crossed_Paths/Cleric_Thief.png", "Folded Paper"));

            // Dancer & Warrior
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer & Warrior 1"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Horse Tail"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer & Warrior 2"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Dancer's Mask"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Sacred Wood"));
            dancerWarrior.AddKeyItem(new("Images/Crossed_Paths/Dancer_Warrior.png", "Wine Offering"));

            // Rusted Weapons
            rustedWeapons.AddKeyItem(new("Images/Weapons/Sword.png", "Got the Rusty Sword"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Polearm.png", "Got the Rusty Axe"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Dagger.png", "Got the Rusty Polearm"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Axe.png", "Got the Rusty Bow"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Bow.png", "Got the Rusty Dagger"));
            rustedWeapons.AddKeyItem(new("Images/Weapons/Staff.png", "Got the Rusty Staff"));

            // Job Licenses
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

            // Inventor Items
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Inventor_Clockbank.png", "Scrap Metal from Clockbank"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Beastling_Mythical_Horn.png", "Mythical Horn from Nameless Village"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Miner_Natural_Magnetite.png", "Natural Magnetite from Mines"));
            inventorItems.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Tin Toy from Wellgrove"));
            inventorItems.AddKeyItem(new("Images/Inventor_Items/Worker_Ancient_Cog.png", "Ancient Cog from Roque Island"));
            inventorItems.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Rainbow Glassbottle from Conning Creek"));

            // Side Story Key Items
            sideStoryLeaflands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Crop Revival: Crop Tapestry Pattern"));
            sideStoryLeaflands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Goading the Grapes: Tricks to Growing Grapes"));
            sideStoryLeaflands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Misha’s Next Chapter: Man in a Brown Coat"));
            sideStoryLeaflands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Misha’s Next Chapter: Garbage Collector"));
            sideStoryLeaflands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Proof of Guilt: Azure Sun Sword"));
            sideStoryLeaflands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Proof of Justice: Stolen Sword"));
            sideStoryLeaflands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Useless Fruit: Well Iris Uses"));

            sideStoryWildlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Stolen Goods: Stocked Goods"));
            sideStoryWildlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "The Missing Girl: Cloudy Crystal Bracelet"));
            sideStoryWildlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "The Sword in the Stone: Sturdy Pickaxe"));
            sideStoryWildlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Wanted: A Good Joke: 3 jokes", 3));
            sideStoryWildlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "The Treasures of Ku: Phoenix Fan"));
            sideStoryWildlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Alpione's Next Chapter: Hunting Request"));
            
            sideStoryBrightlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "A Devilishly Delicious Dish: Special Bait"));
            sideStoryBrightlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "A Devilishly Delicious Dish: Delsta Devil"));
            sideStoryBrightlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "A Gambling Man: Truth of the Game Parlor"));
            sideStoryBrightlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "A Young Girl's Wish: Deluxe Crêpe"));
            sideStoryBrightlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Descended from Royalty: Nyx Royal Family Tree"));
            sideStoryBrightlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Proof of Justice: A Killer's Motive"));
            
            sideStoryCrestlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "A Mysterious Box: Mysterious Box"));
            sideStoryCrestlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "A Young Girl's Wish: Adventures of an Apprentice Cleric’s Sequel"));
            sideStoryCrestlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Descended from Royalty: Nyx Family History"));
            sideStoryCrestlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Pilgrim Protection: 3 Sacred Flame Candles", 3));
            sideStoryCrestlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Shirlutto's Next Chapter: Paper Play"));
            sideStoryCrestlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Shirlutto's Next Chapter: History Book"));
            
            sideStoryTotohaha.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Building Bridges: Amulet of Affection"));
            sideStoryTotohaha.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Culinary Cunning: Spicy Chicken Recipe"));
            sideStoryTotohaha.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Pearl Hunt: 4 Pretty Pearls", 4));
            sideStoryTotohaha.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Traveler's Lost and Found: Bottle of White Powder"));
            
            sideStoryWinterlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "A Present for my Son: Silver Quill"));
            sideStoryWinterlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Lingering Love: Treasured Necklace"));
            sideStoryWinterlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Melia's Next Chapter: Letter from the Snowhares"));
            
            sideStoryHinoeuma.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Mikka’s Next Chapter: Earrings"));
            sideStoryHinoeuma.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Shirlutto's Next Chapter: Lute"));
            sideStoryHinoeuma.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Veronica's Next Chapter: Dolcinaea and Gifts"));
            sideStoryHarborlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Plans from a Ruined Nation: Fort Orochi Plans"));
            sideStoryHarborlands.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "The Treasures of Ku: Dragon Vase"));
            sideStorySunderingSea.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "The Washed-Up Letter: Message in a Bottle"));
            sideStorySunderingSea.AddKeyItem(new("Images/NPCs/Worker_Inventor_Clockbank.png", "Lighthouse Restoration: Aelmorite Reflector"));

            _ochette = new(ochette);
            _castti = new(castti);
            _temenos = new(temenos);
            _throne = new(throne);
            _partitio = new(partitio);
            _osvald = new(osvald);
            _agnea = new(agnea);
            _hikari = new(hikari);
            _scholarMerchant = new(scholarMerchant);
            _apothecaryHunter = new(ApothecaryHunter);
            _clericThief = new(clericThief);
            _dancerWarrior = new(dancerWarrior);
            _rustedWeapons = new(rustedWeapons);
            _licenses = new(licenses);
            _InventorItems = new(inventorItems);
            _SideStoriesBrightlands = new(sideStoryBrightlands);  
            _SideStoriesCrestlands = new(sideStoryCrestlands);  
            _SideStoriesHinoeuma = new(sideStoryHinoeuma);  
            _SideStoriesHarborlands = new(sideStoryHarborlands);  
            _SideStoriesSunderingSea = new(sideStorySunderingSea);  
            _SideStoriesLeaflands = new(sideStoryLeaflands);  
            _SideStoriesWildlands = new(sideStoryWildlands);  
            _SideStoriesTotohaha = new(sideStoryTotohaha);
            _SideStoriesWinterlands = new(sideStoryWinterlands);
        }
    }

}
