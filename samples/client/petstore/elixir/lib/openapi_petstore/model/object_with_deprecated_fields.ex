# NOTE: This file is auto generated by OpenAPI Generator 7.12.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule OpenapiPetstore.Model.ObjectWithDeprecatedFields do
  @moduledoc """
  
  """

  @derive Jason.Encoder
  defstruct [
    :uuid,
    :id,
    :deprecatedRef,
    :bars
  ]

  @type t :: %__MODULE__{
    :uuid => String.t | nil,
    :id => float() | nil,
    :deprecatedRef => OpenapiPetstore.Model.DeprecatedModel.t | nil,
    :bars => [String.t] | nil
  }

  alias OpenapiPetstore.Deserializer

  def decode(value) do
    value
     |> Deserializer.deserialize(:deprecatedRef, :struct, OpenapiPetstore.Model.DeprecatedModel)
  end
end

