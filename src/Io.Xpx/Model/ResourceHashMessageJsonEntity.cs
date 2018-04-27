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
    /// ResourceHashMessageJsonEntity
    /// </summary>
    [DataContract]
    public partial class ResourceHashMessageJsonEntity :  IEquatable<ResourceHashMessageJsonEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceHashMessageJsonEntity" /> class.
        /// </summary>
        /// <param name="Digest">Digest.</param>
        /// <param name="Hash">Hash.</param>
        /// <param name="Keywords">Keywords.</param>
        /// <param name="MetaData">MetaData.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Size">Size.</param>
        /// <param name="Timestamp">Timestamp.</param>
        /// <param name="Type">Type.</param>
        public ResourceHashMessageJsonEntity(string Digest = default(string), string Hash = default(string), string Keywords = default(string), string MetaData = default(string), string Name = default(string), int? Size = default(int?), long? Timestamp = default(long?), string Type = default(string))
        {
            this.Digest = Digest;
            this.Hash = Hash;
            this.Keywords = Keywords;
            this.MetaData = MetaData;
            this.Name = Name;
            this.Size = Size;
            this.Timestamp = Timestamp;
            this.Type = Type;
        }
        
        /// <summary>
        /// Gets or Sets Digest
        /// </summary>
        [DataMember(Name="digest", EmitDefaultValue=false)]
        public string Digest { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name="metaData", EmitDefaultValue=false)]
        public string MetaData { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceHashMessageJsonEntity {\n");
            sb.Append("  Digest: ").Append(Digest).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as ResourceHashMessageJsonEntity);
        }

        /// <summary>
        /// Returns true if ResourceHashMessageJsonEntity instances are equal
        /// </summary>
        /// <param name="other">Instance of ResourceHashMessageJsonEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceHashMessageJsonEntity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Digest == other.Digest ||
                    this.Digest != null &&
                    this.Digest.Equals(other.Digest)
                ) && 
                (
                    this.Hash == other.Hash ||
                    this.Hash != null &&
                    this.Hash.Equals(other.Hash)
                ) && 
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.Equals(other.Keywords)
                ) && 
                (
                    this.MetaData == other.MetaData ||
                    this.MetaData != null &&
                    this.MetaData.Equals(other.MetaData)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Digest != null)
                    hash = hash * 59 + this.Digest.GetHashCode();
                if (this.Hash != null)
                    hash = hash * 59 + this.Hash.GetHashCode();
                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();
                if (this.MetaData != null)
                    hash = hash * 59 + this.MetaData.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
