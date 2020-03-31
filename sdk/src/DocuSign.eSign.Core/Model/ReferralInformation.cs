/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// A complex type that contains the following information for entering referral and discount information. The following items are included in the referral information (all string content): enableSupport, includedSeats, saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, saleDiscountSeatPriceOverride, planStartMonth, referralCode, referrerName, advertisementId, publisherId, shopperId, promoCode, groupMemberId, idType, and industry   ###### Note: saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, and saleDiscountSeatPriceOverride are reserved for DoucSign use only.
    /// </summary>
    [DataContract]
    public partial class ReferralInformation :  IEquatable<ReferralInformation>, IValidatableObject
    {
        public ReferralInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralInformation" /> class.
        /// </summary>
        /// <param name="AdvertisementId">A complex type that contains the following information for entering referral and discount information. The following items are included in the referral information (all string content): enableSupport, includedSeats, saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, saleDiscountSeatPriceOverride, planStartMonth, referralCode, referrerName, advertisementId, publisherId, shopperId, promoCode, groupMemberId, idType, and industry.  ###### Note: saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, and saleDiscountSeatPriceOverride are reserved for DoucSign use only.  .</param>
        /// <param name="EnableSupport">When set to **true**, then customer support is provided as part of the account plan..</param>
        /// <param name="ExternalOrgId">.</param>
        /// <param name="GroupMemberId">.</param>
        /// <param name="IdType">.</param>
        /// <param name="IncludedSeats">The number of seats (users) included..</param>
        /// <param name="Industry">.</param>
        /// <param name="PlanStartMonth">.</param>
        /// <param name="PromoCode">.</param>
        /// <param name="PublisherId">.</param>
        /// <param name="ReferralCode">.</param>
        /// <param name="ReferrerName">.</param>
        /// <param name="SaleDiscountAmount">Reserved for DocuSign use only..</param>
        /// <param name="SaleDiscountFixedAmount">Reserved for DocuSign use only..</param>
        /// <param name="SaleDiscountPercent">Reserved for DocuSign use only..</param>
        /// <param name="SaleDiscountPeriods">Reserved for DocuSign use only..</param>
        /// <param name="SaleDiscountSeatPriceOverride">Reserved for DocuSign use only..</param>
        /// <param name="ShopperId">.</param>
        public ReferralInformation(string AdvertisementId = default(string), string EnableSupport = default(string), string ExternalOrgId = default(string), string GroupMemberId = default(string), string IdType = default(string), string IncludedSeats = default(string), string Industry = default(string), string PlanStartMonth = default(string), string PromoCode = default(string), string PublisherId = default(string), string ReferralCode = default(string), string ReferrerName = default(string), string SaleDiscountAmount = default(string), string SaleDiscountFixedAmount = default(string), string SaleDiscountPercent = default(string), string SaleDiscountPeriods = default(string), string SaleDiscountSeatPriceOverride = default(string), string ShopperId = default(string))
        {
            this.AdvertisementId = AdvertisementId;
            this.EnableSupport = EnableSupport;
            this.ExternalOrgId = ExternalOrgId;
            this.GroupMemberId = GroupMemberId;
            this.IdType = IdType;
            this.IncludedSeats = IncludedSeats;
            this.Industry = Industry;
            this.PlanStartMonth = PlanStartMonth;
            this.PromoCode = PromoCode;
            this.PublisherId = PublisherId;
            this.ReferralCode = ReferralCode;
            this.ReferrerName = ReferrerName;
            this.SaleDiscountAmount = SaleDiscountAmount;
            this.SaleDiscountFixedAmount = SaleDiscountFixedAmount;
            this.SaleDiscountPercent = SaleDiscountPercent;
            this.SaleDiscountPeriods = SaleDiscountPeriods;
            this.SaleDiscountSeatPriceOverride = SaleDiscountSeatPriceOverride;
            this.ShopperId = ShopperId;
        }
        
        /// <summary>
        /// A complex type that contains the following information for entering referral and discount information. The following items are included in the referral information (all string content): enableSupport, includedSeats, saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, saleDiscountSeatPriceOverride, planStartMonth, referralCode, referrerName, advertisementId, publisherId, shopperId, promoCode, groupMemberId, idType, and industry.  ###### Note: saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, and saleDiscountSeatPriceOverride are reserved for DoucSign use only.  
        /// </summary>
        /// <value>A complex type that contains the following information for entering referral and discount information. The following items are included in the referral information (all string content): enableSupport, includedSeats, saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, saleDiscountSeatPriceOverride, planStartMonth, referralCode, referrerName, advertisementId, publisherId, shopperId, promoCode, groupMemberId, idType, and industry.  ###### Note: saleDiscountPercent, saleDiscountAmount, saleDiscountFixedAmount, saleDiscountPeriods, and saleDiscountSeatPriceOverride are reserved for DoucSign use only.  </value>
        [DataMember(Name="advertisementId", EmitDefaultValue=false)]
        public string AdvertisementId { get; set; }
        /// <summary>
        /// When set to **true**, then customer support is provided as part of the account plan.
        /// </summary>
        /// <value>When set to **true**, then customer support is provided as part of the account plan.</value>
        [DataMember(Name="enableSupport", EmitDefaultValue=false)]
        public string EnableSupport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="externalOrgId", EmitDefaultValue=false)]
        public string ExternalOrgId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="groupMemberId", EmitDefaultValue=false)]
        public string GroupMemberId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="idType", EmitDefaultValue=false)]
        public string IdType { get; set; }
        /// <summary>
        /// The number of seats (users) included.
        /// </summary>
        /// <value>The number of seats (users) included.</value>
        [DataMember(Name="includedSeats", EmitDefaultValue=false)]
        public string IncludedSeats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public string Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="planStartMonth", EmitDefaultValue=false)]
        public string PlanStartMonth { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="promoCode", EmitDefaultValue=false)]
        public string PromoCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="publisherId", EmitDefaultValue=false)]
        public string PublisherId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="referralCode", EmitDefaultValue=false)]
        public string ReferralCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="referrerName", EmitDefaultValue=false)]
        public string ReferrerName { get; set; }
        /// <summary>
        /// Reserved for DocuSign use only.
        /// </summary>
        /// <value>Reserved for DocuSign use only.</value>
        [DataMember(Name="saleDiscountAmount", EmitDefaultValue=false)]
        public string SaleDiscountAmount { get; set; }
        /// <summary>
        /// Reserved for DocuSign use only.
        /// </summary>
        /// <value>Reserved for DocuSign use only.</value>
        [DataMember(Name="saleDiscountFixedAmount", EmitDefaultValue=false)]
        public string SaleDiscountFixedAmount { get; set; }
        /// <summary>
        /// Reserved for DocuSign use only.
        /// </summary>
        /// <value>Reserved for DocuSign use only.</value>
        [DataMember(Name="saleDiscountPercent", EmitDefaultValue=false)]
        public string SaleDiscountPercent { get; set; }
        /// <summary>
        /// Reserved for DocuSign use only.
        /// </summary>
        /// <value>Reserved for DocuSign use only.</value>
        [DataMember(Name="saleDiscountPeriods", EmitDefaultValue=false)]
        public string SaleDiscountPeriods { get; set; }
        /// <summary>
        /// Reserved for DocuSign use only.
        /// </summary>
        /// <value>Reserved for DocuSign use only.</value>
        [DataMember(Name="saleDiscountSeatPriceOverride", EmitDefaultValue=false)]
        public string SaleDiscountSeatPriceOverride { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="shopperId", EmitDefaultValue=false)]
        public string ShopperId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReferralInformation {\n");
            sb.Append("  AdvertisementId: ").Append(AdvertisementId).Append("\n");
            sb.Append("  EnableSupport: ").Append(EnableSupport).Append("\n");
            sb.Append("  ExternalOrgId: ").Append(ExternalOrgId).Append("\n");
            sb.Append("  GroupMemberId: ").Append(GroupMemberId).Append("\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  IncludedSeats: ").Append(IncludedSeats).Append("\n");
            sb.Append("  Industry: ").Append(Industry).Append("\n");
            sb.Append("  PlanStartMonth: ").Append(PlanStartMonth).Append("\n");
            sb.Append("  PromoCode: ").Append(PromoCode).Append("\n");
            sb.Append("  PublisherId: ").Append(PublisherId).Append("\n");
            sb.Append("  ReferralCode: ").Append(ReferralCode).Append("\n");
            sb.Append("  ReferrerName: ").Append(ReferrerName).Append("\n");
            sb.Append("  SaleDiscountAmount: ").Append(SaleDiscountAmount).Append("\n");
            sb.Append("  SaleDiscountFixedAmount: ").Append(SaleDiscountFixedAmount).Append("\n");
            sb.Append("  SaleDiscountPercent: ").Append(SaleDiscountPercent).Append("\n");
            sb.Append("  SaleDiscountPeriods: ").Append(SaleDiscountPeriods).Append("\n");
            sb.Append("  SaleDiscountSeatPriceOverride: ").Append(SaleDiscountSeatPriceOverride).Append("\n");
            sb.Append("  ShopperId: ").Append(ShopperId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ReferralInformation);
        }

        /// <summary>
        /// Returns true if ReferralInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of ReferralInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReferralInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdvertisementId == other.AdvertisementId ||
                    this.AdvertisementId != null &&
                    this.AdvertisementId.Equals(other.AdvertisementId)
                ) && 
                (
                    this.EnableSupport == other.EnableSupport ||
                    this.EnableSupport != null &&
                    this.EnableSupport.Equals(other.EnableSupport)
                ) && 
                (
                    this.ExternalOrgId == other.ExternalOrgId ||
                    this.ExternalOrgId != null &&
                    this.ExternalOrgId.Equals(other.ExternalOrgId)
                ) && 
                (
                    this.GroupMemberId == other.GroupMemberId ||
                    this.GroupMemberId != null &&
                    this.GroupMemberId.Equals(other.GroupMemberId)
                ) && 
                (
                    this.IdType == other.IdType ||
                    this.IdType != null &&
                    this.IdType.Equals(other.IdType)
                ) && 
                (
                    this.IncludedSeats == other.IncludedSeats ||
                    this.IncludedSeats != null &&
                    this.IncludedSeats.Equals(other.IncludedSeats)
                ) && 
                (
                    this.Industry == other.Industry ||
                    this.Industry != null &&
                    this.Industry.Equals(other.Industry)
                ) && 
                (
                    this.PlanStartMonth == other.PlanStartMonth ||
                    this.PlanStartMonth != null &&
                    this.PlanStartMonth.Equals(other.PlanStartMonth)
                ) && 
                (
                    this.PromoCode == other.PromoCode ||
                    this.PromoCode != null &&
                    this.PromoCode.Equals(other.PromoCode)
                ) && 
                (
                    this.PublisherId == other.PublisherId ||
                    this.PublisherId != null &&
                    this.PublisherId.Equals(other.PublisherId)
                ) && 
                (
                    this.ReferralCode == other.ReferralCode ||
                    this.ReferralCode != null &&
                    this.ReferralCode.Equals(other.ReferralCode)
                ) && 
                (
                    this.ReferrerName == other.ReferrerName ||
                    this.ReferrerName != null &&
                    this.ReferrerName.Equals(other.ReferrerName)
                ) && 
                (
                    this.SaleDiscountAmount == other.SaleDiscountAmount ||
                    this.SaleDiscountAmount != null &&
                    this.SaleDiscountAmount.Equals(other.SaleDiscountAmount)
                ) && 
                (
                    this.SaleDiscountFixedAmount == other.SaleDiscountFixedAmount ||
                    this.SaleDiscountFixedAmount != null &&
                    this.SaleDiscountFixedAmount.Equals(other.SaleDiscountFixedAmount)
                ) && 
                (
                    this.SaleDiscountPercent == other.SaleDiscountPercent ||
                    this.SaleDiscountPercent != null &&
                    this.SaleDiscountPercent.Equals(other.SaleDiscountPercent)
                ) && 
                (
                    this.SaleDiscountPeriods == other.SaleDiscountPeriods ||
                    this.SaleDiscountPeriods != null &&
                    this.SaleDiscountPeriods.Equals(other.SaleDiscountPeriods)
                ) && 
                (
                    this.SaleDiscountSeatPriceOverride == other.SaleDiscountSeatPriceOverride ||
                    this.SaleDiscountSeatPriceOverride != null &&
                    this.SaleDiscountSeatPriceOverride.Equals(other.SaleDiscountSeatPriceOverride)
                ) && 
                (
                    this.ShopperId == other.ShopperId ||
                    this.ShopperId != null &&
                    this.ShopperId.Equals(other.ShopperId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AdvertisementId != null)
                    hash = hash * 59 + this.AdvertisementId.GetHashCode();
                if (this.EnableSupport != null)
                    hash = hash * 59 + this.EnableSupport.GetHashCode();
                if (this.ExternalOrgId != null)
                    hash = hash * 59 + this.ExternalOrgId.GetHashCode();
                if (this.GroupMemberId != null)
                    hash = hash * 59 + this.GroupMemberId.GetHashCode();
                if (this.IdType != null)
                    hash = hash * 59 + this.IdType.GetHashCode();
                if (this.IncludedSeats != null)
                    hash = hash * 59 + this.IncludedSeats.GetHashCode();
                if (this.Industry != null)
                    hash = hash * 59 + this.Industry.GetHashCode();
                if (this.PlanStartMonth != null)
                    hash = hash * 59 + this.PlanStartMonth.GetHashCode();
                if (this.PromoCode != null)
                    hash = hash * 59 + this.PromoCode.GetHashCode();
                if (this.PublisherId != null)
                    hash = hash * 59 + this.PublisherId.GetHashCode();
                if (this.ReferralCode != null)
                    hash = hash * 59 + this.ReferralCode.GetHashCode();
                if (this.ReferrerName != null)
                    hash = hash * 59 + this.ReferrerName.GetHashCode();
                if (this.SaleDiscountAmount != null)
                    hash = hash * 59 + this.SaleDiscountAmount.GetHashCode();
                if (this.SaleDiscountFixedAmount != null)
                    hash = hash * 59 + this.SaleDiscountFixedAmount.GetHashCode();
                if (this.SaleDiscountPercent != null)
                    hash = hash * 59 + this.SaleDiscountPercent.GetHashCode();
                if (this.SaleDiscountPeriods != null)
                    hash = hash * 59 + this.SaleDiscountPeriods.GetHashCode();
                if (this.SaleDiscountSeatPriceOverride != null)
                    hash = hash * 59 + this.SaleDiscountSeatPriceOverride.GetHashCode();
                if (this.ShopperId != null)
                    hash = hash * 59 + this.ShopperId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}