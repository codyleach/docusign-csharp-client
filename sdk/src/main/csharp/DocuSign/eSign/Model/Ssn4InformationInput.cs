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
    /// Ssn4InformationInput
    /// </summary>
    [DataContract]
    public partial class Ssn4InformationInput :  IEquatable<Ssn4InformationInput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ssn4InformationInput" /> class.
        /// </summary>
        /// <param name="DisplayLevelCode">Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay.</param>
        /// <param name="ReceiveInResponse">When set to **true**, the information needs to be returned in the response..</param>
        /// <param name="Ssn4">The last four digits of the recipient&#39;s Social Security Number (SSN)..</param>
        public Ssn4InformationInput(string DisplayLevelCode = default(string), string ReceiveInResponse = default(string), string Ssn4 = default(string))
        {
            this.DisplayLevelCode = DisplayLevelCode;
            this.ReceiveInResponse = ReceiveInResponse;
            this.Ssn4 = Ssn4;
        }
        
        /// <summary>
        /// Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay
        /// </summary>
        /// <value>Specifies the display level for the recipient.  Valid values are:   * ReadOnly * Editable * DoNotDisplay</value>
        [DataMember(Name="displayLevelCode", EmitDefaultValue=false)]
        public string DisplayLevelCode { get; set; }
        /// <summary>
        /// When set to **true**, the information needs to be returned in the response.
        /// </summary>
        /// <value>When set to **true**, the information needs to be returned in the response.</value>
        [DataMember(Name="receiveInResponse", EmitDefaultValue=false)]
        public string ReceiveInResponse { get; set; }
        /// <summary>
        /// The last four digits of the recipient&#39;s Social Security Number (SSN).
        /// </summary>
        /// <value>The last four digits of the recipient&#39;s Social Security Number (SSN).</value>
        [DataMember(Name="ssn4", EmitDefaultValue=false)]
        public string Ssn4 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ssn4InformationInput {\n");
            sb.Append("  DisplayLevelCode: ").Append(DisplayLevelCode).Append("\n");
            sb.Append("  ReceiveInResponse: ").Append(ReceiveInResponse).Append("\n");
            sb.Append("  Ssn4: ").Append(Ssn4).Append("\n");
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
            return this.Equals(obj as Ssn4InformationInput);
        }

        /// <summary>
        /// Returns true if Ssn4InformationInput instances are equal
        /// </summary>
        /// <param name="other">Instance of Ssn4InformationInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ssn4InformationInput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayLevelCode == other.DisplayLevelCode ||
                    this.DisplayLevelCode != null &&
                    this.DisplayLevelCode.Equals(other.DisplayLevelCode)
                ) && 
                (
                    this.ReceiveInResponse == other.ReceiveInResponse ||
                    this.ReceiveInResponse != null &&
                    this.ReceiveInResponse.Equals(other.ReceiveInResponse)
                ) && 
                (
                    this.Ssn4 == other.Ssn4 ||
                    this.Ssn4 != null &&
                    this.Ssn4.Equals(other.Ssn4)
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
                if (this.DisplayLevelCode != null)
                    hash = hash * 59 + this.DisplayLevelCode.GetHashCode();
                if (this.ReceiveInResponse != null)
                    hash = hash * 59 + this.ReceiveInResponse.GetHashCode();
                if (this.Ssn4 != null)
                    hash = hash * 59 + this.Ssn4.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
