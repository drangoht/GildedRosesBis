using Kata.GildedRose;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.ObjectModel;
using System.Text.Json;
using VerifyXunit;
using Xunit.Abstractions;
namespace GildedRosesBis.Tests
{
    public class GildedRosesTests
    {

        [Fact]
        public async Task Should_()
        {
            List<Item> srcItems = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
            List<Item> attendedItems = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 9, Quality = 19},
                new Item {Name = "Aged Brie", SellIn = 1, Quality = 1},
                new Item {Name = "Elixir of the Mongoose", SellIn = 4, Quality = 6},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 14,
                        Quality = 21
                    },
                new Item {Name = "Conjured Mana Cake", SellIn = 2, Quality = 5}
            };
            string attendedItemsString = JsonSerializer.Serialize(attendedItems);

            var prog = new Kata.GildedRose.Program();
            prog.SetItems(srcItems);

            prog.UpdateQuality();
            string resultItemsString = JsonSerializer.Serialize(prog.ItemList);

            Assert.Equal(attendedItemsString, resultItemsString);
            

        }
    }
}