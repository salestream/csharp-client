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
    /// CreateContactDetails
    /// </summary>
    [DataContract]
    public partial class CreateContactDetails :  IEquatable<CreateContactDetails>, IValidatableObject
    {
        /// <summary>
        /// Defines Contact
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContactEnum
        {
            /// <summary>
            /// Enum Direct for value: direct
            /// </summary>
            [EnumMember(Value = "direct")]
            Direct = 1,

            /// <summary>
            /// Enum Fax for value: fax
            /// </summary>
            [EnumMember(Value = "fax")]
            Fax = 2,

            /// <summary>
            /// Enum Home for value: home
            /// </summary>
            [EnumMember(Value = "home")]
            Home = 3,

            /// <summary>
            /// Enum Mobile for value: mobile
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile = 4,

            /// <summary>
            /// Enum Office for value: office
            /// </summary>
            [EnumMember(Value = "office")]
            Office = 5,

            /// <summary>
            /// Enum Url for value: url
            /// </summary>
            [EnumMember(Value = "url")]
            Url = 6,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 7

        }

        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="contact", EmitDefaultValue=false)]
        public ContactEnum? Contact { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContactDetails" /> class.
        /// </summary>
        /// <param name="contact">contact.</param>
        public CreateContactDetails(ContactEnum? contact = default(ContactEnum?))
        {
            this.Contact = contact;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateContactDetails {\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
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
            return this.Equals(input as CreateContactDetails);
        }

        /// <summary>
        /// Returns true if CreateContactDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateContactDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
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
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
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
