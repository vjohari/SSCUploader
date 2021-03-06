using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Result of cloud pool actions relating to application versions
  /// </summary>
  [DataContract]
  public class CloudPoolProjectVersionActionResponse {
    /// <summary>
    /// List of application version ids
    /// </summary>
    /// <value>List of application version ids</value>
    [DataMember(Name="projectVersionIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "projectVersionIds")]
    public List<long?> ProjectVersionIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CloudPoolProjectVersionActionResponse {\n");
      sb.Append("  ProjectVersionIds: ").Append(ProjectVersionIds).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
