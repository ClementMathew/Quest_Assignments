// Datatypes of sql

1. VARCHAR (Variable Character):
   Stores: Non-Unicode characters (e.g., English letters, numbers, and symbols).
   Size: It stores variable-length strings with a maximum size of 8,000 characters.
   Use case: Use VARCHAR when you only need to store English text or other characters that don't require special encoding (ASCII characters).
   Example: VARCHAR(50) means a string with up to 50 characters.
   Efficiency: Takes less space compared to NVARCHAR for English-only text since each character uses 1 byte.

2. NVARCHAR (National Variable Character):
   Stores: Unicode characters (e.g., supports multiple languages, including English, Chinese, Arabic, etc.).
   Size: It stores variable-length strings, but each character takes 2 bytes. The maximum size is 4,000 characters.
   Use case: Use NVARCHAR when storing text in multiple languages, especially when you need Unicode support.
   Example: NVARCHAR(50) means a Unicode string with up to 50 characters.
   Efficiency: Takes more space (2 bytes per character) compared to VARCHAR.

3. TEXT:
   Stores: Large non-Unicode text data.
   Size: Used for storing very large text data (up to 2 GB of text).
   Use case: Historically used to store large text blocks (e.g., articles, descriptions, etc.), but it's now deprecated.
   Replacement: Use VARCHAR(MAX) instead, which supports large text data.

4.CHAR
CHAR(n): Fixed-length non-Unicode string. If the string is shorter than n, it is padded with spaces. Example: CHAR(10) will always take 10 characters of storage.

Numeric Data Types:

INT: Integer data type. Range: -2,147,483,648 to 2,147,483,647 (4 bytes).

BIGINT: Larger integer data type. Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 (8 bytes).

SMALLINT: Smaller integer data type. Range: -32,768 to 32,767 (2 bytes).

TINYINT: Tiny integer. Range: 0 to 255 (1 byte).

DECIMAL(p, s) / NUMERIC(p, s): Fixed precision and scale numeric values. p specifies the total number of digits, and s specifies the number of digits to the right of the decimal point.

FLOAT: Floating-point number, used for approximate values. 8-byte size.

Date and Time Data Types:

DATE: Stores only date (YYYY-MM-DD). Range: 0001-01-01 to 9999-12-31.

TIME: Stores only time (HH:MM). Can store fractions of a second.

DATETIME: Stores both date and time. Range: 1753-01-01 to 9999-12-31.

SMALLDATETIME: Stores date and time, but with less precision than DATETIME. Range: 1900-01-01 to 2079-06-06.

DATETIME2: Extended version of DATETIME with higher precision for time. Recommended for new applications.
