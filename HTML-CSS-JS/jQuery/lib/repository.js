//repository.js
class employee{
	constructor(id, name, address){
		this.empId = id;
		this.empName = name;
		this.empAddress = address;
	}
}

class empDatabase{

	constructor(){
		this.employees = [new employee(123, "Phaniraj", "Bangalore"),new employee(124, "Manjunath", "Mysore"),new employee(125, "Suresh", "Mysore"),new employee(126, "Ananth", "Bangalore"),new employee(127, "Ramesh", "Hassan")];

	}

	addEmployee(emp){
		this.employees.push(emp)
	}

	updateEmployee(emp){
		let temp = this.employees.find((e)=>e.empId == emp.empId);
		if(temp == undefined){
			throw "Employee not found to update";
		}
		temp.empName = emp.empName;
		temp.empAddress = emp.empAddress;
	}

	deleteEmployee(id){
		for (var i = 0; i < this.employees.length; i++) {
			if(this.employees[i].empId == id){
				this.employees.splice(i, 1);
				return;
			}
		}
		//throw `Employee by Id ${id} not found to delete`;
		throw "Employee by id " + id +" not found to update";
	}

	getAll(){
		return this.employees;
	}

	findEmp(id){
		return this.employees.find((e)=>e.empId == id);
	}
}