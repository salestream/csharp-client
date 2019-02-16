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
    /// CreateWebhook
    /// </summary>
    [DataContract]
    public partial class CreateWebhook :  IEquatable<CreateWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhook" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebhook() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhook" /> class.
        /// </summary>
        /// <param name="url">url (required).</param>
        /// <param name="fallbackUrl">fallbackUrl.</param>
        /// <param name="errorUrl">errorUrl.</param>
        /// <param name="timeout">timeout.</param>
        /// <param name="retryAttempts">retryAttempts.</param>
        public CreateWebhook(string url = default(string), string fallbackUrl = default(string), string errorUrl = default(string), int? timeout = default(int?), int? retryAttempts = default(int?))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for CreateWebhook and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            this.FallbackUrl = fallbackUrl;
            this.ErrorUrl = errorUrl;
            this.Timeout = timeout;
            this.RetryAttempts = retryAttempts;
        }
        
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets FallbackUrl
        /// </summary>
        [DataMember(Name="fallback_url", EmitDefaultValue=false)]
        public string FallbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets ErrorUrl
        /// </summary>
        [DataMember(Name="error_url", EmitDefaultValue=false)]
        public string ErrorUrl { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name="timeout", EmitDefaultValue=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or Sets RetryAttempts
        /// </summary>
        [DataMember(Name="retry_attempts", EmitDefaultValue=false)]
        public int? RetryAttempts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateWebhook {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FallbackUrl: ").Append(FallbackUrl).Append("\n");
            sb.Append("  ErrorUrl: ").Append(ErrorUrl).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  RetryAttempts: ").Append(RetryAttempts).Append("\n");
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
            return this.Equals(input as CreateWebhook);
        }

        /// <summary>
        /// Returns true if CreateWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebhook input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.FallbackUrl == input.FallbackUrl ||
                    (this.FallbackUrl != null &&
                    this.FallbackUrl.Equals(input.FallbackUrl))
                ) && 
                (
                    this.ErrorUrl == input.ErrorUrl ||
                    (this.ErrorUrl != null &&
                    this.ErrorUrl.Equals(input.ErrorUrl))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.RetryAttempts == input.RetryAttempts ||
                    (this.RetryAttempts != null &&
                    this.RetryAttempts.Equals(input.RetryAttempts))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.FallbackUrl != null)
                    hashCode = hashCode * 59 + this.FallbackUrl.GetHashCode();
                if (this.ErrorUrl != null)
                    hashCode = hashCode * 59 + this.ErrorUrl.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.RetryAttempts != null)
                    hashCode = hashCode * 59 + this.RetryAttempts.GetHashCode();
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
