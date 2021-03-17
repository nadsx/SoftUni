using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreedyTimes
{
    public class Bag
    {
        private Dictionary<string, Dictionary<string, long>> bagSpace;

        public Bag()
        {
            bagSpace = new Dictionary<string, Dictionary<string, long>>();
        }

        public void FillBag(string[] safe, long bagCapacity)
        {
            long goldQuantity = 0;
            long gemQuantity = 0;
            long cashQuantity = 0;
            long bagSpaceCurrentCapacity = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string itemName = safe[i];
                long itemAmount = long.Parse(safe[i + 1]);
                string itemType = FindItem(itemName);
                bagSpaceCurrentCapacity = bagSpace.Values.Sum(x => x.Values.Sum());

                if (itemType == "")
                {
                    continue;
                }
                else if (bagCapacity < bagSpaceCurrentCapacity + itemAmount)
                {
                    continue;
                }

                switch (itemType)
                {
                    case "Gem":
                        if (!bagSpace.ContainsKey(itemType))
                        {
                            if (bagSpace.ContainsKey("Gold"))
                            {
                                if (itemAmount > bagSpace["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bagSpace[itemType].Values.Sum() + itemAmount > bagSpace["Gold"].Values.Sum())
                        {
                            continue;
                        }

                        break;
                    case "Cash":
                        if (!bagSpace.ContainsKey(itemType))
                        {
                            if (bagSpace.ContainsKey("Gem"))
                            {
                                if (itemAmount > bagSpace["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bagSpace[itemType].Values.Sum() + itemAmount > bagSpace["Gem"].Values.Sum())
                        {
                            continue;
                        }

                        break;
                }

                InitializeBagSpaceDictionary(itemName, itemAmount, itemType);
                CalculateItemQuantity(ref goldQuantity, ref gemQuantity, ref cashQuantity, itemAmount, itemType);
            }
        }

        private static void CalculateItemQuantity(ref long goldQuantity, ref long gemQuantity, ref long cashQuantity, long itemAmount, string itemType)
        {
            if (itemType == "Gold")
            {
                goldQuantity += itemAmount;
            }
            else if (itemType == "Gem")
            {
                gemQuantity += itemAmount;
            }
            else if (itemType == "Cash")
            {
                cashQuantity += itemAmount;
            }
        }

        private void InitializeBagSpaceDictionary(string itemName, long itemAmount, string itemType)
        {
            if (!bagSpace.ContainsKey(itemType))
            {
                bagSpace[itemType] = new Dictionary<string, long>();
            }

            if (!bagSpace[itemType].ContainsKey(itemName))
            {
                bagSpace[itemType][itemName] = 0;
            }

            bagSpace[itemType][itemName] += itemAmount;
        }

        private static string FindItem(string itemName)
        {
            string itemType = string.Empty;

            if (itemName.Length == 3)
            {
                itemType = "Cash";
            }
            else if (itemName.ToLower().EndsWith("gem"))
            {
                itemType = "Gem";
            }
            else if (itemName.ToLower() == "gold")
            {
                itemType = "Gold";
            }

            return itemType;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var bag in bagSpace)
            {
                sb.AppendLine($"<{bag.Key}> ${bag.Value.Values.Sum()}");

                foreach (var item in bag.Value.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
                {
                    sb.AppendLine($"##{item.Key} - {item.Value}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
