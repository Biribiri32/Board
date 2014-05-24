using SpellDeck.CardFiles;
using SpellDeck.Constants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace SpellDeck
{
    public static class DeckSaver
    {
        public static void Save(SpellCardDeck deck)
        {
            string deckName = deck.DeckName.Replace(" ", "_");

            XElement xml = new XElement("PlayerDeck", deck.Select(x => new XElement("Card",
                                                new XAttribute("CardID", x.CardId))));

            using (XmlWriter writer = XmlWriter.Create(Path.Combine(DeckIOProperties.DECK_SAVE_LOCATION, deckName + ".xml")))
            {
                xml.Save(writer);
            }
        }
    }
}
