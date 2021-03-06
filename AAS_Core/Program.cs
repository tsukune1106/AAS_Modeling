﻿using System;
using System.IO;
using AAS_Core.Core;
using Newtonsoft.Json;

namespace AAS_Core
{
    class Program
    {
        static void Main(string[] args)
        {
           // MongoHelper.CreateAsset(Helper.CreateBaseAsset());
            MongoHelper.CreateSubdivisionInDb();
//            foreach (var region in RegionFactory.GetAllRegionInfos())
//            {
//                Console.WriteLine($"[{region.TwoLetterISORegionName}] - {region.EnglishName}");
//            }
//
//            Console.WriteLine($"Total country: {RegionFactory.GetAllRegionInfos().Count}");
            Console.WriteLine("Done");
            Console.Read();
        }

        static void GenerateMetaFiles()
        {
            File.WriteAllText(@"Meta.json", JsonConvert.SerializeObject(Helper.CreateBaseAsset(), Formatting.Indented));

            File.WriteAllText(@"Table.json", JsonConvert.SerializeObject(Helper.CreateTableAsset(), Formatting.Indented));

            File.WriteAllText(@"Single.json", JsonConvert.SerializeObject(Helper.CreateSingleAsset(), Formatting.Indented));

            File.WriteAllText(@"File.json", JsonConvert.SerializeObject(Helper.CreateFileAsset(), Formatting.Indented));
        }
    }
}