using SpellDeck.CardFiles;
using SpellDeck.Constants;
using SpellDeck.SpellDeckTests;
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
    public static class DeckLoader
    {
        public static SpellCardDeck Load(string deckName)
        {
            SpellCardDeck retVal = new SpellCardDeck();
            CardData data = new CardData();

            using (XmlReader reader = XmlReader.Create(Path.Combine(DeckIOProperties.DECK_SAVE_LOCATION, deckName + ".xml")))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (reader.Name)
                        {
                            case "Card":
                                string message = reader["CardID"];
                                retVal.Add(data.GetSpellCardByID(message));  
 
                                break;
                        }
                    }
                }
            }

            return retVal;
        }
    }
}
