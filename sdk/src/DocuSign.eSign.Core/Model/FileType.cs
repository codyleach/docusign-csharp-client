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
    /// FileType
    /// </summary>
    [DataContract]
    public partial class FileType :  IEquatable<FileType>, IValidatableObject
    {
        public FileType()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileType" /> class.
        /// </summary>
        /// <param name="FileExtension">.</param>
        /// <param name="MimeType">The mime-type of a file type listed in a fileTypes collection..</param>
        public FileType(string FileExtension = default(string), string MimeType = default(string))
        {
            this.FileExtension = FileExtension;
            this.MimeType = MimeType;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="fileExtension", EmitDefaultValue=false)]
        public string FileExtension { get; set; }
        /// <summary>
        /// The mime-type of a file type listed in a fileTypes collection.
        /// </summary>
        /// <value>The mime-type of a file type listed in a fileTypes collection.</value>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileType {\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
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
            return this.Equals(obj as FileType);
        }

        /// <summary>
        /// Returns true if FileType instances are equal
        /// </summary>
        /// <param name="other">Instance of FileType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FileExtension == other.FileExtension ||
                    this.FileExtension != null &&
                    this.FileExtension.Equals(other.FileExtension)
                ) && 
                (
                    this.MimeType == other.MimeType ||
                    this.MimeType != null &&
                    this.MimeType.Equals(other.MimeType)
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
                if (this.FileExtension != null)
                    hash = hash * 59 + this.FileExtension.GetHashCode();
                if (this.MimeType != null)
                    hash = hash * 59 + this.MimeType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}