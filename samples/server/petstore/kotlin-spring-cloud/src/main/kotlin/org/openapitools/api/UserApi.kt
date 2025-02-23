/**
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech) (7.12.0-SNAPSHOT).
 * https://openapi-generator.tech
 * Do not edit the class manually.
*/
package org.openapitools.api

import org.openapitools.model.User
import org.springframework.http.HttpStatus
import org.springframework.http.MediaType
import org.springframework.http.ResponseEntity

import org.springframework.web.bind.annotation.*
import org.springframework.validation.annotation.Validated
import org.springframework.web.context.request.NativeWebRequest
import org.springframework.beans.factory.annotation.Autowired

import javax.validation.constraints.DecimalMax
import javax.validation.constraints.DecimalMin
import javax.validation.constraints.Email
import javax.validation.constraints.Max
import javax.validation.constraints.Min
import javax.validation.constraints.NotNull
import javax.validation.constraints.Pattern
import javax.validation.constraints.Size
import javax.validation.Valid

import kotlin.collections.List
import kotlin.collections.Map

@Validated
interface UserApi {


    @RequestMapping(
            method = [RequestMethod.POST],
            value = ["/user"],
            consumes = ["application/json"]
    )
    fun createUser( @Valid @RequestBody user: User): ResponseEntity<Unit> {
        return ResponseEntity(HttpStatus.NOT_IMPLEMENTED)
    }


    @RequestMapping(
            method = [RequestMethod.POST],
            value = ["/user/createWithArray"],
            consumes = ["application/json"]
    )
    fun createUsersWithArrayInput( @Valid @RequestBody user: kotlin.collections.List<User>): ResponseEntity<Unit> {
        return ResponseEntity(HttpStatus.NOT_IMPLEMENTED)
    }


    @RequestMapping(
            method = [RequestMethod.POST],
            value = ["/user/createWithList"],
            consumes = ["application/json"]
    )
    fun createUsersWithListInput( @Valid @RequestBody user: kotlin.collections.List<User>): ResponseEntity<Unit> {
        return ResponseEntity(HttpStatus.NOT_IMPLEMENTED)
    }


    @RequestMapping(
            method = [RequestMethod.DELETE],
            value = ["/user/{username}"]
    )
    fun deleteUser( @PathVariable("username") username: kotlin.String): ResponseEntity<Unit> {
        return ResponseEntity(HttpStatus.NOT_IMPLEMENTED)
    }


    @RequestMapping(
            method = [RequestMethod.GET],
            value = ["/user/{username}"],
            produces = ["application/xml", "application/json"]
    )
    fun getUserByName( @PathVariable("username") username: kotlin.String): ResponseEntity<User> {
        return ResponseEntity(HttpStatus.NOT_IMPLEMENTED)
    }


    @RequestMapping(
            method = [RequestMethod.GET],
            value = ["/user/login"],
            produces = ["application/xml", "application/json"]
    )
    fun loginUser(@NotNull @Pattern(regexp="^[a-zA-Z0-9]+[a-zA-Z0-9\\.\\-_]*[a-zA-Z0-9]+$")  @Valid @RequestParam(value = "username", required = true) username: kotlin.String,@NotNull  @Valid @RequestParam(value = "password", required = true) password: kotlin.String): ResponseEntity<kotlin.String> {
        return ResponseEntity(HttpStatus.NOT_IMPLEMENTED)
    }


    @RequestMapping(
            method = [RequestMethod.GET],
            value = ["/user/logout"]
    )
    fun logoutUser(): ResponseEntity<Unit> {
        return ResponseEntity(HttpStatus.NOT_IMPLEMENTED)
    }


    @RequestMapping(
            method = [RequestMethod.PUT],
            value = ["/user/{username}"],
            consumes = ["application/json"]
    )
    fun updateUser( @PathVariable("username") username: kotlin.String, @Valid @RequestBody user: User): ResponseEntity<Unit> {
        return ResponseEntity(HttpStatus.NOT_IMPLEMENTED)
    }
}
