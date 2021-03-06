/* 
 * Proximax P2P Storage REST API
 *
 * Proximax P2P Storage REST API
 *
 * OpenAPI spec version: v0.0.1
 * Contact: proximax.storage@proximax.io
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
using SwaggerDateConverter = Io.Xpx.Client.SwaggerDateConverter;

namespace Io.Xpx.Model
{
    /// <summary>
    /// AccountMetaData
    /// </summary>
    [DataContract]
    public partial class AccountMetaData :  IEquatable<AccountMetaData>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets RemoteStatus
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RemoteStatusEnum
        {
            
            /// <summary>
            /// Enum REMOTE for "REMOTE"
            /// </summary>
            [EnumMember(Value = "REMOTE")]
            REMOTE,
            
            /// <summary>
            /// Enum ACTIVATING for "ACTIVATING"
            /// </summary>
            [EnumMember(Value = "ACTIVATING")]
            ACTIVATING,
            
            /// <summary>
            /// Enum ACTIVE for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE,
            
            /// <summary>
            /// Enum DEACTIVATING for "DEACTIVATING"
            /// </summary>
            [EnumMember(Value = "DEACTIVATING")]
            DEACTIVATING,
            
            /// <summary>
            /// Enum INACTIVE for "INACTIVE"
            /// </summary>
            [EnumMember(Value = "INACTIVE")]
            INACTIVE
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum LOCKED for "LOCKED"
            /// </summary>
            [EnumMember(Value = "LOCKED")]
            LOCKED,
            
            /// <summary>
            /// Enum UNLOCKED for "UNLOCKED"
            /// </summary>
            [EnumMember(Value = "UNLOCKED")]
            UNLOCKED
        }

        /// <summary>
        /// Gets or Sets RemoteStatus
        /// </summary>
        [DataMember(Name="remoteStatus", EmitDefaultValue=false)]
        public RemoteStatusEnum? RemoteStatus { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountMetaData" /> class.
        /// </summary>
        /// <param name="Cosignatories">Cosignatories.</param>
        /// <param name="CosignatoryOf">CosignatoryOf.</param>
        /// <param name="RemoteStatus">RemoteStatus.</param>
        /// <param name="Status">Status.</param>
        public AccountMetaData(List<AccountInfo> Cosignatories = default(List<AccountInfo>), List<AccountInfo> CosignatoryOf = default(List<AccountInfo>), RemoteStatusEnum? RemoteStatus = default(RemoteStatusEnum?), StatusEnum? Status = default(StatusEnum?))
        {
            this.Cosignatories = Cosignatories;
            this.CosignatoryOf = CosignatoryOf;
            this.RemoteStatus = RemoteStatus;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets Cosignatories
        /// </summary>
        [DataMember(Name="cosignatories", EmitDefaultValue=false)]
        public List<AccountInfo> Cosignatories { get; set; }

        /// <summary>
        /// Gets or Sets CosignatoryOf
        /// </summary>
        [DataMember(Name="cosignatoryOf", EmitDefaultValue=false)]
        public List<AccountInfo> CosignatoryOf { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountMetaData {\n");
            sb.Append("  Cosignatories: ").Append(Cosignatories).Append("\n");
            sb.Append("  CosignatoryOf: ").Append(CosignatoryOf).Append("\n");
            sb.Append("  RemoteStatus: ").Append(RemoteStatus).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as AccountMetaData);
        }

        /// <summary>
        /// Returns true if AccountMetaData instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountMetaData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Cosignatories == other.Cosignatories ||
                    this.Cosignatories != null &&
                    this.Cosignatories.SequenceEqual(other.Cosignatories)
                ) && 
                (
                    this.CosignatoryOf == other.CosignatoryOf ||
                    this.CosignatoryOf != null &&
                    this.CosignatoryOf.SequenceEqual(other.CosignatoryOf)
                ) && 
                (
                    this.RemoteStatus == other.RemoteStatus ||
                    this.RemoteStatus != null &&
                    this.RemoteStatus.Equals(other.RemoteStatus)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.Cosignatories != null)
                    hash = hash * 59 + this.Cosignatories.GetHashCode();
                if (this.CosignatoryOf != null)
                    hash = hash * 59 + this.CosignatoryOf.GetHashCode();
                if (this.RemoteStatus != null)
                    hash = hash * 59 + this.RemoteStatus.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
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
