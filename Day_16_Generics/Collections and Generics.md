# Collections and Generics

The namespaces `System.Collections` and `System.Collections.Generic` provide a variety of data structures that enable developers to store, manipulate, and manage collections of objects effectively. Each namespace serves different purposes, tailored to specific use cases.

## 1. System.Collections (Non-Generic Collections)

The collections in `System.Collections` were primarily used before the introduction of generics in .NET. Although older, they still have applications where generic type information is not necessary.

### Use Cases:

- **Heterogeneous Data**: Storing objects of various types in the same collection.
- **Legacy Code**: Interacting with older codebases that utilize these non-generic collections.

### Examples:

- **ArrayList**: A resizable array that lacks type safety.
- **Hashtable**: A key-value pair structure without type constraints.

### Drawbacks:

These collections lack type safety and require boxing/unboxing for value types, which can lead to performance degradation. Thus, they are less commonly used in new applications.

## 2. System.Collections.Generic (Generic Collections)

`System.Collections.Generic` contains modern, type-safe collections that provide enhanced flexibility, performance, and compile-time safety. These collections are widely used in everyday C# development.

### Common Uses:

- **Type Safety**: Ensures all elements in a collection are of the same type, reducing runtime errors and typecasting needs.
- **Performance**: Avoids boxing and unboxing, leading to better performance with value types (e.g., `int`, `double`).

### Examples:

- **List<T>**: A dynamic array where `T` represents the type of objects stored. Commonly used for lists of items.
- **Dictionary<TKey, TValue>**: Stores key-value pairs with specified types for keys and values, useful for mapping values.
- **HashSet<T>**: A collection that allows only unique elements, preventing duplicates.
- **Queue<T>** and **Stack<T>**: Data structures that implement FIFO (First-In-First-Out) and LIFO (Last-In-First-Out) respectively.

### Use Cases for System.Collections.Generic:

- **Managing Lists of Data**: Using `List<T>` for dynamic arrays or lists.
- **Mapping Keys to Values**: Utilizing `Dictionary<TKey, TValue>` for key-value associations.
- **Efficient Searching or Lookups**: Fast lookups using `Dictionary` and `HashSet`.
- **Avoiding Duplicates**: Ensuring collections contain only unique elements with `HashSet<T>`.

## Summary of Use:

- **System.Collections.Generic**: Preferred for type-safe, high-performance data management, allowing for collections specialized to hold specific types (e.g., `List<int>` for integers).
- **System.Collections**: Mostly applicable for legacy applications or scenarios where type safety is not a concern. Its limitations (like lack of type safety and performance overhead) make it less desirable in modern applications.
