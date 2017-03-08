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
    /// AccountSignatureProviders
    /// </summary>
    [DataContract]
    public partial class AccountSignatureProviders :  IEquatable<AccountSignatureProviders>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountSignatureProviders" /> class.
        /// </summary>
        /// <param name="SignatureProviders">.</param>
        public AccountSignatureProviders(List<AccountSignatureProvider> SignatureProviders = default(List<AccountSignatureProvider>))
        {
            this.SignatureProviders = SignatureProviders;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="signatureProviders", EmitDefaultValue=false)]
        public List<AccountSignatureProvider> SignatureProviders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountSignatureProviders {\n");
            sb.Append("  SignatureProviders: ").Append(SignatureProviders).Append("\n");
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
            return this.Equals(obj as AccountSignatureProviders);
        }

        /// <summary>
        /// Returns true if AccountSignatureProviders instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountSignatureProviders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountSignatureProviders other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SignatureProviders == other.SignatureProviders ||
                    this.SignatureProviders != null &&
                    this.SignatureProviders.SequenceEqual(other.SignatureProviders)
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
                if (this.SignatureProviders != null)
                    hash = hash * 59 + this.SignatureProviders.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
