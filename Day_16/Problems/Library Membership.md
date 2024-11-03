# Library Membership

#### Question :

Here are some short questions based on the provided code:

1. **What is the purpose of the `GenericResponse` class in this project?**

2. **How does the `BookRepository` class retrieve a book by its name?**

3. **What message is displayed if a book is not found by `GetById` in the `BookRepository`?**

4. **In `MemberRepository`, how is a member retrieved by their email?**

5. **What is the output if a member with the given email is not found in `GetByEmail`?**

6. **What does the `DataStore` class initialize in its static constructor?**

7. **How is the `Library_Membership` class using `BookRepository` to fetch books by ID and name?**

8. **What does the `MemberRepository` return if a member with a specific name is not in the `DataStore`?**

9. **What does `Console.WriteLine(memberResult.Data.BookId);` display in `Library_Membership`?**

10. **What data type does `GetAllBooks` in `BookRepository` return?**

<br>

---

#### Code :

```c#

// Datastore Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Membership.Entities;

namespace Library_Membership.Data
{
    internal class DataStore
    {
        public static List<Books> Books;
        public static List<Member> Members;
        static DataStore()
        {
            Books = new List<Books>
            {
                new Books{ Id = 1, BookName ="Book 1"},
                new Books { Id  = 2, BookName = "Book 2"},
                new Books { Id = 3, BookName = "Book 3"}
            };
            Members = new List<Member>
            {
                new Member{ Id = 100, Name = "Gatha", Email ="g@gmail.com",BookId = 1},
                new Member{ Id = 101, Name = "Geethu", Email ="gee@gmail.com",BookId = 1},
                new Member{ Id = 102, Name = "Manu", Email ="ma@gmail.com",BookId = 2},
                new Member{ Id = 103, Name = "Midhun", Email ="g@gmail.com",BookId = 3},
                new Member{ Id = 104, Name = "Leela", Email ="lee@gmail.com",BookId = 2},
            };
        }
    }
}

```

```c#

// Book Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Membership.Entities
{
    internal class Books
    {
        public int Id { get; set; }
        public string BookName { get; set; }
    }
}

```

```c#

// Member Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Membership.Entities
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int BookId { get; set; }
    }
}

```

```c#

// Book Repository Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Membership.Data;
using Library_Membership.Entities;

namespace Library_Membership.Repositories
{
    internal class BookRepository
    {
        // Method to retrieve all books

        public GenericResponse<List<Books>> GetAllBooks()
        {
            var books = DataStore.Books;

            return new GenericResponse<List<Books>>
            {
                Success = true,
                Data = books
            };
        }

        // Method to retrieve a book by its ID

        public GenericResponse<Books> GetById(int id)
        {
            var book = DataStore.Books.FirstOrDefault(x => x.Id == id);

            if (book == null)
            {
                return new GenericResponse<Books>
                {
                    Success = false,
                    Message = "Book is not available"
                };
            }

            return new GenericResponse<Books>
            {
                Success = true,
                Data = book
            };
        }

        // Method to retrieve a book by its name

        public GenericResponse<Books> GetByName(string name)
        {
            var book = DataStore.Books.FirstOrDefault(x => x.BookName == name);

            if (book == null)
            {
                return new GenericResponse<Books>
                {
                    Success = false,
                    Message = "Book is not available"
                };
            }

            return new GenericResponse<Books>
            {
                Success = true,
                Data = book
            };
        }
    }
}

```

```c#

// Member Repository Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Membership.Data;
using Library_Membership.Entities;

namespace Library_Membership.Repositories
{
    internal class MemberRepository
    {
        // Method to retrieve all members

        public GenericResponse<List<Member>> GetAllMembers()
        {
            var members = DataStore.Members;

            return new GenericResponse<List<Member>>
            {
                Success = true,
                Data = members
            };
        }

        // Method to retrieve a member by their name

        public GenericResponse<Member> GetByName(string name)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Name == name);

            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found"
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member
            };
        }

        // Method to retrieve a member by their email

        public GenericResponse<Member> GetByEmail(string email)
        {
            var member = DataStore.Members.FirstOrDefault(x => x.Email == email);

            if (member == null)
            {
                return new GenericResponse<Member>
                {
                    Success = false,
                    Message = "Member not found"
                };
            }

            return new GenericResponse<Member>
            {
                Success = true,
                Data = member
            };
        }
    }
}

```

```c#

// Generic Response Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Membership
{
    internal class GenericResponse<TData>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public TData Data { get; set; }
    }
}

```

```c#

// Library Membership Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Membership.Repositories;

namespace Library_Membership
{
    internal class Library_Membership
    {
        static void Main(string[] args)
        {
            // Book Repository Usage

            var bookRepository = new BookRepository();

            // Fetching book by ID

            var result = bookRepository.GetById(10);

            if (result.Success)
            {
                Console.WriteLine(result.Data.BookName);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            // Fetching book by Name

            var res = bookRepository.GetByName("Book 1");

            if (res.Success)
            {
                Console.WriteLine(res.Data.BookName);
            }
            else
            {
                Console.WriteLine(res.Message);
            }

            // Member Repository Usage

            var memberRepository = new MemberRepository();

            // Fetching member by Name

            var memberResult = memberRepository.GetByName("Gatha");

            if (memberResult.Success)
            {
                Console.WriteLine(memberResult.Data.BookId);
                Console.WriteLine(memberResult.Data.Email);
            }
            else
            {
                Console.WriteLine(memberResult.Message);
            }

            // Fetching member by Email

            var memberByEmail = memberRepository.GetByEmail("gg@gamil.com");

            if (memberByEmail.Success)
            {
                Console.WriteLine(memberByEmail.Data.Name);
            }
            else
            {
                Console.WriteLine(memberByEmail.Message);
            }
        }
    }
}

```
