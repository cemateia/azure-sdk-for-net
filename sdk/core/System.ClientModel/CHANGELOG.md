# Release History

## 1.1.0-beta.6 (Unreleased)

### Features Added

### Breaking Changes

### Bugs Fixed

### Other Changes

## 1.1.0-beta.5 (2024-07-11)

### Features Added

- Added `AsyncPageCollection<T>` and `PageCollection<T>` types as return types from paginated service operations, and `ContinuationToken` type for resuming collection state across processes.

### Other Changes

- Renamed `AsyncResultCollection<T>` and `ResultCollection<T>` to `AsyncCollectionResult<T>` and `CollectionResult<T>` to standardize use of the `Result` suffix in type names.
- Removed `AsyncPageableCollection<T>` and `PageableCollection<T>` that previously represented collections of items rather than collections of pages of items, and renamed `ResultPage<T>` to `PageResult<T>`.

## 1.1.0-beta.4 (2024-05-16)

### Features Added

- Added `BufferResponse` property to `RequestOptions` so protocol method callers can turn off response buffering if desired.
- Added `AsyncResultCollection<T>` and `ResultCollection<T>` for clients to return from service methods where the service response contains a collection of values.
- Added `AsyncPageableCollection<T>`, `PageableCollection<T>` and `ResultPage<T>` for clients to return from service methods where collection values are delivered to the client over one or more service responses.
- Added `SetRawResponse` method to `ClientResult` to allow the response held by the result to be changed, for example by derived types that obtain multiple responses from polling the service.

### Other Changes

- `ClientResult.GetRawResponse` will now throw `InvalidOperationException` if called before the result's raw response is set, for example by collection result types that delay sending a request to the service until the collection is enumerated.

## 1.1.0-beta.3 (2024-04-04)

### Features Added

- Added protected `Apply(PipelineMessage)` method to `RequestOptions` so that derived types can extend its functionality.
- Added `Create(Stream)` overload to `BinaryContent`.

### Other Changes

- Removed `[Serializable]` attribute and serialization constructor from `ClientResultException`.
- Made `value` parameter nullable in `PipelineMessage.SetProperty` method.
- Made `options` parameter to `PipelineMessage.Apply` nullable.

## 1.1.0-beta.2 (2024-02-29)

### Features Added

- Added `ExtractResponse` method to `PipelineMessage` to enable returning an undisposed `PipelineResponse` from protocol methods.
- Added `CreateAsync` factory method to `ClientResultException` to allow creating exceptions in an async context.
- Added an implicit cast from `string` to `ApiKeyCredential`.
- Added an implicit cast from `ClientResult<T>` to `T`.

### Other Changes

- Changed `HttpClientPipelineTransport.Shared` and `ClientRetryPolicy.Default` from static readonly fields to static properties.
- Changed `PipelineResponse.Content` property from abstract to virtual.
- Removed the `ResponseBufferingPolicy` and moved response buffering functionality into `PipelineTransport`.
- Made `CancellationToken` parameter passed to `BinaryContent.WriteTo` optional.

## 1.1.0-beta.1 (2024-02-01)

### Features Added

- Initial preview release of convenience types in the System.ClientModel namespace, including `ClientResult<T>`, `KeyCredential`, and `ClientResultException`.
- Initial preview release of pipeline types, including `ClientPipeline`, `PipelinePolicy`, and `PipelineMessage`.

## 1.0.0 (2024-01-03)

### Features Added

- Initial release of ModelReaderWriter APIs for reading and writing models in different formats.

## 1.0.0-beta.2 (2023-12-14)

### Other Changes

- `ModelReaderWriter` and `ModelReaderWriterOptions` have moved to System.ClientModel.Primitives namespace
- `JsonModelConverter` was removed.

## 1.0.0-beta.1 (2023-11-22)

### Features Added

- ModelReaderWriter APIs for reading and writing models in different formats.
