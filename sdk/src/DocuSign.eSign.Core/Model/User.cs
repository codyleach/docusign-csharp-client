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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        public User()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="CellPhoneNumber">.</param>
        /// <param name="CountryCode">.</param>
        /// <param name="Credentials">.</param>
        /// <param name="DisplayName">.</param>
        /// <param name="Email">.</param>
        /// <param name="ExternalClaims">.</param>
        public User(string CellPhoneNumber = default(string), string CountryCode = default(string), List<Credential> Credentials = default(List<Credential>), string DisplayName = default(string), string Email = default(string), List<ExternalClaim> ExternalClaims = default(List<ExternalClaim>))
        {
            this.CellPhoneNumber = CellPhoneNumber;
            this.CountryCode = CountryCode;
            this.Credentials = Credentials;
            this.DisplayName = DisplayName;
            this.Email = Email;
            this.ExternalClaims = ExternalClaims;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="cellPhoneNumber", EmitDefaultValue=false)]
        public string CellPhoneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="credentials", EmitDefaultValue=false)]
        public List<Credential> Credentials { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="externalClaims", EmitDefaultValue=false)]
        public List<ExternalClaim> ExternalClaims { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  CellPhoneNumber: ").Append(CellPhoneNumber).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ExternalClaims: ").Append(ExternalClaims).Append("\n");
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
            return this.Equals(obj as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="other">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CellPhoneNumber == other.CellPhoneNumber ||
                    this.CellPhoneNumber != null &&
                    this.CellPhoneNumber.Equals(other.CellPhoneNumber)
                ) && 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.Credentials == other.Credentials ||
                    this.Credentials != null &&
                    this.Credentials.SequenceEqual(other.Credentials)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.ExternalClaims == other.ExternalClaims ||
                    this.ExternalClaims != null &&
                    this.ExternalClaims.SequenceEqual(other.ExternalClaims)
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
                if (this.CellPhoneNumber != null)
                    hash = hash * 59 + this.CellPhoneNumber.GetHashCode();
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.Credentials != null)
                    hash = hash * 59 + this.Credentials.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.ExternalClaims != null)
                    hash = hash * 59 + this.ExternalClaims.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
