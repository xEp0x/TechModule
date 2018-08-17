using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMaterialsQuantity = new SortedDictionary<string, int>();
            var junkMaterialsQuantity = new SortedDictionary<string, int>();

            keyMaterialsQuantity.Add("shards", 0);
            keyMaterialsQuantity.Add("fragments", 0);
            keyMaterialsQuantity.Add("motes", 0);

            while (true)
            {
                var inputLine = Console.ReadLine().ToLower().Split().ToList();
                var quantitiesEnteredMaterials = inputLine.Where((str, index) => index % 2 == 0).Select(str => str)
                    .Select(str => int.Parse(str)).ToList();
                var namesEnteredMaterials = inputLine.Where((str, index) => index % 2 == 1).Select(str => str).ToList();

                for (int i = 0; i < namesEnteredMaterials.Count; i++)
                {
                    var nameCurrentMaterial = namesEnteredMaterials[i];
                    var quantityCurrentMaterial = quantitiesEnteredMaterials[i];

                    if (nameCurrentMaterial == "shards")
                    {
                        //keyMaterialsQuantity
                        AddCurrentKeyMaterialQuantityInStock(keyMaterialsQuantity, nameCurrentMaterial, quantityCurrentMaterial);

                        if (keyMaterialsQuantity[nameCurrentMaterial] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterialsQuantity[nameCurrentMaterial] -= 250;

                            //print left material and quantity
                            PrintLeftMaterialsAndQuantity(keyMaterialsQuantity, junkMaterialsQuantity);
                            return;
                        }
                    }
                    else if (nameCurrentMaterial == "fragments")
                    {
                        //keyMaterialsQuantity
                        AddCurrentKeyMaterialQuantityInStock(keyMaterialsQuantity, nameCurrentMaterial, quantityCurrentMaterial);

                        if (keyMaterialsQuantity[nameCurrentMaterial] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterialsQuantity[nameCurrentMaterial] -= 250;

                            //print left material and quantity
                            PrintLeftMaterialsAndQuantity(keyMaterialsQuantity, junkMaterialsQuantity);
                            return;
                        }
                    }
                    else if (nameCurrentMaterial == "motes")
                    {
                        //keyMaterialsQuantity
                        AddCurrentKeyMaterialQuantityInStock(keyMaterialsQuantity, nameCurrentMaterial, quantityCurrentMaterial);

                        if (keyMaterialsQuantity[nameCurrentMaterial] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterialsQuantity[nameCurrentMaterial] -= 250;

                            //print left material and quantity
                            PrintLeftMaterialsAndQuantity(keyMaterialsQuantity, junkMaterialsQuantity);
                            return;
                        }
                    }
                    else
                    {
                        //junkMaterialsQuantity
                        AddCurrentJunkMaterialQuantity(junkMaterialsQuantity, nameCurrentMaterial, quantityCurrentMaterial);
                    }
                }
            }
        }

        static void PrintLeftMaterialsAndQuantity(SortedDictionary<string, int> keyMaterialsQuantity, SortedDictionary<string, int> junkMaterialsQuantity)
        {
            foreach (var keyMaterialQuantity in keyMaterialsQuantity.OrderByDescending(quantity => quantity.Value))
            {
                Console.WriteLine($"{keyMaterialQuantity.Key}: {keyMaterialQuantity.Value}");
            }

            foreach (var junkMaterialQuantity in junkMaterialsQuantity)
            {
                Console.WriteLine($"{junkMaterialQuantity.Key}: {junkMaterialQuantity.Value}");
            }
        }

        static void AddCurrentJunkMaterialQuantity(SortedDictionary<string, int> junkMaterialsQuantity,
            string nameCurrentMaterial, int quantityCurrentMaterial)
        {
            if (!junkMaterialsQuantity.ContainsKey(nameCurrentMaterial))
            {
                junkMaterialsQuantity.Add(nameCurrentMaterial, quantityCurrentMaterial);
            }
            else
            {
                var quantityInStock = junkMaterialsQuantity[nameCurrentMaterial];
                var totalQuantity = quantityInStock + quantityCurrentMaterial;
                junkMaterialsQuantity[nameCurrentMaterial] = totalQuantity;
            }
        }

        static void AddCurrentKeyMaterialQuantityInStock(SortedDictionary<string, int> keyMaterialsQuantity,
            string nameCurrentMaterial, int quantityCurrentMaterial)
        {
            var quantityInStock = keyMaterialsQuantity[nameCurrentMaterial];
            var totalQuantity = quantityInStock + quantityCurrentMaterial;
            keyMaterialsQuantity[nameCurrentMaterial] = totalQuantity;
        }
    }
}
