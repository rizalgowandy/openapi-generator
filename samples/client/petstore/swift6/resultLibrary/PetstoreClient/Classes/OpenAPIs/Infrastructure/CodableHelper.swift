//
// CodableHelper.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation

internal class CodableHelper: @unchecked Sendable {
    internal init() {}

    private var customDateFormatter: DateFormatter?
    private var defaultDateFormatter: DateFormatter = OpenISO8601DateFormatter()

    private var customJSONDecoder: JSONDecoder?
    private lazy var defaultJSONDecoder: JSONDecoder = {
        let decoder = JSONDecoder()
        decoder.dateDecodingStrategy = .formatted(dateFormatter)
        return decoder
    }()

    private var customJSONEncoder: JSONEncoder?
    private lazy var defaultJSONEncoder: JSONEncoder = {
        let encoder = JSONEncoder()
        encoder.dateEncodingStrategy = .formatted(dateFormatter)
        encoder.outputFormatting = .prettyPrinted
        return encoder
    }()

    internal var dateFormatter: DateFormatter {
        get { return customDateFormatter ?? defaultDateFormatter }
        set { customDateFormatter = newValue }
    }
    internal var jsonDecoder: JSONDecoder {
        get { return customJSONDecoder ?? defaultJSONDecoder }
        set { customJSONDecoder = newValue }
    }
    internal var jsonEncoder: JSONEncoder {
        get { return customJSONEncoder ?? defaultJSONEncoder }
        set { customJSONEncoder = newValue }
    }

    internal func decode<T>(_ type: T.Type, from data: Data) -> Swift.Result<T, Error> where T: Decodable {
        return Swift.Result { try jsonDecoder.decode(type, from: data) }
    }

    internal func encode<T>(_ value: T) -> Swift.Result<Data, Error> where T: Encodable {
        return Swift.Result { try jsonEncoder.encode(value) }
    }
}
