const getTrue = () => {
	return false;
}
const getNumber = () => {
	return 6;
}
const throwError = () => {
	throw 'Sample error';
}

module.exports = {
	getTrue,
	getNumber,
	throwError
}