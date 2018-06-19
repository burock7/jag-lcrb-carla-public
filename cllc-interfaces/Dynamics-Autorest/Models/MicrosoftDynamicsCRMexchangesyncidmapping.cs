// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMexchangesyncidmapping
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMexchangesyncidmapping class.
        /// </summary>
        public MicrosoftDynamicsCRMexchangesyncidmapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMexchangesyncidmapping class.
        /// </summary>
        public MicrosoftDynamicsCRMexchangesyncidmapping(string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string exchangeentryid = default(string), string exchangesyncidmappingid = default(string), int? fromcrmchangetype = default(int?), bool? isdeletedinexchange = default(bool?), bool? isunlinkedincrm = default(bool?), string itemsubject = default(string), string lastsyncerror = default(string), int? lastsyncerrorcode = default(int?), System.DateTimeOffset? lastsyncerroroccurredon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string objectid = default(string), int? objecttypecode = default(int?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), int? retries = default(int?), int? tocrmchangetype = default(int?), int? userdecision = default(int?), object versionnumber = default(object))
        {
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            Createdon = createdon;
            Exchangeentryid = exchangeentryid;
            Exchangesyncidmappingid = exchangesyncidmappingid;
            Fromcrmchangetype = fromcrmchangetype;
            Isdeletedinexchange = isdeletedinexchange;
            Isunlinkedincrm = isunlinkedincrm;
            Itemsubject = itemsubject;
            Lastsyncerror = lastsyncerror;
            Lastsyncerrorcode = lastsyncerrorcode;
            Lastsyncerroroccurredon = lastsyncerroroccurredon;
            Modifiedon = modifiedon;
            Objectid = objectid;
            Objecttypecode = objecttypecode;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Owninguser = owninguser;
            Retries = retries;
            Tocrmchangetype = tocrmchangetype;
            Userdecision = userdecision;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangeentryid")]
        public string Exchangeentryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangesyncidmappingid")]
        public string Exchangesyncidmappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fromcrmchangetype")]
        public int? Fromcrmchangetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdeletedinexchange")]
        public bool? Isdeletedinexchange { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isunlinkedincrm")]
        public bool? Isunlinkedincrm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemsubject")]
        public string Itemsubject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerror")]
        public string Lastsyncerror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrorcode")]
        public int? Lastsyncerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerroroccurredon")]
        public System.DateTimeOffset? Lastsyncerroroccurredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public string Objectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "retries")]
        public int? Retries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tocrmchangetype")]
        public int? Tocrmchangetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userdecision")]
        public int? Userdecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}
