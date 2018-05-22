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
    /// URL
    /// </summary>
    [DataContract]
    public partial class URL :  IEquatable<URL>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="URL" /> class.
        /// </summary>
        /// <param name="Authority">Authority.</param>
        /// <param name="Content">Content.</param>
        /// <param name="DefaultPort">DefaultPort.</param>
        /// <param name="File">File.</param>
        /// <param name="Host">Host.</param>
        /// <param name="Path">Path.</param>
        /// <param name="Port">Port.</param>
        /// <param name="Protocol">Protocol.</param>
        /// <param name="Query">Query.</param>
        /// <param name="_Ref">_Ref.</param>
        /// <param name="UserInfo">UserInfo.</param>
        public URL(string Authority = default(string), Object Content = default(Object), int? DefaultPort = default(int?), string File = default(string), string Host = default(string), string Path = default(string), int? Port = default(int?), string Protocol = default(string), string Query = default(string), string _Ref = default(string), string UserInfo = default(string))
        {
            this.Authority = Authority;
            this.Content = Content;
            this.DefaultPort = DefaultPort;
            this.File = File;
            this.Host = Host;
            this.Path = Path;
            this.Port = Port;
            this.Protocol = Protocol;
            this.Query = Query;
            this._Ref = _Ref;
            this.UserInfo = UserInfo;
        }
        
        /// <summary>
        /// Gets or Sets Authority
        /// </summary>
        [DataMember(Name="authority", EmitDefaultValue=false)]
        public string Authority { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public Object Content { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPort
        /// </summary>
        [DataMember(Name="defaultPort", EmitDefaultValue=false)]
        public int? DefaultPort { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

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
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name="protocol", EmitDefaultValue=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets _Ref
        /// </summary>
        [DataMember(Name="ref", EmitDefaultValue=false)]
        public string _Ref { get; set; }

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
            sb.Append("class URL {\n");
            sb.Append("  Authority: ").Append(Authority).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  DefaultPort: ").Append(DefaultPort).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  _Ref: ").Append(_Ref).Append("\n");
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
            return this.Equals(obj as URL);
        }

        /// <summary>
        /// Returns true if URL instances are equal
        /// </summary>
        /// <param name="other">Instance of URL to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(URL other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Authority == other.Authority ||
                    this.Authority != null &&
                    this.Authority.Equals(other.Authority)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.DefaultPort == other.DefaultPort ||
                    this.DefaultPort != null &&
                    this.DefaultPort.Equals(other.DefaultPort)
                ) && 
                (
                    this.File == other.File ||
                    this.File != null &&
                    this.File.Equals(other.File)
                ) && 
                (
                    this.Host == other.Host ||
                    this.Host != null &&
                    this.Host.Equals(other.Host)
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
                    this.Protocol == other.Protocol ||
                    this.Protocol != null &&
                    this.Protocol.Equals(other.Protocol)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this._Ref == other._Ref ||
                    this._Ref != null &&
                    this._Ref.Equals(other._Ref)
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
                if (this.Authority != null)
                    hash = hash * 59 + this.Authority.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.DefaultPort != null)
                    hash = hash * 59 + this.DefaultPort.GetHashCode();
                if (this.File != null)
                    hash = hash * 59 + this.File.GetHashCode();
                if (this.Host != null)
                    hash = hash * 59 + this.Host.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                if (this.Protocol != null)
                    hash = hash * 59 + this.Protocol.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
                if (this._Ref != null)
                    hash = hash * 59 + this._Ref.GetHashCode();
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