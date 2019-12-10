﻿using System;
using System.Collections.Generic;
using System.Globalization;

namespace AAS_Modeling
{
    public class Helper
    {
        public static BaseAsset CreateBaseAsset()
        {
            return new BaseAsset
            {
                IRAI = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta()
            };
        }

        public static TableAsset<SensorData> CreateTableAsset()
        {
            return new TableAsset<SensorData>
            {
                IRAI = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta(),
                DataModels = GeneraDataModel(),
                HasDataModel = true,
                Values = GenerateFakeSensorData()
            };
        }

        public static SingleAsset<Specification> CreateSingleAsset()
        {
            return new SingleAsset<Specification>
            {
                IRAI = Helper.GenerateSampleIrai("Machine 32A - Pressure Plate Sensor", "001"),
                AssetCategory = AssetCategory.Files,
                Created = DateTime.Now,
                LastUpdated = DateTime.Now,
                FullName = "Machine 32A - Pressure Plate Sensor",
                Description =
                    @"The JP series pressure transducers are highly cost-effective and suitable low cost, high volume commercial and industrial applications. This series are all MEMS technologies, compensated with digital ASIC. EMI/RFI circuit is built incompact laser welded stainless steel case to supply highly accurate,reliable,and stable output for limit installation space.This product is geared to the OEM customer using medium to high volumes with optional pressure ports and electrical connections.The standard version is suitable for many, but applications the dedicated design team stands ready to provide a custom design where the volume and application warrants.",
                BrokerMeta = new BrokerMeta(),
                DataModels = new List<DataModel>
                {
                    new DataModel
                    {
                        Language = "C#",
                        Model = @"    public class Specification
    {
        public Property Width;
        public Property Length;
        public Property Weight;
        public Property Capacity;
        public Property PowerCapacity;
        public Property ManufacturingDate;
    }

    public class Property
    {
        public string Name;
        public string Description;
        public bool HasUnit;
        public string Unit;
        public bool HasNumericValue;
        public object Value;
    }"
                    }
                },
                HasDataModel = true,
                Value = new Specification
                {
                    Capacity = new Property
                    {
                        Value = 450000.0,
                        Unit = "ml",
                        Description = "Used to measure the maximum capacity of the oil tanker",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Capacity"
                    },
                    Length = new Property
                    {
                        Value = 12.455,
                        Unit = "meter",
                        Description = "The total length of the machine",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Length"
                    },
                    Width = new Property
                    {
                        Value = 4.455,
                        Unit = "meter",
                        Description = "The total Width of the machine",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Width"
                    },
                    Weight = new Property
                    {
                        Value = 1245.36,
                        Unit = "Kg",
                        Description = "The total weight of the machine",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Weight"
                    },
                    PowerCapacity = new Property
                    {
                        Value = 200,
                        Unit = "Kw/H",
                        Description = "The power consumption of the machine",
                        HasUnit = true,
                        HasNumericValue = true,
                        Name = "Power Capacity"
                    },
                    ManufacturingDate = new Property
                    {
                        Value = "2009-08-02",
                        Description = "The manufacturing date of the machine",
                        HasUnit = false,
                        HasNumericValue = false,
                        Name = "Manufacturing Date"
                    }
                }
            };
        }

        public static GeoLocation CreateGeoLocation(string countryCode, string city, string zip,string longtitude = "0.00",string latitude = "0.00")
        {
            var country = new RegionInfo(countryCode);
            var wZip = zip.Replace("-", "").Replace(" ","");
            wZip = wZip.PadLeft(8, '0');
            return new GeoLocation
            {
                City = city,
                CountryCode = country.TwoLetterISORegionName,
                CountryFullName = country.EnglishName,
                WorldZipCode = wZip,
                ZipCode = zip,
                Lontitude = longtitude,
                Latitude = latitude
            };
        }

        public static IRAI GenerateSampleIrai(string assetName, string code)
        {
            return new IRAI
            {
                GeoLocation = CreateGeoLocation("MY","Shah Alam", "40460 ", "3.008507", "101.520867"),
                Organization = new Organization
                {
                    
                    IraiCode = "0001",
                    Email = "User001@mail.com",
                    Handphone = "+60123456789",
                    Phone = "1300-88-2525",
                    Name = "Ajiya Roofing KK",
                    RegistrationNumber = "01-23456",
                    IndustryCode = "C",
                    Website = "tarc.edu.my"
                },
                Subdivision = new AssetSubdivision
                {
                    IraiCode = "C18",
                    Description = "Manufacture of metal works"
                },
                Dimension = new AssetDimension
                {
                    IraiCode = "SA",
                    Dimensions = "Shop Floor Automation",
                    Thrust = "Asset Automation",
                    ShiftFactor = "Technology"
                },
                Owner = new AssetOwner
                {
                    IraiCode = "05",
                    OwnerDescription = "Engineering/ Technology"
                },
                AssetCode = new AssetCode
                {
                    AssetDescription = assetName,
                    Site = "A1",
                    Area = "A2",
                    Process = "01",
                    Code = code
                },
                Versions = new List<AssetVersion>
                {
                    new AssetVersion
                    {
                        IraiCode = "0001",
                        VersionDescription = "Initial Creation"
                    },
                    new AssetVersion
                    {
                        IraiCode = "0002",
                        VersionDescription = "Updated data X"
                    },
                    new AssetVersion
                    {
                        IraiCode = "0003",
                        VersionDescription = "Updated semantic Y"
                    },
                },
                LastestVersion = new AssetVersion
                {
                    IraiCode = "0003",
                    VersionDescription = "Updated semantic Y"
                }
            };
        }

        public static List<SensorData> GenerateFakeSensorData()
        {
            var r = new Random();
            var sensor = new List<SensorData>();
            for (int i = 0; i < 20; i++)
            {
                sensor.Add(new SensorData
                {
                    Time = DateTime.Now.AddSeconds(i),
                    Value = r.NextDouble()
                });
            }

            return sensor;
        }

        public static List<DataModel> GeneraDataModel()
        {
            return new List<DataModel>
            {
                new DataModel
                {
                    Language = "C#",
                    Model = @"class SensorData
{
public DateTime Time;
public double Value;
}"
                },
                new DataModel
                {
                    Language = "c++",
                    Model = @"class SensorData
{
public:
string time;
double value;
}"
                }
            };
        }
    }
}