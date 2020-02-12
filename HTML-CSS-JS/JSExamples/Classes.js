//The JS file can contain only the JS code so that it could be refered inside multiple HTML Pages. It follows  the Seperation of UI and the Logic of the programming. However, U cannot replace the usage of JS code inside HTML Documents. U still need to use script tag to include the JS code in the HTML document and to manipulate the DOM elements using JS. 
var emp = {};//This is an object in Js...
emp.empId = 123;//creating a field called empId whose value is 123...
emp.empName = "Phaniraj";
emp.empAddress = "Bangalore";
//Use this kind of object creation when u need to create singleton objects. jQuery apps use singleton when they wish to pass an object to the AJAX Call they want to post. 
console.log(emp);

//////////////////Creating Classes for multiple object creations////////////////////////////////
//the object is refered within itself using this....
function book(id, title, cost, author){
	this.bookId = id;
	this.title = title;
	this.price = cost;
	this.author = author;
}

var bookStore = function(){
	var books = [
		/*new book(111, "JS Basics", 200, "Phaniraj"),
		new book(112, "JS Advanced", 400, "Vinod"),
		new book(113, "JS Projects", 500, "Ramnath"),
		new book(114, "Angular 8", 600, "Gopal")*/
	];

	this.addBook = function(bk){
		books.push(bk);
	}

	this.delete = function(id){
		var bk = books.find((bk)=>bk.bookId == id);
		if(bk == null){
			throw "Book not found to delete";
		}
		var index = books.indexOf(bk);//get the index of the found book...
		books.splice(index, 1); 
	}
	this.update = function(bk){
		var found = books.find((b)=>bk.bookId == b.bookId);
		if(found == null) throw "Book not found to update";
		found.title = bk.title;
		found.price = bk.price;
		found.author = bk.author;
	}

	this.getAll = function(){
		return books;
	}

	this.find = function(id){
		return books.find((b)=>b.bookId == id);
	}
}

