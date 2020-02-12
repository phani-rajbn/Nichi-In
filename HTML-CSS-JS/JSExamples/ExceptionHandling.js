//ExceptionHandling.js
function testFunc() {
	try{
		var data = [ 01,34,45,45,54,34,5,345,55];
		document.write(data +"<br/>");
		for (var i = 0; i < data.length; i++) {
			document.write(data[i] + "<br/>");	
		}
		raiseException();
	}catch(e){
		document.write(e +"<br/>");
	}finally{
		document.write("All ended properly")
	}
}

function raiseException(){
	throw "error in the example"//Raise the exception
}

testFunc();