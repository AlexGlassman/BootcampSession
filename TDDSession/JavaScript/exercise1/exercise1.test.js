const exercise1 = require('./exercise1');

test('Is true, true', () => {
	expect(exercise1.getTrue()).toBe(true);
});

test('Lets try a number', () => {
	expect(exercise1.getNumber()).toBe(4);
})

test('And an error', () => {
	expect(exercise1.throwError()).toThrow('Sample error 1')
})