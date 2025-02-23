// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

/*
 * OpenAPI Petstore
 *
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * API version: 1.0.0
 */

package petstoreserver

import (
	"context"
	"net/http"
	"errors"
)

// FakeAPIService is a service that implements the logic for the FakeAPIServicer
// This service should implement the business logic for every endpoint for the FakeAPI API.
// Include any external packages or services that will be required by this service.
type FakeAPIService struct {
}

// NewFakeAPIService creates a default api service
func NewFakeAPIService() *FakeAPIService {
	return &FakeAPIService{}
}

// FakePostTest - POST a test batch
func (s *FakeAPIService) FakePostTest(ctx context.Context, body string) (ImplResponse, error) {
	// TODO - update FakePostTest with the required logic for this service method.
	// Add api_fake_service.go to the .openapi-generator-ignore to avoid overwriting this service implementation when updating open api generation.

	// TODO: Uncomment the next line to return response Response(200, bool{}) or use other options such as http.Ok ...
	// return Response(200, bool{}), nil

	return Response(http.StatusNotImplemented, nil), errors.New("FakePostTest method not implemented")
}
