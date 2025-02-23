// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CopyActivity
    /// </summary>
    public partial class CopyActivity : EntityBase, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyActivity" /> class.
        /// </summary>
        /// <param name="copyActivitytt">copyActivitytt</param>
        [JsonConstructor]
        public CopyActivity(string copyActivitytt) : base()
        {
            Schema = (SchemaEnum)Enum.Parse(typeof(SchemaEnum), this.GetType().Name);
            CopyActivitytt = copyActivitytt;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Defines Schema
        /// </summary>
        public enum SchemaEnum
        {
            /// <summary>
            /// Enum ScopeActivity for value: ScopeActivity
            /// </summary>
            ScopeActivity = 1
        }

        /// <summary>
        /// Returns a <see cref="SchemaEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static SchemaEnum SchemaEnumFromString(string value)
        {
            if (value.Equals("ScopeActivity"))
                return SchemaEnum.ScopeActivity;

            throw new NotImplementedException($"Could not convert value to type SchemaEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="SchemaEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SchemaEnum? SchemaEnumFromStringOrDefault(string value)
        {
            if (value.Equals("ScopeActivity"))
                return SchemaEnum.ScopeActivity;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="SchemaEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string SchemaEnumToJsonValue(SchemaEnum value)
        {
            if (value == SchemaEnum.ScopeActivity)
                return "ScopeActivity";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// The discriminator
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public new SchemaEnum Schema { get; }

        /// <summary>
        /// Gets or Sets CopyActivitytt
        /// </summary>
        [JsonPropertyName("copyActivitytt")]
        public string CopyActivitytt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CopyActivity {\n");
            sb.Append("  ").Append(base.ToString()?.Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CopyActivitytt: ").Append(CopyActivitytt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="CopyActivity" />
    /// </summary>
    public class CopyActivityJsonConverter : JsonConverter<CopyActivity>
    {
        /// <summary>
        /// Deserializes json to <see cref="CopyActivity" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override CopyActivity Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<CopyActivity.SchemaEnum?> schema = default;
            Option<string> copyActivitytt = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "$schema":
                            string schemaRawValue = utf8JsonReader.GetString();
                            if (schemaRawValue != null)
                                schema = new Option<CopyActivity.SchemaEnum?>(CopyActivity.SchemaEnumFromStringOrDefault(schemaRawValue));
                            break;
                        case "copyActivitytt":
                            copyActivitytt = new Option<string>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!schema.IsSet)
                throw new ArgumentException("Property is required for class CopyActivity.", nameof(schema));

            if (!copyActivitytt.IsSet)
                throw new ArgumentException("Property is required for class CopyActivity.", nameof(copyActivitytt));

            if (schema.IsSet && schema.Value == null)
                throw new ArgumentNullException(nameof(schema), "Property is not nullable for class CopyActivity.");

            if (copyActivitytt.IsSet && copyActivitytt.Value == null)
                throw new ArgumentNullException(nameof(copyActivitytt), "Property is not nullable for class CopyActivity.");

            return new CopyActivity(copyActivitytt.Value);
        }

        /// <summary>
        /// Serializes a <see cref="CopyActivity" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="copyActivity"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, CopyActivity copyActivity, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, copyActivity, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="CopyActivity" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="copyActivity"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, CopyActivity copyActivity, JsonSerializerOptions jsonSerializerOptions)
        {
            if (copyActivity.CopyActivitytt == null)
                throw new ArgumentNullException(nameof(copyActivity.CopyActivitytt), "Property is required for class CopyActivity.");

            writer.WriteString("$schema", CopyActivity.SchemaEnumToJsonValue(copyActivity.Schema));

            writer.WriteString("copyActivitytt", copyActivity.CopyActivitytt);
        }
    }
}
