class DataStructureCreator {
	constructor() {
		this.values = {};
	}
	setNumberValue(numberValue) {
		this.values.number = numberValue;
	}
	setStringValue(stringValue) {
		this.values.string = stringValue;
	}
	setDateValue(dateValue) {
		this.values.date = dateValue
	}
	setArrayValue(arrayValue) {
		this.values.array = arrayValue
	}
	getAllValues() {
		return this.values;
	}
}

module.exports = DataStructureCreator