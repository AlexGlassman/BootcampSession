const calculate = (num1, num2, num3) => {
	switch (op)
	{
	  case "+":
	  	return num1 + num2;
	  case "-":
	    return num1 - num2;
	  case "*":
	    return num1 * num2;
	  case "/":
	    return num1 / num2;
	  default:
	    return 0;
	}
}

module.exports = {
	calculate
}