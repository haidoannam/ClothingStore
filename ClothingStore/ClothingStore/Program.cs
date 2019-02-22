using ClothingStore.Models;
using System;
using System.Collections.Generic;

namespace ClothingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // vendor to buy clothing
            var clothingBuyVendors = new List<ShirtModel>
            {
                new ShirtModel
                {
                    Name = "T-Shirt",
                    Price = 6,
                    Colors = new List<string>{"Red", "Yellow"},
                    Sizes = new List<string>{"Large", "Medium"}
                },
                new ShirtModel
                {
                    Name = "Dress-Shirt",
                    Price = 8,
                    Colors = new List<string>{"Red", "Yellow"},
                    Sizes = new List<string>{"Large", "Medium"}
                }
            };

            // Vendor sell clothing
            var clothingSellVendors = new List<ShirtModel>
            {
                new ShirtModel
                {
                    Name = "T-Shirt",
                    Price = 12,
                    Colors = new List<string>{"Red", "Yellow"},
                    Sizes = new List<string>{"Large", "Medium"}
                },
                new ShirtModel
                {
                    Name = "Dress-Shirt",
                    Price = 20,
                    Colors = new List<string>{"Red", "Yellow"},
                    Sizes = new List<string>{"Large", "Medium"}
                }
            };
        }
            


        }
    }

