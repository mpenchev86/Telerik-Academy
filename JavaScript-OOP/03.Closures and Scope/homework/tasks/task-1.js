/* Task Description */
/*
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	-Each book has unique title, author and ISBN
				*	-It must return the newly created book with assigned ID
				*	-If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	-Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	-When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	-Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	-Author is any non-empty string
			*	-Unique params are Book title and Book ISBN
			*	-Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/

function solve() {
	var library = (function () {
		var books = [],
			categories = [],
			regEx = /\D/g,
			sortedBooks = [];

		function listBooks() {
			// checks if an argument has been passed
			if (arguments.length > 0) {
				// checks if the argument is a category
				if (arguments[0].category) {
					validateCategory(arguments[0].category);
					for (var i in books) {
						if (books[i].category === arguments[0].category) {
							sortedBooks.push(books[i]);
						};
					};
					return sortedBooks;
				};
				// checks if the argument is an author
				if (arguments[0].author) {
					validateAuthor(arguments[0].author);

					for (var i in books) {
						if (books[i].author === arguments[0].author) {
							sortedBooks.push(books[i]);
						};
					};
					return sortedBooks;
				};
			};

			return books;
		}

		function addBook(book) {
			// book details validation
			validateTitle(book);
			validateAuthor(book);
			validateISBN(book);
			validateCategory(book.category);

			// add category to list, if missing
			if (!categories.some(function (elem) { return elem === book.category})) {
				book.category.ID = categories.length + 1;
				categories.push(book.category);
			}

			book.ID = books.length + 1;
			books.push(book);
			return book;
		}

		function listCategories() {
			return categories;
		}

		function validateISBN (book) {
			if ((book.isbn.length !== 10) &&
				(book.isbn.length !== 13) &&
				(book.isbn.search(regEx)) ) {
				throw new Error("The ISBN is invalid.");
			};
			if (books.some(function (elem) { return elem.isbn === book.isbn;})) {
				throw new Error("There's a book with the same ISBN.");
			};
		}

		function validateAuthor (book) {
			if (book.author === '') {
				throw new Error("The book's author is invalid.");
			};
		}

		function validateTitle (book) {
			if (book.title.length < 2 || book.title.length > 100) {
				throw new Error("The book's title has invalid length.");
			};
			if (books.some(function (elem) { return elem.title === book.title;})) {
				throw new Error("There's a book with the same title.");
			};
		}

		function validateCategory (category) {
			if (category.length < 2 || category.length > 100) {
				throw new Error("The book's category name has invalid length.");
			};
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	console.log(8732);
	return library;
}
solve();
module.exports = solve;
