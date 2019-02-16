/* 
 * Salestream API
 *
 * Salestream API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// UpdateOpportunity
    /// </summary>
    [DataContract]
    public partial class UpdateOpportunity :  IEquatable<UpdateOpportunity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOpportunity" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="estCloseDate">estCloseDate.</param>
        /// <param name="assignee">assignee.</param>
        /// <param name="confidence">confidence.</param>
        /// <param name="contact">contact.</param>
        /// <param name="comment">comment.</param>
        public UpdateOpportunity(int? value = default(int?), int? estCloseDate = default(int?), string assignee = default(string), int? confidence = default(int?), string contact = default(string), Text comment = default(Text))
        {
            this.Value = value;
            this.EstCloseDate = estCloseDate;
            this.Assignee = assignee;
            this.Confidence = confidence;
            this.Contact = contact;
            this.Comment = comment;
        }
        
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Gets or Sets EstCloseDate
        /// </summary>
        [DataMember(Name="est_close_date", EmitDefaultValue=false)]
        public int? EstCloseDate { get; set; }

        /// <summary>
        /// Gets or Sets Assignee
        /// </summary>
        [DataMember(Name="assignee", EmitDefaultValue=false)]
        public string Assignee { get; set; }

        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public int? Confidence { get; set; }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public string Contact { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public Text Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateOpportunity {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  EstCloseDate: ").Append(EstCloseDate).Append("\n");
            sb.Append("  Assignee: ").Append(Assignee).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateOpportunity);
        }

        /// <summary>
        /// Returns true if UpdateOpportunity instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateOpportunity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOpportunity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.EstCloseDate == input.EstCloseDate ||
                    (this.EstCloseDate != null &&
                    this.EstCloseDate.Equals(input.EstCloseDate))
                ) && 
                (
                    this.Assignee == input.Assignee ||
                    (this.Assignee != null &&
                    this.Assignee.Equals(input.Assignee))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.EstCloseDate != null)
                    hashCode = hashCode * 59 + this.EstCloseDate.GetHashCode();
                if (this.Assignee != null)
                    hashCode = hashCode * 59 + this.Assignee.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
