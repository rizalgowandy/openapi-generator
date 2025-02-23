/* tslint:disable */
/* eslint-disable */
/**
 * Example
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { mapValues } from '../runtime';
import type { BranchDto } from './BranchDto';
import {
    BranchDtoFromJSON,
    BranchDtoFromJSONTyped,
    BranchDtoToJSON,
    BranchDtoToJSONTyped,
} from './BranchDto';

import { InternalAuthenticatedUserDto, InternalAuthenticatedUserDtoFromJSONTyped, InternalAuthenticatedUserDtoToJSON, InternalAuthenticatedUserDtoToJSONTyped } from './InternalAuthenticatedUserDto';
import { RemoteAuthenticatedUserDto, RemoteAuthenticatedUserDtoFromJSONTyped, RemoteAuthenticatedUserDtoToJSON, RemoteAuthenticatedUserDtoToJSONTyped } from './RemoteAuthenticatedUserDto';
/**
 * 
 * @export
 * @interface AbstractUserDto
 */
export interface AbstractUserDto {
    /**
     * 
     * @type {string}
     * @memberof AbstractUserDto
     */
    username?: string;
    /**
     * 
     * @type {BranchDto}
     * @memberof AbstractUserDto
     */
    branch?: BranchDto;
    /**
     * 
     * @type {string}
     * @memberof AbstractUserDto
     */
    type?: string;
}

/**
 * Check if a given object implements the AbstractUserDto interface.
 */
export function instanceOfAbstractUserDto(value: object): value is AbstractUserDto {
    return true;
}

export function AbstractUserDtoFromJSON(json: any): AbstractUserDto {
    return AbstractUserDtoFromJSONTyped(json, false);
}

export function AbstractUserDtoFromJSONTyped(json: any, ignoreDiscriminator: boolean): AbstractUserDto {
    if (json == null) {
        return json;
    }
    if (!ignoreDiscriminator) {
        if (json['type'] === 'internal-authenticated') {
            return InternalAuthenticatedUserDtoFromJSONTyped(json, ignoreDiscriminator);
        }
        if (json['type'] === 'remote-authenticated') {
            return RemoteAuthenticatedUserDtoFromJSONTyped(json, ignoreDiscriminator);
        }
    }
    return {
        
        'username': json['username'] == null ? undefined : json['username'],
        'branch': json['branch'] == null ? undefined : BranchDtoFromJSON(json['branch']),
        'type': json['type'] == null ? undefined : json['type'],
    };
}

export function AbstractUserDtoToJSON(json: any): AbstractUserDto {
    return AbstractUserDtoToJSONTyped(json, false);
}

export function AbstractUserDtoToJSONTyped(value?: AbstractUserDto | null, ignoreDiscriminator: boolean = false): any {
    if (value == null) {
        return value;
    }

    if (!ignoreDiscriminator) {
        switch (value['type']) {
            case 'internal-authenticated':
                return InternalAuthenticatedUserDtoToJSONTyped(value as InternalAuthenticatedUserDto, ignoreDiscriminator);
            case 'remote-authenticated':
                return RemoteAuthenticatedUserDtoToJSONTyped(value as RemoteAuthenticatedUserDto, ignoreDiscriminator);
            default:
                throw new Error(`No variant of AbstractUserDto exists with 'type=${value['type']}'`);
        }
    }

    return {
        
        'username': value['username'],
        'branch': BranchDtoToJSON(value['branch']),
        'type': value['type'],
    };
}

