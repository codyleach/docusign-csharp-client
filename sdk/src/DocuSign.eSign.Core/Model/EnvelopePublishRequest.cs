/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
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
    /// EnvelopePublishRequest
    /// </summary>
    [DataContract]
    public partial class EnvelopePublishRequest :  IEquatable<EnvelopePublishRequest>, IValidatableObject
    {
        public EnvelopePublishRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopePublishRequest" /> class.
        /// </summary>
        /// <param name="ApplyConnectSettings">.</param>
        /// <param name="EnvelopeIds">.</param>
        /// <param name="EnvelopeIdsBase64">.</param>
        public EnvelopePublishRequest(string ApplyConnectSettings = default(string), List<string> EnvelopeIds = default(List<string>), string EnvelopeIdsBase64 = default(string))
        {
            this.ApplyConnectSettings = ApplyConnectSettings;
            this.EnvelopeIds = EnvelopeIds;
            this.EnvelopeIdsBase64 = EnvelopeIdsBase64;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="applyConnectSettings", EmitDefaultValue=false)]
        public string ApplyConnectSettings { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopeIds", EmitDefaultValue=false)]
        public List<string> EnvelopeIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="envelopeIdsBase64", EmitDefaultValue=false)]
        public string EnvelopeIdsBase64 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopePublishRequest {\n");
            sb.Append("  ApplyConnectSettings: ").Append(ApplyConnectSettings).Append("\n");
            sb.Append("  EnvelopeIds: ").Append(EnvelopeIds).Append("\n");
            sb.Append("  EnvelopeIdsBase64: ").Append(EnvelopeIdsBase64).Append("\n");
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
            return this.Equals(obj as EnvelopePublishRequest);
        }

        /// <summary>
        /// Returns true if EnvelopePublishRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopePublishRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopePublishRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApplyConnectSettings == other.ApplyConnectSettings ||
                    this.ApplyConnectSettings != null &&
                    this.ApplyConnectSettings.Equals(other.ApplyConnectSettings)
                ) && 
                (
                    this.EnvelopeIds == other.EnvelopeIds ||
                    this.EnvelopeIds != null &&
                    this.EnvelopeIds.SequenceEqual(other.EnvelopeIds)
                ) && 
                (
                    this.EnvelopeIdsBase64 == other.EnvelopeIdsBase64 ||
                    this.EnvelopeIdsBase64 != null &&
                    this.EnvelopeIdsBase64.Equals(other.EnvelopeIdsBase64)
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
                if (this.ApplyConnectSettings != null)
                    hash = hash * 59 + this.ApplyConnectSettings.GetHashCode();
                if (this.EnvelopeIds != null)
                    hash = hash * 59 + this.EnvelopeIds.GetHashCode();
                if (this.EnvelopeIdsBase64 != null)
                    hash = hash * 59 + this.EnvelopeIdsBase64.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
