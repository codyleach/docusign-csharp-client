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
    /// IdCheckConfiguration
    /// </summary>
    [DataContract]
    public partial class IdCheckConfiguration :  IEquatable<IdCheckConfiguration>, IValidatableObject
    {
        public IdCheckConfiguration()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdCheckConfiguration" /> class.
        /// </summary>
        /// <param name="AuthSteps">.</param>
        /// <param name="IsDefault">.</param>
        /// <param name="Name">.</param>
        public IdCheckConfiguration(List<IdCheckSecurityStep> AuthSteps = default(List<IdCheckSecurityStep>), string IsDefault = default(string), string Name = default(string))
        {
            this.AuthSteps = AuthSteps;
            this.IsDefault = IsDefault;
            this.Name = Name;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="authSteps", EmitDefaultValue=false)]
        public List<IdCheckSecurityStep> AuthSteps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public string IsDefault { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdCheckConfiguration {\n");
            sb.Append("  AuthSteps: ").Append(AuthSteps).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as IdCheckConfiguration);
        }

        /// <summary>
        /// Returns true if IdCheckConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of IdCheckConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdCheckConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthSteps == other.AuthSteps ||
                    this.AuthSteps != null &&
                    this.AuthSteps.SequenceEqual(other.AuthSteps)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.AuthSteps != null)
                    hash = hash * 59 + this.AuthSteps.GetHashCode();
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
