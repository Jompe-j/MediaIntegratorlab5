using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MediaIntegrator {
    static class InventoryMigrator {
        public static XElement GenerateSimpleMediaXmlFromMyStoreCsv(IEnumerable<string> csv) {
            var xmlInventory = new XElement("Inventory",
                from itm in csv
                let fields = itm.Split(';')
                select new XElement("Item",
                    new XElement("Name", fields[2]), //name 
                    new XElement("Count", fields[4]), //stock
                    new XElement("Price", fields[3]), // price
                    new XElement("Comment", ""), // "" 
                    new XElement("Artist", fields[5]), // Author || "" 
                    new XElement("Publisher", ""), // ""
                    new XElement("Genre", fields[6]), // Bookgenre || " "
                    new XElement("ProductID", fields[0]),
                    new XElement("ImportedObject",
                        new XElement("Id", fields[0]),
                        new XElement("ProductType", fields[1]),
                        new XElement("Name", fields[2]),
                        new XElement("Price", fields[3]),
                        new XElement("StockNumber", fields[4]),
                        new XElement("BookAuthor", fields[5]),
                        new XElement("BookGenre", fields[6]),
                        new XElement("BookFormat", fields[7]),
                        new XElement("BookLanguage", fields[8]),
                        new XElement("GamePlatform"), fields[9]),
                    new XElement("MoviePlayTime", fields[10]))
            );

            return xmlInventory;
        }
    }
}