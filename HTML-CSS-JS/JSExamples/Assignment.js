/*
Create a class called Ticket which has the following members:
TicketId
Name
DateOfBooking
MatchDate
StandName : Gallery, Pavillion, GRV Stand, CubbonPark.
Price
-----------------------------------------------------------
Create an HTML Page called KSCA.html. 
It should have a div element that allows User to provide details of the ticket booking. User should enter the details and display it inside a <p>. 

*/
function setPrice(standName){
	switch(standName){
			case "Gallery":
				return 200;
			case "Pavillion":
				return 4000;
			case "GRV Stand":
				return 1500;
			case "CubbonPark":
				return 2500;
			default:
				return 0;
		}
}
var ticket = function(id, name, date, match, stand){
	this.ticketNo = id;
	this.name = name;
	this.bookingDate = date;
	this.matchDate = match;
	this.standName = stand;
	this.price = 0.0;
}

