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
    /// CreateSms
    /// </summary>
    [DataContract]
    public partial class CreateSms :  IEquatable<CreateSms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSms" /> class.
        /// </summary>
        /// <param name="phoneId">phoneId.</param>
        /// <param name="detailId">detailId.</param>
        /// <param name="message">message.</param>
        /// <param name="draft">draft.</param>
        /// <param name="schedule">schedule.</param>
        public CreateSms(string phoneId = default(string), string detailId = default(string), Text message = default(Text), bool? draft = default(bool?), int? schedule = default(int?))
        {
            this.PhoneId = phoneId;
            this.DetailId = detailId;
            this.Message = message;
            this.Draft = draft;
            this.Schedule = schedule;
        }
        
        /// <summary>
        /// Gets or Sets PhoneId
        /// </summary>
        [DataMember(Name="phoneId", EmitDefaultValue=false)]
        public string PhoneId { get; set; }

        /// <summary>
        /// Gets or Sets DetailId
        /// </summary>
        [DataMember(Name="detailId", EmitDefaultValue=false)]
        public string DetailId { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public Text Message { get; set; }

        /// <summary>
        /// Gets or Sets Draft
        /// </summary>
        [DataMember(Name="draft", EmitDefaultValue=false)]
        public bool? Draft { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public int? Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSms {\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            sb.Append("  DetailId: ").Append(DetailId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Draft: ").Append(Draft).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
            return this.Equals(input as CreateSms);
        }

        /// <summary>
        /// Returns true if CreateSms instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneId == input.PhoneId ||
                    (this.PhoneId != null &&
                    this.PhoneId.Equals(input.PhoneId))
                ) && 
                (
                    this.DetailId == input.DetailId ||
                    (this.DetailId != null &&
                    this.DetailId.Equals(input.DetailId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Draft == input.Draft ||
                    (this.Draft != null &&
                    this.Draft.Equals(input.Draft))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.PhoneId != null)
                    hashCode = hashCode * 59 + this.PhoneId.GetHashCode();
                if (this.DetailId != null)
                    hashCode = hashCode * 59 + this.DetailId.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Draft != null)
                    hashCode = hashCode * 59 + this.Draft.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
