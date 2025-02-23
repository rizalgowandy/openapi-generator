/*
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.fasterxml.jackson.annotation.JsonInclude;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.annotation.JsonValue;
import com.fasterxml.jackson.annotation.JsonPropertyOrder;
import com.fasterxml.jackson.annotation.JsonTypeName;
import com.fasterxml.jackson.dataformat.xml.annotation.*;
import javax.xml.bind.annotation.*;
import javax.xml.bind.annotation.adapters.*;
import io.github.threetenjaxb.core.*;

/**
 * Model for testing reserved words
 */
@JsonPropertyOrder({
  ModelReturn.JSON_PROPERTY_RETURN
})
@JsonTypeName("Return")
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", comments = "Generator version: 7.12.0-SNAPSHOT")
@XmlRootElement(name = "Return")
@XmlAccessorType(XmlAccessType.FIELD)
@JacksonXmlRootElement(localName = "Return")
public class ModelReturn {
  public static final String JSON_PROPERTY_RETURN = "return";
  @XmlElement(name = "return")
  @javax.annotation.Nullable
  private Integer _return;

  public ModelReturn() {
  }

  public ModelReturn _return(@javax.annotation.Nullable Integer _return) {
    
    this._return = _return;
    return this;
  }

  /**
   * Get _return
   * @return _return
   */
  @javax.annotation.Nullable
  @JsonProperty(JSON_PROPERTY_RETURN)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  @JacksonXmlProperty(localName = "return")

  public Integer getReturn() {
    return _return;
  }


  @JsonProperty(JSON_PROPERTY_RETURN)
  @JsonInclude(value = JsonInclude.Include.USE_DEFAULTS)
  @JacksonXmlProperty(localName = "return")
  public void setReturn(@javax.annotation.Nullable Integer _return) {
    this._return = _return;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ModelReturn _return = (ModelReturn) o;
    return Objects.equals(this._return, _return._return);
  }

  @Override
  public int hashCode() {
    return Objects.hash(_return);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ModelReturn {\n");
    sb.append("    _return: ").append(toIndentedString(_return)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

