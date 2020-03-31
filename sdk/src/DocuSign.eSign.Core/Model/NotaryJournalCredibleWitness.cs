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
    /// NotaryJournalCredibleWitness
    /// </summary>
    [DataContract]
    public partial class NotaryJournalCredibleWitness :  IEquatable<NotaryJournalCredibleWitness>, IValidatableObject
    {
        public NotaryJournalCredibleWitness()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotaryJournalCredibleWitness" /> class.
        /// </summary>
        /// <param name="Address">.</param>
        /// <param name="Name">.</param>
        /// <param name="SignatureImage">.</param>
        public NotaryJournalCredibleWitness(string Address = default(string), string Name = default(string), string SignatureImage = default(string))
        {
            this.Address = Address;
            this.Name = Name;
            this.SignatureImage = SignatureImage;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureImage", EmitDefaultValue=false)]
        public string SignatureImage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotaryJournalCredibleWitness {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SignatureImage: ").Append(SignatureImage).Append("\n");
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
            return this.Equals(obj as NotaryJournalCredibleWitness);
        }

        /// <summary>
        /// Returns true if NotaryJournalCredibleWitness instances are equal
        /// </summary>
        /// <param name="other">Instance of NotaryJournalCredibleWitness to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotaryJournalCredibleWitness other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SignatureImage == other.SignatureImage ||
                    this.SignatureImage != null &&
                    this.SignatureImage.Equals(other.SignatureImage)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SignatureImage != null)
                    hash = hash * 59 + this.SignatureImage.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}