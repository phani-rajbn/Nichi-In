//Common.js
function $(element){
	return document.getElementById(element);
}

function $click(element, fname){
	var e = $(element);
	e.addEventListener("click", fname);
}

function addEvent(collection, func){
	for (var i = 0; i < collection.length; i++) {
		collection[i].addEventListener("click", func);
	}
}

function createDate(yy, mm, dd){
	return new Date(yy, mm- 1, dd);
}

function displayDate(date){
	var dd = date.getDate();
	var mm = date.getMonth() + 1;//index is 0....
	if(mm < 10)
		mm = "0" + mm;
	var yy = date.getFullYear();
	return yy + "-" + mm + "-" + dd;
}