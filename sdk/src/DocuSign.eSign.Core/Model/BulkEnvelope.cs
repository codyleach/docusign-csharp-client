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
    /// BulkEnvelope
    /// </summary>
    [DataContract]
    public partial class BulkEnvelope :  IEquatable<BulkEnvelope>, IValidatableObject
    {
        public BulkEnvelope()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkEnvelope" /> class.
        /// </summary>
        /// <param name="BulkRecipientRow">Reserved: TBD.</param>
        /// <param name="BulkStatus">Indicates the status of the bulk send operation. Returned values can be: * queued * processing * sent * failed.</param>
        /// <param name="Email">.</param>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        /// <param name="EnvelopeUri">Contains a URI for an endpoint that you can use to retrieve the envelope or envelopes..</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="Name">.</param>
        /// <param name="SubmittedDateTime">.</param>
        /// <param name="TransactionId"> Used to identify an envelope. The id is a sender-generated value and is valid in the DocuSign system for 7 days. It is recommended that a transaction ID is used for offline signing to ensure that an envelope is not sent multiple times. The &#x60;transactionId&#x60; property can be used determine an envelope&#39;s status (i.e. was it created or not) in cases where the internet connection was lost before the envelope status was returned..</param>
        public BulkEnvelope(string BulkRecipientRow = default(string), string BulkStatus = default(string), string Email = default(string), string EnvelopeId = default(string), string EnvelopeUri = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string Name = default(string), string SubmittedDateTime = default(string), string TransactionId = default(string))
        {
            this.BulkRecipientRow = BulkRecipientRow;
            this.BulkStatus = BulkStatus;
            this.Email = Email;
            this.EnvelopeId = EnvelopeId;
            this.EnvelopeUri = EnvelopeUri;
            this.ErrorDetails = ErrorDetails;
            this.Name = Name;
            this.SubmittedDateTime = SubmittedDateTime;
            this.TransactionId = TransactionId;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="bulkRecipientRow", EmitDefaultValue=false)]
        public string BulkRecipientRow { get; set; }
        /// <summary>
        /// Indicates the status of the bulk send operation. Returned values can be: * queued * processing * sent * failed
        /// </summary>
        /// <value>Indicates the status of the bulk send operation. Returned values can be: * queued * processing * sent * failed</value>
        [DataMember(Name="bulkStatus", EmitDefaultValue=false)]
        public string BulkStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// Contains a URI for an endpoint that you can use to retrieve the envelope or envelopes.
        /// </summary>
        /// <value>Contains a URI for an endpoint that you can use to retrieve the envelope or envelopes.</value>
        [DataMember(Name="envelopeUri", EmitDefaultValue=false)]
        public string EnvelopeUri { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
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
        [DataMember(Name="submittedDateTime", EmitDefaultValue=false)]
        public string SubmittedDateTime { get; set; }
        /// <summary>
        ///  Used to identify an envelope. The id is a sender-generated value and is valid in the DocuSign system for 7 days. It is recommended that a transaction ID is used for offline signing to ensure that an envelope is not sent multiple times. The &#x60;transactionId&#x60; property can be used determine an envelope&#39;s status (i.e. was it created or not) in cases where the internet connection was lost before the envelope status was returned.
        /// </summary>
        /// <value> Used to identify an envelope. The id is a sender-generated value and is valid in the DocuSign system for 7 days. It is recommended that a transaction ID is used for offline signing to ensure that an envelope is not sent multiple times. The &#x60;transactionId&#x60; property can be used determine an envelope&#39;s status (i.e. was it created or not) in cases where the internet connection was lost before the envelope status was returned.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkEnvelope {\n");
            sb.Append("  BulkRecipientRow: ").Append(BulkRecipientRow).Append("\n");
            sb.Append("  BulkStatus: ").Append(BulkStatus).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  EnvelopeUri: ").Append(EnvelopeUri).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SubmittedDateTime: ").Append(SubmittedDateTime).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(obj as BulkEnvelope);
        }

        /// <summary>
        /// Returns true if BulkEnvelope instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkEnvelope other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BulkRecipientRow == other.BulkRecipientRow ||
                    this.BulkRecipientRow != null &&
                    this.BulkRecipientRow.Equals(other.BulkRecipientRow)
                ) && 
                (
                    this.BulkStatus == other.BulkStatus ||
                    this.BulkStatus != null &&
                    this.BulkStatus.Equals(other.BulkStatus)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.EnvelopeUri == other.EnvelopeUri ||
                    this.EnvelopeUri != null &&
                    this.EnvelopeUri.Equals(other.EnvelopeUri)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SubmittedDateTime == other.SubmittedDateTime ||
                    this.SubmittedDateTime != null &&
                    this.SubmittedDateTime.Equals(other.SubmittedDateTime)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
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
                if (this.BulkRecipientRow != null)
                    hash = hash * 59 + this.BulkRecipientRow.GetHashCode();
                if (this.BulkStatus != null)
                    hash = hash * 59 + this.BulkStatus.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                if (this.EnvelopeUri != null)
                    hash = hash * 59 + this.EnvelopeUri.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SubmittedDateTime != null)
                    hash = hash * 59 + this.SubmittedDateTime.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}