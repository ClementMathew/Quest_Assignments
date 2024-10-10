//Foreign key insights:

If you attempt to insert a record into the orders table with a product_id or user_id that does not exist in the products or users tables, it will violate the foreign key constraint.
If you want to delete a parent record (the one with the primary key) that is being referenced by a child record (the one with the foreign key), you must first delete the corresponding child records before you can delete the parent. This ensures that referential integrity is maintained.
foreign keys are critical for:

.Enforcing relationships between tables.
.Ensuring referential integrity by preventing orphaned records.
.Maintaining data consistency across related tables.
.Preventing invalid data from being inserted or deleted without proper constraints.

//WHAT IS NORMALISATION?

Normalization is the process of organizing data in a database. It includes creating tables and establishing relationships between those tables according to rules designed both to protect the data and to make the database more flexible by eliminating redundancy and inconsistent dependency.

Redundant data wastes disk space and creates maintenance problems. If data that exists in more than one place must be changed, the data must be changed in exactly the same way in all locations.

There are a few rules for database normalization. Each rule is called a "normal form." If the first rule is observed, the database is said to be in "first normal form." If the first three rules are observed, the database is considered to be in "third normal form." Although other levels of normalization are possible, third normal form is considered the highest level necessary for most applications.

First Normal Form (1NF):
This is the most basic level of normalization. In 1NF, each table cell should contain only a single value, and each column should have a unique name.
The first normal form helps to eliminate duplicate data and simplify queries.
If a relation contain composite or multi-valued attribute, it violates first normal form or a relation is in first normal form if it does not contain any composite or multi-valued attribute.
A relation is in first normal form if every attribute in that relation is singled valued attribute.

Second Normal Form (2NF):
2NF eliminates redundant data by requiring that each non-key attribute be dependent on the primary key.
This means that each column should be directly related to the primary key, and not to other columns.
A relation is in 2NF if it is in 1NF and any non-prime attribute (attributes which are not part of any candidate key) is not partially dependent on any proper subset of any candidate key of the table. In other words, we can say that, every non-prime attribute must be fully dependent on each candidate key.

A functional dependency X->Y (where X and Y are set of attributes) is said to be in partial dependency, if Y can be determined by any proper subset of X.

However, in 2NF it is possible for a prime attribute to be partially dependent on any candidate key, but every non-prime attribute must be fully dependent(or not partially dependent) on each candidate key of the table.

Third Normal Form (3NF):
3NF builds on 2NF by requiring that all non-key attributes are independent of each other.
This means that each column should be directly related to the primary key, and not to any other columns in the same table.
A relation is said to be in third normal form, if we did not have any transitive dependency for non-prime attributes. The basic condition with the Third Normal Form is that, the relation must be in Second Normal Form.

Below mentioned is the basic condition that must be hold in the non-trivial functional dependency X -> Y:

X is a Super Key.
Y is a Prime Attribute ( this means that element of Y is some part of Candidate Key).
