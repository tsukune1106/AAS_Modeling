﻿using System.Collections.Generic;

namespace AAS_Modeling.Model.Identifier
{
    public class IRAI
    {
        public string FullCode =>
            $"0990-{AssetGeoLocation.IraiCode}{Subdivision.IraiCode}{AssetOrganization.IraiCode}-{Owner.IraiCode}#{Dimension.IraiCode}-{AssetCode.IraiCode}#{LastestVersion.IraiCode}";
        public AssetGeoLocation AssetGeoLocation { get; set; }
        public AssetSubdivision Subdivision { get; set; }
        public AssetOrganization AssetOrganization { get; set; }
        public AssetOwner Owner { get; set; }
        public AssetDimension Dimension { get; set; }
        public AssetCode AssetCode { get; set; }
        public AssetVersion LastestVersion { get; set; }
        public List<AssetVersion> Versions { get; set; }
    }
}