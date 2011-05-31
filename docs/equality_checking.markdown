#Rules for equality checking - .Net

1. Is it a reference type (class)
  * Does it implement IEquatable<T> for itself - use it
  * Does it override Equals for itself - use it
  * Reference equality check

2. Is it a value type (struct)
  * Does it override Equals for itself - use it
  * Reflective field by field equality check
