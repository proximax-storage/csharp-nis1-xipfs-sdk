/* 
 * Proximax P2P Storage REST API
 *
 * Proximax P2P Storage REST API
 *
 * OpenAPI spec version: v0.0.1
 * Contact: alvin.reyes@botmill.io
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
    /// URI
    /// </summary>
    [DataContract]
    public partial class URI :  IEquatable<URI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="URI" /> class.
        /// </summary>
        /// <param name="Absolute">Absolute.</param>
        /// <param name="Authority">Authority.</param>
        /// <param name="Fragment">Fragment.</param>
        /// <param name="Host">Host.</param>
        /// <param name="Opaque">Opaque.</param>
        /// <param name="Path">Path.</param>
        /// <param name="Port">Port.</param>
        /// <param name="Query">Query.</param>
        /// <param name="RawAuthority">RawAuthority.</param>
        /// <param name="RawFragment">RawFragment.</param>
        /// <param name="RawPath">RawPath.</param>
        /// <param name="RawQuery">RawQuery.</param>
        /// <param name="RawSchemeSpecificPart">RawSchemeSpecificPart.</param>
        /// <param name="RawUserInfo">RawUserInfo.</param>
        /// <param name="Scheme">Scheme.</param>
        /// <param name="SchemeSpecificPart">SchemeSpecificPart.</param>
        /// <param name="UserInfo">UserInfo.</param>
        public URI(bool? Absolute = default(bool?), string Authority = default(string), string Fragment = default(string), string Host = default(string), bool? Opaque = default(bool?), string Path = default(string), int? Port = default(int?), string Query = default(string), string RawAuthority = default(string), string RawFragment = default(string), string RawPath = default(string), string RawQuery = default(string), string RawSchemeSpecificPart = default(string), string RawUserInfo = default(string), string Scheme = default(string), string SchemeSpecificPart = default(string), string UserInfo = default(string))
        {
            this.Absolute = Absolute;
            this.Authority = Authority;
            this.Fragment = Fragment;
            this.Host = Host;
            this.Opaque = Opaque;
            this.Path = Path;
            this.Port = Port;
            this.Query = Query;
            this.RawAuthority = RawAuthority;
            this.RawFragment = RawFragment;
            this.RawPath = RawPath;
            this.RawQuery = RawQuery;
            this.RawSchemeSpecificPart = RawSchemeSpecificPart;
            this.RawUserInfo = RawUserInfo;
            this.Scheme = Scheme;
            this.SchemeSpecificPart = SchemeSpecificPart;
            this.UserInfo = UserInfo;
        }
        
        /// <summary>
        /// Gets or Sets Absolute
        /// </summary>
        [DataMember(Name="absolute", EmitDefaultValue=false)]
        public bool? Absolute { get; set; }

        /// <summary>
        /// Gets or Sets Authority
        /// </summary>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public string Authority { get; set; }

        /// <summary>
        /// Gets or Sets Fragment
        /// </summary>
        [DataMember(Name="fragment", EmitDefaultValue=false)]
        public string Fragment { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Opaque
        /// </summary>
        [DataMember(Name="opaque", EmitDefaultValue=false)]
        public bool? Opaque { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets RawAuthority
        /// </summary>
        [DataMember(Name="rawAuthority", EmitDefaultValue=false)]
        public string RawAuthority { get; set; }

        /// <summary>
        /// Gets or Sets RawFragment
        /// </summary>
        [DataMember(Name="rawFragment", EmitDefaultValue=false)]
        public string RawFragment { get; set; }

        /// <summary>
        /// Gets or Sets RawPath
        /// </summary>
        [DataMember(Name="rawPath", EmitDefaultValue=false)]
        public string RawPath { get; set; }

        /// <summary>
        /// Gets or Sets RawQuery
        /// </summary>
        [DataMember(Name="rawQuery", EmitDefaultValue=false)]
        public string RawQuery { get; set; }

        /// <summary>
        /// Gets or Sets RawSchemeSpecificPart
        /// </summary>
        [DataMember(Name="rawSchemeSpecificPart", EmitDefaultValue=false)]
        public string RawSchemeSpecificPart { get; set; }

        /// <summary>
        /// Gets or Sets RawUserInfo
        /// </summary>
        [DataMember(Name="rawUserInfo", EmitDefaultValue=false)]
        public string RawUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets Scheme
        /// </summary>
        [DataMember(Name="scheme", EmitDefaultValue=false)]
        public string Scheme { get; set; }

        /// <summary>
        /// Gets or Sets SchemeSpecificPart
        /// </summary>
        [DataMember(Name="schemeSpecificPart", EmitDefaultValue=false)]
        public string SchemeSpecificPart { get; set; }

        /// <summary>
        /// Gets or Sets UserInfo
        /// </summary>
        [DataMember(Name="userInfo", EmitDefaultValue=false)]
        public string UserInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class URI {\n");
            sb.Append("  Absolute: ").Append(Absolute).Append("\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Fragment: ").Append(Fragment).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Opaque: ").Append(Opaque).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  RawAuthority: ").Append(RawAuthority).Append("\n");
            sb.Append("  RawFragment: ").Append(RawFragment).Append("\n");
            sb.Append("  RawPath: ").Append(RawPath).Append("\n");
            sb.Append("  RawQuery: ").Append(RawQuery).Append("\n");
            sb.Append("  RawSchemeSpecificPart: ").Append(RawSchemeSpecificPart).Append("\n");
            sb.Append("  RawUserInfo: ").Append(RawUserInfo).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  SchemeSpecificPart: ").Append(SchemeSpecificPart).Append("\n");
            sb.Append("  UserInfo: ").Append(UserInfo).Append("\n");
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
            return this.Equals(obj as URI);
        }

        /// <summary>
        /// Returns true if URI instances are equal
        /// </summary>
        /// <param name="other">Instance of URI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(URI other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Absolute == other.Absolute ||
                    this.Absolute != null &&
                    this.Absolute.Equals(other.Absolute)
                ) && 
                (
                    this.Authority == other.Authority ||
                    this.Authority != null &&
                    this.Authority.Equals(other.Authority)
                ) && 
                (
                    this.Fragment == other.Fragment ||
                    this.Fragment != null &&
                    this.Fragment.Equals(other.Fragment)
                ) && 
                (
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
                ) && 
                (
                    this.Opaque == other.Opaque ||
                    this.Opaque != null &&
                    this.Opaque.Equals(other.Opaque)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.RawAuthority == other.RawAuthority ||
                    this.RawAuthority != null &&
                    this.RawAuthority.Equals(other.RawAuthority)
                ) && 
                (
                    this.RawFragment == other.RawFragment ||
                    this.RawFragment != null &&
                    this.RawFragment.Equals(other.RawFragment)
                ) && 
                (
                    this.RawPath == other.RawPath ||
                    this.RawPath != null &&
                    this.RawPath.Equals(other.RawPath)
                ) && 
                (
                    this.RawQuery == other.RawQuery ||
                    this.RawQuery != null &&
                    this.RawQuery.Equals(other.RawQuery)
                ) && 
                (
                    this.RawSchemeSpecificPart == other.RawSchemeSpecificPart ||
                    this.RawSchemeSpecificPart != null &&
                    this.RawSchemeSpecificPart.Equals(other.RawSchemeSpecificPart)
                ) && 
                (
                    this.RawUserInfo == other.RawUserInfo ||
                    this.RawUserInfo != null &&
                    this.RawUserInfo.Equals(other.RawUserInfo)
                ) && 
                (
                    this.Scheme == other.Scheme ||
                    this.Scheme != null &&
                    this.Scheme.Equals(other.Scheme)
                ) && 
                (
                    this.SchemeSpecificPart == other.SchemeSpecificPart ||
                    this.SchemeSpecificPart != null &&
                    this.SchemeSpecificPart.Equals(other.SchemeSpecificPart)
                ) && 
                (
                    this.UserInfo == other.UserInfo ||
                    this.UserInfo != null &&
                    this.UserInfo.Equals(other.UserInfo)
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
                if (this.Absolute != null)
                    hash = hash * 59 + this.Absolute.GetHashCode();
                if (this.Authority != null)
                    hash = hash * 59 + this.Authority.GetHashCode();
                if (this.Fragment != null)
                    hash = hash * 59 + this.Fragment.GetHashCode();
                if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();
                if (this.Opaque != null)
                    hash = hash * 59 + this.Opaque.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this.RawAuthority != null)
                    hash = hash * 59 + this.RawAuthority.GetHashCode();
                if (this.RawFragment != null)
                    hash = hash * 59 + this.RawFragment.GetHashCode();
                if (this.RawPath != null)
                    hash = hash * 59 + this.RawPath.GetHashCode();
                if (this.RawQuery != null)
                    hash = hash * 59 + this.RawQuery.GetHashCode();
                if (this.RawSchemeSpecificPart != null)
                    hash = hash * 59 + this.RawSchemeSpecificPart.GetHashCode();
                if (this.RawUserInfo != null)
                    hash = hash * 59 + this.RawUserInfo.GetHashCode();
                if (this.Scheme != null)
                    hash = hash * 59 + this.Scheme.GetHashCode();
                if (this.SchemeSpecificPart != null)
                    hash = hash * 59 + this.SchemeSpecificPart.GetHashCode();
                if (this.UserInfo != null)
                    hash = hash * 59 + this.UserInfo.GetHashCode();
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
